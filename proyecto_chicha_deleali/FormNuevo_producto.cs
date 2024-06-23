using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proyecto_chicha_deleali
{

    public partial class FormNuevo_producto : Form
    {
        private SQLiteConnection conn;
        //public SQLiteConnection conn = new SQLiteConnection("Data Source=Proyecto_python.db;Version=3;");
        public FormNuevo_producto()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
            // conn.Open();
            conn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1}", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Invalidate();
            dataGridView1.Update();


            conn.Close();
        }

        private void FormNuevo_producto_Load(object sender, EventArgs e)
        {

        }


        

        int existe = 1;
        double Cantidad_Producto1, conver, Cantidad_Producto2;
        string medida_1, medida_2, Nombre_Producto;
        int ID = 0;

        private void boton_regresar_Click(object sender, EventArgs e)
        {
            //abrir_panel(new inicio());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_ingreso_Click(object sender, EventArgs e)
        {
           
         
            txt_cantidad_nuevoProducto.Clear();
            txt_nombre_nuevoProducto.Clear();
            lista_de_Opciones_de_Medida.SelectedIndex = 0;
            txt_Categorias.SelectedIndex = 0; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from productos", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} ", conn);

            DataTable dt = new DataTable();
            
            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void lista_de_Opciones_de_Medida_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void boton_regresar_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Categorias.SelectedIndex == 3)
            {
                //lista_de_Opciones_de_Medida.Text = "Unica (utiles de cocina)"; 
                lista_de_Opciones_de_Medida.Text = "Unica (utiles de cocina)";
            }
        }

        int conver_categoria = 0;
        private void boton_Ingresar_producto_Click(object sender, EventArgs e)
        {
           
            string categorias = txt_Categorias.Text;
            switch (txt_Categorias.SelectedIndex)
            {
               
                case 1: conver_categoria = 1; break;
                case 2: conver_categoria = 2; break;
                case 3: conver_categoria = 3; break;
                case 4: conver_categoria = 4; break;


            }


            Nombre_Producto = txt_nombre_nuevoProducto.Text;
            string Cantidad_Producto = txt_cantidad_nuevoProducto.Text.Replace(",", ".");
            try
            {
                // Cantidad_Producto1 = Convert.ToDouble(Cantidad_Producto);
                Cantidad_Producto1 = Convert.ToDouble(Cantidad_Producto, CultureInfo.InvariantCulture);





                if (txt_Categorias.SelectedIndex == 3)
                {
                    //lista_de_Opciones_de_Medida.Text = "Unica (utiles de cocina)"; 
                    lista_de_Opciones_de_Medida.Items.Add("Unica (utiles de cocina)");
                }
                medida_1 = lista_de_Opciones_de_Medida.Text;
                medida_2 = lista_de_Opciones_de_Medida.Text;


                if (medida_1 == "Kilo")
                {
                    medida_1 = "kl";
                    medida_2 = "g";
                    conver = Cantidad_Producto1 * 1000;

                }
                else if (medida_1 == "Gramo")
                {
                    medida_1 = "kl";
                    medida_2 = "g";

                    Cantidad_Producto2 = Cantidad_Producto1;
                    conver = Cantidad_Producto2 / 1000;
                    Cantidad_Producto1 = conver;
                    conver = Cantidad_Producto2;

                }
                else if (medida_1 == "Litro")
                {
                    medida_1 = "l";
                    medida_2 = "ml";

                    conver = Cantidad_Producto1 * 1000;

                }
                else if (medida_1 == "Mililitro")
                {
                    medida_1 = "l";
                    medida_2 = "ml";

                    Cantidad_Producto2 = Cantidad_Producto1;
                    conver = Cantidad_Producto2 / 1000;
                    Cantidad_Producto1 = conver;
                    conver = Cantidad_Producto2;
                }
                else if (medida_1 == "Unica")
                {
                    medida_1 = "u";
                    medida_2 = medida_1;

                    conver = 0;
                }


                if (Nombre_Producto != "" && Cantidad_Producto1 > 0 && medida_1 != "Elige una medida" && categorias != "" && categorias != "Elige una medida")
                {
                    MessageBox.Show($"Producto: {Nombre_Producto}\nCantidad: {Cantidad_Producto1} {medida_1}\nOtra Medida: {conver} {medida_2} \nCategoria: {categorias}", "Información del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    try
                    {
                        conn.Open();
                        string consulta = "INSERT INTO productos (Nombre_Producto, Cantidad_Producto, medida_1, conver, medida_2, existe, ID_categorias) " +
                                          "VALUES (@Nombre_Producto, @Cantidad_Producto, @medida_1, @conver, @medida_2,@existe, @ID_categorias)";

                        using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre_Producto", Nombre_Producto);
                            cmd.Parameters.AddWithValue("@Cantidad_Producto", Cantidad_Producto1);
                            cmd.Parameters.AddWithValue("@medida_1", medida_1);
                            cmd.Parameters.AddWithValue("@conver", conver);
                            cmd.Parameters.AddWithValue("@medida_2", medida_2);
                            cmd.Parameters.AddWithValue("@existe", existe);
                            cmd.Parameters.AddWithValue("@ID_categorias", conver_categoria);



                            int filasInsertadas = cmd.ExecuteNonQuery();

                            if (filasInsertadas > 0)
                            {
                                MessageBox.Show("Se ha registrado el producto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el producto en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }



                }
                else
                {
                    MessageBox.Show("No rellenó todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                txt_cantidad_nuevoProducto.Clear();
                txt_nombre_nuevoProducto.Clear();
                lista_de_Opciones_de_Medida.SelectedIndex = 0;
                txt_Categorias.SelectedIndex = 0;











            }
            catch
            {
                MessageBox.Show("Error: No se pudo convertir la cantidad del producto.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
           

            

        }
        public void agregar()
        {

            string consulta;
            consulta = "insert into productos (Cantidad_Producto,medida_1,conver,medida2,existe) values ('" + Nombre_Producto+"',"+Cantidad_Producto1.ToString()+"',"+medida_1+"',"+ conver.ToString() +"',"+medida_2+"',"+existe.ToString()+")";
            SQLiteCommand cmd = new SQLiteCommand(consulta,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se han registrado con exito");

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}



        //private void txt_cantidad_nuevoProducto_TextChanged(object sender, EventArgs e)
        //{

//}

//private void abrir_panel(object formpanel)
//{
//    if (this.panelPrincipal.Controls.Count > 0)
//    {
//        this.panelPrincipal.Controls.RemoveAt(0);
//        Form fh = formpanel as Form;
//        fh.TopLevel = false;
//        fh.Dock = DockStyle.Fill;
//        this.panelPrincipal.Controls.Add(fh);
//        this.panelPrincipal.Tag = fh;
//        fh.Show();
//    }
//}



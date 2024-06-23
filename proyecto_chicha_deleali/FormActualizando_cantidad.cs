using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_chicha_deleali
{
    public partial class FormActualizando_cantidad : Form
    {
        private SQLiteConnection conn;
        public FormActualizando_cantidad()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        double Cantidad_mas_producto1;
        double Cantidad_mas_producto2;
        double conver;
        int ID;
        double Cantidad_Producto1, Cantidad_Producto2;
        string medida11, medida22;
        string ID_conver, nombre, medida_1, medida_2;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        string cantidad_producto1, cantidad_producto2;
        private void boton_mas_producto_Click(object sender, EventArgs e)
        {
            conn.Open();
            ID_conver = txt_buscar_id.Text.Replace(",", "."); ;
            cantidad_producto1 = txt_cantidad.Text;
            try
            {
                Cantidad_Producto1 = Convert.ToDouble(cantidad_producto1, CultureInfo.InvariantCulture);
                ID = Convert.ToInt16(ID_conver);



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

                if (Cantidad_Producto1 > 0 && medida_1 != "Elige una medida")
                {
                    if (medida_1 == "ml" || medida_1 == "l" || medida_1 == "g" || medida_1 == "kl")
                    {
                        MessageBox.Show($"\nCantidad: {Cantidad_Producto1} {medida_1}\nOtra Medida: {conver} {medida_2}", "Información del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        try
                        {

                            string consulta = "UPDATE productos SET Cantidad_Producto = @Cantidad_Producto1, medida_1 = @medida_1, conver = @conver, medida_2 = @medida_2 WHERE ID_Productos = @ID_Productos";

                            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                            {

                                cmd.Parameters.AddWithValue("@Cantidad_Producto1", Cantidad_Producto1);
                                cmd.Parameters.AddWithValue("@medida_1", medida_1);
                                cmd.Parameters.AddWithValue("@conver", conver);
                                cmd.Parameters.AddWithValue("@medida_2", medida_2);
                                cmd.Parameters.AddWithValue("@ID_Productos", ID);

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
                            MessageBox.Show($"Error al actualizar el producto en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        MessageBox.Show("medida invalida.", "Error: Medidas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                else
                {
                    MessageBox.Show("No rellenó todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }








            }
            catch
            {
                MessageBox.Show("Error: No se pudo convertir la cantidad del producto.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            




            SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} and ID_Productos= {ID}", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;


            conn.Close();

        }

    

        private void butto_bucar_Click(object sender, EventArgs e)
        {
            Form datagreviu = new datagreviu();
            datagreviu.Show();
        }

        
        private void boton_buscar_id_Click(object sender, EventArgs e)
        {
            ID_conver = txt_buscar_id.Text;
            try
            {
                ID = Convert.ToInt16(ID_conver);

                // Cambiar la consulta SQL para buscar el ID en la tabla "productos"
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT ID_Productos FROM productos WHERE ID_Productos = @ID_Productos", conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Productos", ID);
                    object ID_buscar = cmd.ExecuteScalar();

                    if (ID_buscar != null)
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT ID_Productos,Nombre_Producto,Cantidad_Producto,medida_1,conver,medida_2 FROM productos WHERE ID_Productos = {ID} AND  existe = {1}", conn);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        this.dataGridView1.DataSource = dt;


                        // Si el ID existe en la tabla "productos", mostrar los datos en el DataGridView

                    }
                    else
                    {
                        MessageBox.Show("El ID ingresado no existe en la base de datos.", "ID no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}

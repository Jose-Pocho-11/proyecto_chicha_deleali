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
    public partial class FormExtraerCantidad : Form
    {
        private SQLiteConnection conn;
        public FormExtraerCantidad()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        
    }
        int ID;
        string ID_conver;
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        string cantidad_mas_producto1, Medida_1, medida11;
        string cantidad_mas_producto2, medida_2;
        //string valor_seleccionado_medida; 

        double Cantidad_Producto1, Cantidad_Producto2;

        private void butto_bucar_Click(object sender, EventArgs e)
        {
            Form datagreviu = new datagreviu();
            datagreviu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0; 
            txt_a_extraer.Clear();
            lista_de_Opciones_de_MedidaA.SelectedIndex = 0;
        }

        double Cantidad_mas_producto1;
        double Cantidad_mas_producto2;
        double Conver;

       

        private void boton_mas_producto_Click(object sender, EventArgs e)
        {
            conn.Open();
            cantidad_mas_producto1 = txt_a_extraer.Text.Replace(",", ".");
            cantidad_mas_producto2 = cantidad_mas_producto1;
            Medida_1 = lista_de_Opciones_de_MedidaA.Text;
            medida_2 = lista_de_Opciones_de_MedidaA.Text;
           

            string consulta = "SELECT Cantidad_Producto, conver, medida_1 FROM productos WHERE ID_Productos = @ID_Productos";
            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@ID_Productos", ID);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["Cantidad_Producto"] != DBNull.Value)
                            Cantidad_Producto1 = Convert.ToDouble(reader["Cantidad_Producto"]);

                        if (reader["conver"] != DBNull.Value)
                            Cantidad_Producto2 = Convert.ToDouble(reader["conver"]);

                        if (reader["medida_1"] != DBNull.Value)
                            medida11 = (reader["medida_1"]).ToString();
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre ningún resultado
                    }
                }
            }
            try
            {
                //Cantidad_mas_producto1 = Convert.ToDouble(cantidad_mas_producto1);
                Cantidad_mas_producto1 = Convert.ToDouble(cantidad_mas_producto1, CultureInfo.InvariantCulture);







                if (Cantidad_mas_producto1 > 0)
                {
                    if (Cantidad_Producto1 > Cantidad_mas_producto1)// este if quitarlo 
                    {
                        if (Medida_1 == "Kilo")
                        {
                            Medida_1 = "kl";
                            medida_2 = "g";
                            Conver = Cantidad_mas_producto1 * 1000;
                        }
                        else if (Medida_1 == "Gramo")
                        {
                            Medida_1 = "kl";
                            medida_2 = "g";

                            Cantidad_mas_producto2 = Cantidad_mas_producto1;
                            Conver = Cantidad_mas_producto2 / 1000;
                            Cantidad_mas_producto1 = Conver;
                            Conver = Cantidad_mas_producto2;
                        }
                        else if (Medida_1 == "Litro")
                        {
                            Medida_1 = "l";
                            medida_2 = "ml";

                            Conver = Cantidad_mas_producto1 * 1000;
                        }
                        else if (Medida_1 == "Mililitro")
                        {
                            Medida_1 = "l";
                            medida_2 = "ml";

                            Cantidad_mas_producto2 = Cantidad_mas_producto1;
                            Conver = Cantidad_mas_producto2 / 1000;
                            Cantidad_mas_producto1 = Conver;
                            Conver = Cantidad_mas_producto2;
                        }
                        else if (Medida_1 == "Unica")
                        {
                            Medida_1 = "u";
                            medida_2 = Medida_1;

                            Conver = 0;
                        }

                        // aqui agg uno 
                    }
                    else if (medida_2 == "Mililitro" || medida_2 == "Gramo")
                    {
                        if (Cantidad_Producto2 > Cantidad_mas_producto1)
                        {
                            if (Medida_1 == "Kilo")
                            {
                                Medida_1 = "kl";
                                medida_2 = "g";
                                Conver = Cantidad_mas_producto1 * 1000;
                            }
                            else if (Medida_1 == "Gramo")
                            {
                                Medida_1 = "kl";
                                medida_2 = "g";

                                Cantidad_mas_producto2 = Cantidad_mas_producto1;
                                Conver = Cantidad_mas_producto2 / 1000;
                                Cantidad_mas_producto1 = Conver;
                                Conver = Cantidad_mas_producto2;
                            }
                            else if (Medida_1 == "Litro")
                            {
                                Medida_1 = "l";
                                medida_2 = "ml";

                                Conver = Cantidad_mas_producto1 * 1000;
                            }
                            else if (Medida_1 == "Mililitro")
                            {
                                Medida_1 = "l";
                                medida_2 = "ml";

                                Cantidad_mas_producto2 = Cantidad_mas_producto1;
                                Conver = Cantidad_mas_producto2 / 1000;
                                Cantidad_mas_producto1 = Conver;
                                Conver = Cantidad_mas_producto2;
                            }
                            else if (Medida_1 == "Unica")
                            {
                                Medida_1 = "u";
                                medida_2 = Medida_1;

                                Conver = 0;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Hay suficiente Inventario.", "Error de cantidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (medida11 == Medida_1)
                        {
                            using (SQLiteCommand cmdUpdate = new SQLiteCommand($"UPDATE productos SET Cantidad_Producto = Cantidad_Producto - @Cantidad_mas_producto1, conver = conver - @Cantidad_producto2 WHERE ID_Productos = @ID_Productos", conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@Cantidad_mas_producto1", Cantidad_mas_producto1);
                                cmdUpdate.Parameters.AddWithValue("@Cantidad_producto2", Conver);
                                cmdUpdate.Parameters.AddWithValue("@ID_Productos", ID);

                                int filasInsertadas = cmdUpdate.ExecuteNonQuery();

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
                        else
                        {
                            MessageBox.Show("Las medidas especificadas no coinciden con las medidas del producto.", "Error de medidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                  





                    SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT ID_Productos,Nombre_Producto,Cantidad_Producto,medida_1,conver,medida_2 FROM productos WHERE ID_Productos = {ID} AND  existe = {1}", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("La cantidad que colocaste es mayor a la que hay en la Base de Datos.", "Error de cantidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }









            }
            catch
            {
                MessageBox.Show("Error: No se pudo convertir la cantidad del producto.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close(); 
            }
            
        }
                
    }
}

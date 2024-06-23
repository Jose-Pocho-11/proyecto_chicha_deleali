using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_chicha_deleali
{
    public partial class FormEliminar_Producto : Form
    {
        private SQLiteConnection conn;
        public FormEliminar_Producto()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        private void butto_bucar_Click(object sender, EventArgs e)
        {
            Form datagreviu = new datagreviu();
            datagreviu.Show();
        }
        string ID_conver;
        int ID;

        private void boton_buscar_id_Click(object sender, EventArgs e)
        {
            ID_conver = txt_buscar_id.Text;
            try
            {
                ID = Convert.ToInt16(ID_conver);

                // Cambiar la consulta SQL para buscar el ID en la tabla "productos"
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT ID_Productos FROM productos WHERE ID_Productos = @ID_Productos AND existe = @existe", conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Productos", ID);
                    cmd.Parameters.AddWithValue("@existe", 1); 
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
        string existe_conver;
        int Existe;
        int existe_bd; 


        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            conn.Open();

            ID_conver = txt_buscar_id.Text;
            try
            {
                ID = Convert.ToInt16(ID_conver);
                Existe = Convert.ToInt16(existe_conver);
            }
            catch
            {
                MessageBox.Show("Error.", "Error con ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }


            string consulta = "SELECT Cantidad_Producto, conver, medida_1, existe FROM productos WHERE ID_Productos = @ID_Productos";
            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@ID_Productos", ID);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["existe"] != DBNull.Value)
                        {
                            existe_bd = Convert.ToInt16(reader["existe"]);

                        }
                    }  
                }
            }



            if (txt_buscar_id.Text!="")
            {
                if (existe_bd == 1)
                {
                    Existe = 0;
                    using (SQLiteCommand cmdUpdate = new SQLiteCommand($"UPDATE productos SET existe = @existe WHERE ID_Productos = @ID_Productos", conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@existe", Existe);
                        cmdUpdate.Parameters.AddWithValue("@ID_Productos", ID);

                        int filasInsertadas = cmdUpdate.ExecuteNonQuery();

                        if (filasInsertadas > 0)
                        {
                            MessageBox.Show("Se ha Eliminado el producto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                        }
                    }

                    SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT ID_Productos,Nombre_Producto,Cantidad_Producto,medida_1,conver,medida_2 FROM productos WHERE existe = {1}", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Este producto ya ha sido eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error: No ha rellenado todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

           
        }

        private void label_titulo_mas_producto_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void poner_id_Click(object sender, EventArgs e)
        {

        }

        private void FormEliminar_Producto_Load(object sender, EventArgs e)
        {

        }
    }
}

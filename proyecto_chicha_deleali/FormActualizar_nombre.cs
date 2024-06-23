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
    public partial class FormActualizar_nombre : Form
    {
        private SQLiteConnection conn;
        public FormActualizar_nombre()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        private void butto_bucar_Click(object sender, EventArgs e)
        {
            Form datagreviu = new datagreviu();
            datagreviu.Show();
        }
        double Cantidad_Producto1, Cantidad_Producto2;
        string medida11, medida22;
        string ID_conver, nombre, Medida_1, medida_2;
        string cantidad_producto1, cantidad_producto2;

        private void button1_Click(object sender, EventArgs e)
        {
            txt_buscar_id.Clear();
            txt_nombre.Clear(); 
        }

        double Cantidad_mas_producto1;
        double Cantidad_mas_producto2;
        double Conver;
        int ID;
        int conver_categoria;
        string categoria; 

        private void boton_mas_producto_Click(object sender, EventArgs e)
        {
            conn.Open();
            nombre = txt_nombre.Text;
            categoria = txt_Categorias.Text;
            ID_conver = txt_buscar_id.Text;
            try
            {
                ID = Convert.ToInt16(ID_conver);
            }
            catch
            {
                MessageBox.Show("Error.", "Error con ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

            switch (txt_Categorias.SelectedIndex)
            {

                case 1: conver_categoria = 1; break;
                case 2: conver_categoria = 2; break;
                case 3: conver_categoria = 3; break;
                case 4: conver_categoria = 4; break;


            }
           // MessageBox.Show($"id categorias{conver_categoria}\nNombre: {nombre} {ID}");

            if (nombre != "" && categoria !="" && categoria != "Elige una medida")
            {
                using (SQLiteCommand cmdUpdate = new SQLiteCommand($"UPDATE productos SET Nombre_Producto = @Nombre_Producto, ID_Categorias = @ID_categorias WHERE ID_Productos = @ID_Productos", conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@Nombre_Producto", nombre);
                    cmdUpdate.Parameters.AddWithValue("@ID_categorias", conver_categoria);
                    cmdUpdate.Parameters.AddWithValue("@ID_Productos", ID);

                    int filasInsertadas = cmdUpdate.ExecuteNonQuery();

                    if (filasInsertadas > 0)
                    {
                        MessageBox.Show("Se ha actualizado el producto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("No has llenado todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1}", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;

            conn.Close();

        }
        // fin 

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

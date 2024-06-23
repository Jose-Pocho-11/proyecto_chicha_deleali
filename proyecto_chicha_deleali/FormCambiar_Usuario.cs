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
    public partial class FormCambiar_Usuario : Form
    {
        private SQLiteConnection conn;
        public FormCambiar_Usuario()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        string contraseña_actual, contraseña_extraida, usuario_nuevo;

        private void boton_actualizar_usuario_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (contraseña_actual == contraseña_extraida)
            {

                label1.Visible = true;
                txt_Nuevo_usuario.Visible = true;
                boton_actualizar_usuario.Visible = true;

                usuario_nuevo = txt_Nuevo_usuario.Text;
                if (usuario_nuevo!="")
                {
                    using (SQLiteCommand cmdUpdate = new SQLiteCommand($"UPDATE login SET usuario = @usuario", conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@usuario", usuario_nuevo);


                        int filasInsertadas = cmdUpdate.ExecuteNonQuery();

                        if (filasInsertadas > 0)
                        {
                            MessageBox.Show("Se ha actualizado el Nombre de Usuario con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No ha rellenado todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("La contraseña no es correcta.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña_actual.Clear();
                txt_Nuevo_usuario.Clear();
                label1.Visible = false;
                txt_Nuevo_usuario.Visible = false;
                boton_actualizar_usuario.Visible = false;
            }
            conn.Close();   
        }

        private void boton_buscar_id_Click(object sender, EventArgs e)
        {
            conn.Open(); 
            contraseña_actual = txt_Contraseña_actual.Text;

            string consulta = "SELECT * FROM login"; 
            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
            {
                

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["contraseña"] != DBNull.Value)
                             contraseña_extraida = reader["contraseña"].ToString();
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre ningún resultado
                    }
                }
            }

            if (contraseña_actual == contraseña_extraida)
            {

                label1.Visible = true; 
                txt_Nuevo_usuario.Visible = true;
                boton_actualizar_usuario.Visible = true; 

               
                
            }
            else
            {
                MessageBox.Show("La contraseña no es correcta.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña_actual.Clear();
                txt_Nuevo_usuario.Clear();
                label1.Visible = false;
                txt_Nuevo_usuario.Visible = false;
                boton_actualizar_usuario.Visible = false;
            }
            conn.Close(); 

        }
    }
}

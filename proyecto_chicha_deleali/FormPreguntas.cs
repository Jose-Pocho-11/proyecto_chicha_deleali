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
using System.Runtime.InteropServices;

namespace proyecto_chicha_deleali
{
    public partial class FormPreguntas : Form
    {
        private SQLiteConnection conn;
        public FormPreguntas()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        string respuesta1, respuesta2,respuesta_obtenida1, respuesta_obtenida2,clave_obtenida,pregunta1,pregunta2;

        private void boton_minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void boton_cerra_login_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            this.Hide();
            formlogin.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void boton_obtener_clave_Click(object sender, EventArgs e)
        {
            respuesta1 = txt_respuesta_1.Text;
            respuesta2 = txt_respuesta_2.Text;
            pregunta1 = "¿Cual es tu color favorito?";
            pregunta2 = "¿Cual es tu número de cedula?"; 

            conn.Open();
            string consulta = $"SELECT * FROM preguntas where pregunta = @pregunta";

          

            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@pregunta", pregunta1);


                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    


                    if (reader.Read())
                    {
                        if (reader["respuesta"] != DBNull.Value)
                            respuesta_obtenida1 = reader["respuesta"].ToString();
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre ningún resultado
                    }
                }
            }
            

            string consulta2 = $"SELECT respuesta FROM preguntas where pregunta =@pregunta";
            using (SQLiteCommand cmd = new SQLiteCommand(consulta2, conn))
            {

                cmd.Parameters.AddWithValue("@pregunta", pregunta2);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                 
                    if (reader.Read())
                    {
                        if (reader["respuesta"] != DBNull.Value)
                            respuesta_obtenida2 = reader["respuesta"].ToString();
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre ningún resultado
                    }
                }
            }

            string consulta3 = "SELECT contraseña FROM login";
            using (SQLiteCommand cmd = new SQLiteCommand(consulta3, conn))
            {


                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["contraseña"] != DBNull.Value)
                            clave_obtenida = reader["contraseña"].ToString();
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre ningún resultado
                    }
                }
            }



            if (respuesta1 == respuesta_obtenida1 && respuesta2 == respuesta_obtenida2)
            {
                MessageBox.Show($"Esta es su contraseña {clave_obtenida} " +
                    
            $". Si desea modificarla, por favor diríjase al apartado de configuración 'Cambiar Contraseña'.", "Mensaje de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLogin formlogin = new FormLogin();
                        this.Hide();
                        formlogin.Show();

            }
            else
            {
                MessageBox.Show("Las respuestas fueron respondidas erróneamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           conn.Close();    
        }
    }
}

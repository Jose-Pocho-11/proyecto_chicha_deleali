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
using System.Configuration;
using System.Runtime.InteropServices;

namespace proyecto_chicha_deleali
{
    public partial class FormLogin : Form
    {
        private SQLiteConnection conn;
        public FormLogin()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=Proyecto_python.db;Version=3;");
            conn.Open();
        }

        private void bonton_entrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT usuario FROM login WHERE usuario = @usuario", conn))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                object userId = cmd.ExecuteScalar();

                if (userId != null)
                {
                    using (SQLiteCommand contraseñaCmd = new SQLiteCommand("SELECT contraseña FROM login WHERE usuario = @usuario", conn))
                    {
                        contraseñaCmd.Parameters.AddWithValue("@usuario", userId);
                        string storedPassword = contraseñaCmd.ExecuteScalar().ToString();

                        if (contraseña == storedPassword)
                        {
                            MessageBox.Show("Credenciales válidas. Acceso concedido.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMenu_inicio formMenu_Inicio = new FormMenu_inicio();
                            this.Hide();
                            formMenu_Inicio.Show();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta. Por favor, verifica tus credenciales.", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado. Por favor, verifica tus credenciales.", "Usuario No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            txt_contraseña.Clear();
            txt_usuario.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton_cerra_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_restaurar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            boton_restaurar_login.Visible = false;
            boton_maximizar_login.Visible = true;
        }

        private void boton_minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void boton_maximizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            boton_maximizar_login.Visible = false;
            boton_restaurar_login.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void olvido_contraseña_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntas = new FormPreguntas();
            this.Hide();
            formPreguntas.Show();

        }
        
    }
}

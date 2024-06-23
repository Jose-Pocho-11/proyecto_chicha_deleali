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
    public partial class FormCambiar_Contraseña : Form
    {
        private SQLiteConnection conn;
       
        public FormCambiar_Contraseña()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }
        string contraseña_actual, contraseña_nueva, verificacion_contraseña, contraseña_extraida;//

        private void boton_actualizar_contraseña_Click(object sender, EventArgs e)
        {
            contraseña_actual = txt_contraseña_actual.Text;
            contraseña_nueva = txt_contraseña_nueva.Text;
            verificacion_contraseña = txt_verificacion_contraseña.Text;
            
            if(contraseña_nueva!="" && verificacion_contraseña != "" && contraseña_actual!="")
            {
                if (contraseña_nueva == verificacion_contraseña)
                {
                    conn.Open();

                    using (SQLiteCommand cmdUpdate = new SQLiteCommand($"UPDATE login SET contraseña = @contraseña", conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@contraseña", contraseña_nueva);


                        int filasInsertadas = cmdUpdate.ExecuteNonQuery();

                        if (filasInsertadas > 0)
                        {
                            MessageBox.Show("Se ha actualizado la Contraseña con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_contraseña_actual.Clear();
                            txt_contraseña_nueva.Clear();
                            txt_verificacion_contraseña.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close(); 
                    }


                }
                else
                {
                    MessageBox.Show("No Coinciden Las contraseñas.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_verificacion_contraseña.Clear(); 
                }


            }
            else
            {
                MessageBox.Show("Error no ha rellenado todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void boton_Contra_actual_Click(object sender, EventArgs e)
        {
            
            contraseña_actual = txt_contraseña_actual .Text;



            conn.Open();
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
                    conn.Close();
                }

                if (contraseña_actual == contraseña_extraida)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    txt_contraseña_nueva.Visible = true;
                    txt_verificacion_contraseña.Visible = true;
                    boton_actualizar_contraseña.Visible = true; 
                }
                else
                {
                    MessageBox.Show("La contraseña no es correcta.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contraseña_actual.Clear(); 
                }

               



            }

        }
    }
}

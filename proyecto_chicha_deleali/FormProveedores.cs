using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto_chicha_deleali
{
    public partial class FormProveedores : Form
    {
        private SQLiteConnection conn; 

        public FormProveedores()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }
        string cantidad; 
        double cantidad_conver, categoria_Producto;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        void Mostrar()
        {
            conn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT P.Nombre_Proveedor AS 'Nombre del Proveedor', P.Precio_Por_Unidad AS 'Precio Por unidad',P.Costo_Fijo As 'Costo Fijo'" +
            $",C.Categoria As Categoria FROM Proveedores P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE C.ID_categorias = {categoria_Producto} ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            conn.Close();
        }

        void Conctartar_ws(string numero, string mensaje)
        {
           // String numero = "Zdana Unefa";
           //string mensaje = "vamos a programar? (desde c#)";
            if (numero != "")
            {
                //+numero + "?text=" + mensaje
                //numero = "+58" + numero;
                System.Diagnostics.Process.Start("https://wa.me/");


                System.Threading.Thread.Sleep(10000);
                SendKeys.SendWait("^n");
                SendKeys.SendWait("{Enter}");

                System.Threading.Thread.Sleep(6500);
                SendKeys.SendWait(numero);
                SendKeys.SendWait("{Enter}");
                SendKeys.SendWait("{TAB}");
                SendKeys.SendWait("{Enter}");


                System.Threading.Thread.Sleep(2000);
                SendKeys.SendWait(mensaje);
                SendKeys.SendWait("{Enter}");

                //Process p = new Process();
                //p.StartInfo.FileName = @"C:\Users\jose daniel moreno\OneDrive\Escritorio\WhatsApps.exe";
                //p.Start();

                //System.Threading.Thread.Sleep(5000);
                //SendKeys.SendWait("^n");
                //SendKeys.SendWait("{Enter}");

                //System.Threading.Thread.Sleep(2000);
                //SendKeys.SendWait(mensaje);
                //SendKeys.SendWait("{Enter}");
            }
            else
            {
                MessageBox.Show("no hay mensaje");
            }
        }

        double costo_fijo, Precio_por_unidad, costo_final1,costo_final2;
        string nombre_empresa, numero_de_telefono,mensaje;

        private void boton_cerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormArbol formarbolito = new FormArbol();
            this.Hide();
            formarbolito.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        double costo_fijo2, Precio_por_unidad2, unidades;
        string nombre_empresa2, numero_de_telefono2, unidades_para_convertir;


        private void Boton_Conctactar_Click(object sender, EventArgs e)
        {
            unidades_para_convertir = txt_cantidad_Unidad.Text;

            try
            {
                unidades = Convert.ToInt16(unidades_para_convertir);


                if (unidades>0)
                {
                    switch (txt_Categorias.SelectedIndex)
                    {

                        case 1:
                            conn.Open();

                            string consulta = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 4);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            string consulta2 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta2, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 3);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa2 = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad2 = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo2 = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono2 = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            costo_final1 = (Precio_por_unidad * unidades) + costo_fijo;
                            costo_final2 = (Precio_por_unidad2 * unidades) + costo_fijo2;


                            if (costo_final1 > costo_final2)
                            {

                               
                                mensaje = $"Buenos dias {nombre_empresa2} quisiera encargar unos productos.";
                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa2} con un costo total de {costo_final2},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }



                            }
                            else
                            {
                                
                                mensaje = $"Buenos dias {nombre_empresa} quisiera encargar unos productos.";
                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa} con un costo total de {costo_final1},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }

                            }
                            conn.Close();




                            break;


                        case 2:

                            conn.Open();

                            string consulta3 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta3, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 1);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            string consulta4 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta4, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 2);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa2 = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad2 = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo2 = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono2 = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            costo_final1 = (Precio_por_unidad * unidades) + costo_fijo;
                            costo_final2 = (Precio_por_unidad2 * unidades) + costo_fijo2;

                            if (costo_final1 > costo_final2)
                            {
                                mensaje = $"Buenos dias {nombre_empresa2} quisiera encargar unos productos.";
                             
                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa2} con un costo total de {costo_final2},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }

                            }
                            else
                            {
                                mensaje = $"Buenos dias {nombre_empresa} quisiera encargar unos productos.";
                               
                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa} con un costo total de {costo_final1},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }

                            }
                            conn.Close();





                            break;
                        case 3:


                            conn.Open();

                            string consulta5 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta5, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 7);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            string consulta6 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta6, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 8);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa2 = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad2 = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo2 = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono2 = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            costo_final1 = (Precio_por_unidad * unidades) + costo_fijo;
                            costo_final2 = (Precio_por_unidad2 * unidades) + costo_fijo2;

                            if (costo_final1 > costo_final2)
                            {
                             
                                mensaje = $"Buenos dias {nombre_empresa2} quisiera encargar unos productos.";

                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa2} con un costo total de {costo_final2},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }
                            }
                            else
                            {
                              
                                mensaje = $"Buenos dias {nombre_empresa} quisiera encargar unos productos.";

                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa} con un costo total de {costo_final1},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }
                            }
                            conn.Close();





                            break;
                        case 4:

                            conn.Open();

                            string consulta8 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta8, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 5);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            string consulta9 = $"SELECT Nombre_Proveedor, Precio_Por_Unidad, Costo_fijo,numero_telefonico FROM Proveedores WHERE ID_Categorias = @ID_Categorias and ID_Proveedores = @ID_Proveedores";
                            using (SQLiteCommand cmd = new SQLiteCommand(consulta9, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID_Categorias", txt_Categorias.SelectedIndex);
                                cmd.Parameters.AddWithValue("@ID_Proveedores", 6);

                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (reader["Nombre_Proveedor"] != DBNull.Value)
                                            nombre_empresa2 = (reader["Nombre_Proveedor"]).ToString();

                                        if (reader["Precio_Por_Unidad"] != DBNull.Value)
                                            Precio_por_unidad2 = Convert.ToDouble(reader["Precio_Por_Unidad"]);

                                        if (reader["Costo_fijo"] != DBNull.Value)
                                            costo_fijo2 = Convert.ToDouble(reader["Costo_fijo"]);


                                        if (reader["numero_telefonico"] != DBNull.Value)
                                            numero_de_telefono2 = (reader["numero_telefonico"]).ToString();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que no se encuentre ningún resultado
                                    }
                                }
                            }


                            costo_final1 = (Precio_por_unidad * unidades) + costo_fijo;
                            costo_final2 = (Precio_por_unidad2 * unidades) + costo_fijo2;

                            if (costo_final1 > costo_final2)
                            {
                           
                                mensaje = $"Buenos dias {nombre_empresa2} quisiera encargar unos productos.";

                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa2} con un costo total de {costo_final2},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }
                            }
                            else
                            {
                               
                                mensaje = $"Buenos dias {nombre_empresa} quisiera encargar unos productos.";

                                if (MessageBox.Show($"El Proveedor más optimo es {nombre_empresa} con un costo total de {costo_final1},¿Quiere conctactar al Proveedor por WhatsApp?", "mesaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Conctartar_ws("Zdana Unefa", mensaje);
                                }
                            }
                            conn.Close();



                            break;

                        default: MessageBox.Show("Por favor, indique una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    }

                }
                else
                {
                    MessageBox.Show("Las Unidades tiene que ser Mayores a 0");
                }
            }
            catch
            {
                if (txt_cantidad_Unidad.Text =="") 
                {
                    MessageBox.Show("Rellene todas las casillas");
                }
                else
                {
                    MessageBox.Show("error aqui con las unidades");
                }
              
                conn.Close(); 
            }



            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (txt_Categorias.SelectedIndex)
            {
                case 1: categoria_Producto = 1; Mostrar(); break;
                case 2: categoria_Producto = 2; Mostrar(); break;
                case 3: categoria_Producto = 3; Mostrar(); break;
                case 4: categoria_Producto = 4; Mostrar(); break;
                default:MessageBox.Show("Por favor, indique una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);break;
            }


        }
    }
}

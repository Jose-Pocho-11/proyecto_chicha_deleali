using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyecto_chicha_deleali
{
    public partial class datagreviu : Form
    {

        private SQLiteConnection conn;
        public datagreviu()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void boton_cerra_Click(object sender, EventArgs e)
        {

            this.Close(); 
        }

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        int contador;  
        private void butto_bucar_Click(object sender, EventArgs e)
        {
            contador++; 
            panel_de_filtrar.Visible = true;
            if (contador == 2)
            {
                contador = 0; 
                panel_de_filtrar.Visible = false; 
            }
            conn.Open();

            if (check_todos.Checked==true || check_bebidas.Checked == true && check_concina.Checked == true && check_ingredientes.Checked == true && check_otros.Checked == true)
            {
                check_bebidas.Checked = true;
                check_ingredientes.Checked = true;
                check_otros.Checked= true;
                check_concina.Checked = true;

                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1}", conn);
               
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }       //Trios                                                                                                                         BIO
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == true && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'utiles de cocina'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                         //BIC
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'otros'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //BOC
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'ingredientes'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //IOC
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == true && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'bebidas'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }

                                                                        // parejas
                                                                                                                                                   // BO
            else if (check_bebidas.Checked == true && check_otros.Checked==true && check_ingredientes.Checked==false && check_concina.Checked==false )
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas'  OR C.Categoria = 'otros'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                   //IO
            else if (check_ingredientes.Checked==true && check_otros.Checked==true && check_bebidas.Checked==false && check_concina.Checked == false)
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros'  OR C.Categoria = 'ingredientes'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }
                                                                                                                                                    //BC
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked==true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas' OR C.Categoria = 'utiles de cocina' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //BI
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked==false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes' OR C.Categoria = 'bebidas'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //IC
            else if (check_bebidas.Checked == false && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked==true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes' OR C.Categoria = 'utiles de cocina'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       // OC
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked==true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros' OR C.Categoria = 'utiles de cocina' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }



                                                             //aqui para abajo son individuales                       B
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }                                                                                                        //I
            else if (check_ingredientes.Checked == true && check_otros.Checked == false && check_bebidas.Checked == false && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }                                                                                                        //O
            else if (check_otros.Checked == true && check_ingredientes.Checked == false && check_bebidas.Checked == false && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }                                                                                                                                          // C
            else if (check_otros.Checked == false && check_ingredientes.Checked == false && check_bebidas.Checked == false && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'utiles de cocina' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }
            else
            {
                conn.Close();
            }







            
           
        }

        private void boton_maximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            boton_maximizar.Visible = false;
            boton_restaurar.Visible = true;
        }

        private void boton_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            boton_restaurar.Visible = false;
            boton_maximizar.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            dataGridView3.Refresh();
            SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT ID_Productos, Nombre_Producto, Cantidad_Producto, medida_1, conver, medida_2 FROM productos WHERE existe = {1}", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();

            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

//    private void boton_maximizar_Click(object sender, EventArgs e)
//        {
//            this.WindowState = FormWindowState.Maximized;
//            boton_maximizar.Visible = false;
//            boton_restaurar.Visible = true;
//        }

//        private void boton_restaurar_Click(object sender, EventArgs e)
//        {
//            this.WindowState = FormWindowState.Normal;
//            boton_restaurar.Visible = false;
//            boton_maximizar.Visible = true;

//        }

//        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
              
//        }

//        private void butto_bucar_Click(object sender, EventArgs e)
//        {
//            conn.Open();
//            SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT ID_Productos,Nombre_Producto,Cantidad_Producto,medida_1,conver,medida_2 FROM productos WHERE  existe = {1}", conn);
//            DataTable dt = new DataTable();
//            da.Fill(dt);
//            this.dataGridView3.DataSource = dt;
//            conn.Close();
//        }
//    }
//}

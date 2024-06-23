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
    public partial class FormMostrar_eliminados : Form
    {
        private SQLiteConnection conn; 
        
        public FormMostrar_eliminados()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=Proyecto_python.db;Version=3;");
        }
        int contador; 
        private void butto_bucar_Click(object sender, EventArgs e)
        {
            
            this.dataGridView3.Refresh();
            contador++;
            panel_de_filtrar.Visible = true;
            if (contador == 2)
            {
                contador = 0;
                panel_de_filtrar.Visible = false;
            }
            conn.Open();

            if (check_todos.Checked == true)
            {
                check_bebidas.Checked = true;
                check_ingredientes.Checked = true;
                check_otros.Checked = true;
                check_concina.Checked = true;

                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0}", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND NOT C.Categoria = 'utiles de cocina'", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND NOT C.Categoria = 'otros'", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND NOT C.Categoria = 'ingredientes'", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND NOT C.Categoria = 'bebidas'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }

            // parejas
            // BO
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'bebidas'  OR C.Categoria = 'otros'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                   //IO
            else if (check_ingredientes.Checked == true && check_otros.Checked == true && check_bebidas.Checked == false && check_concina.Checked == false)
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'otros'  OR C.Categoria = 'ingredientes'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();
            }
            //BC
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'bebidas' OR C.Categoria = 'utiles de cocina' ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //BI
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == false)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'ingredientes' OR C.Categoria = 'bebidas'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       //IC
            else if (check_bebidas.Checked == false && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'ingredientes' OR C.Categoria = 'utiles de cocina'", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();


            }                                                                                                                                       // OC
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == true)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'otros' OR C.Categoria = 'utiles de cocina' ", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'bebidas' ", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'ingredientes' ", conn);

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
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'otros' ", conn);

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
                $"P.medida_1,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {0} AND C.Categoria = 'utiles de cocina' ", conn);

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
    }
}

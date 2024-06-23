using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace proyecto_chicha_deleali
{
    public partial class inicio : Form
    {

        private SQLiteConnection conn;
        public inicio()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
            conn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter($"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1}", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView3.DataSource = dt;
            dataGridView3.Invalidate();
            dataGridView3.Update();


            conn.Close();
        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void hora_Tick(object sender, EventArgs e)
        {
            label_hora_actual.Text = DateTime.Now.ToString("hh:mm:ss");
            label_fecha_actual.Text = DateTime.Now.ToLongDateString();
        }

        int contador = 0;

        private void boton_cargar_Click(object sender, EventArgs e)
        {
        

            contador++;
            panel_de_filtrar.Visible = true;
            if (contador == 2)
            {
                contador = 0;
                panel_de_filtrar.Visible = false;
            }
            conn.Open();

            if (check_todos.Checked == true || check_bebidas.Checked == true && check_concina.Checked == true && check_ingredientes.Checked == true && check_otros.Checked == true)
            {
                check_bebidas.Checked = true;
                check_ingredientes.Checked = true;
                check_otros.Checked = true;
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
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == false)
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
            else if (check_ingredientes.Checked == true && check_otros.Checked == true && check_bebidas.Checked == false && check_concina.Checked == false)
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
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked == true)
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
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == false)
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
            else if (check_bebidas.Checked == false && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == true)
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
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == true)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_reporte_Click(object sender, EventArgs e)
        {
           

            FormReporte formreporte = new FormReporte();
            formreporte.Show();
            //conn.Open();

            //string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} ";
            //using (SQLiteCommand command = new SQLiteCommand(query, conn))
            //{
            //    using (SQLiteDataReader reader = command.ExecuteReader())
            //    {
            //        string html = @"
            //        <html>
            //        <head>
            //            <title>Chicha Deliali - Reporte de Productos</title>
            //            <style>
            //                table {
            //                    border-collapse: collapse;
            //                    width: 100%;
            //                }
            //                th, td {
            //                    border: 1px solid #dddddd;
            //                    text-align: left;
            //                    padding: 8px;
            //                }
            //                th {
            //                    background-color: #f2f2f2;
            //                }
            //                button {
            //                    background-color: #008CBA;
            //                    color: white;
            //                    padding: 10px 20px;
            //                    border: none;
            //                    border-radius: 4px;
            //                    cursor: pointer;
            //                    float: right;
            //                    margin-top: 20px; /* Agregar margen arriba */
            //                    margin-right: 20px
            //                    margin-bottom: 20px

            //                }
            //                button:hover {
            //                    background-color: #005f7a;
            //                }
            //                .titulo-container {
            //                    display: flex;
            //                    align-items: center;
            //                    margin-bottom: 20px;
            //                }
            //                .titulo {
            //                    font-size: 24px;
            //                    font-weight: bold;
            //                    margin-right: 20px;
            //                }
            //                .subtitulo {
            //                    font-size: 18px;
            //                    font-style: italic;
            //                    margin-bottom: 20px;
            //                }
            //            </style>
            //        </head>
            //        <body>
            //            <div class='titulo-container'>
            //                <img src='logo.png' alt='Descripción de la imagen' width='50' height='50'>
            //                <div class='titulo'>Chicha Deliali</div>
            //            </div>
            //            <div class='subtitulo'>Reporte de productos existentes en el almacen</div>";

            //        // Tabla de productos
            //        html += @"
            //            <table>
            //                <tr>
            //                    <th>ID del Producto</th>
            //                    <th>Nombre del Producto</th>
            //                    <th>Cantidad del Producto</th>
            //                    <th>Medida 1</th>
            //                    <th>Conversion</th>
            //                    <th>Medida 2</th>
            //                    <th>Categoria</th>

            //                </tr>";

            //        // Generar filas de la tabla con datos de la base de datos
            //        while (reader.Read())
            //        {
            //            html += "<tr>";
            //            html += "<td>" + reader["ID_Productos"] + "</td>";
            //            html += "<td>" + reader["Nombre_Producto"] + "</td>";
            //            html += "<td>" + reader["Cantidad_Producto"] + "</td>";
            //            html += "<td>" + reader["Medida_1"] + "</td>";
            //            html += "<td>" + reader["Conver"] + "</td>";
            //            html += "<td>" + reader["Medida_2"] + "</td>";
            //            html += "<td>" + reader["Categoria"] + "</td>";
            //            html += "</tr>";
            //        }

            //        html += @"
            //            </table>
            //            <button onclick='window.print()'>Imprimir</button>
            //        </body>
            //        </html>";

            //        // Guardar HTML en un archivo
            //        string rutaArchivoHTML = "C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\valorant\\hooola.html";
            //        System.IO.File.WriteAllText(rutaArchivoHTML, html);

            //        // Abrir el archivo HTML en el navegador
            //        AbrirPaginaWeb(rutaArchivoHTML);
            //        conn.Close();
        }

        private void boton_menu_Click(object sender, EventArgs e)
        {
            FormMenu_comida formcomida = new FormMenu_comida();
            formcomida.Show();
        }

        private void boton_proveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formproveedores = new FormProveedores();
            formproveedores.Show();




        }
      

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void boton_ventas_Click(object sender, EventArgs e)
        {
            FormVentas formventas = new FormVentas();
            formventas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMeme formproveedores1 = new FormMeme();
            formproveedores1.Show();
        }
    }
}



    //    static void AbrirPaginaWeb(string x)
    //    {
    //        //string rutaArchivoHTML = "C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\valorant\\hooola.html"; // Reemplaza con la ruta de tu archivo HTML

    //        try
    //        {
    //            Process.Start(x);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error al abrir la página web: " + ex.Message);
    //        }


    //    }

    //    private void boton_menu_Click(object sender, EventArgs e)
    //    {
           

    //        FormMenu_comida formmenuC = new FormMenu_comida();
    //        formmenuC.Show();

    //    }
    //}


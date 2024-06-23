using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.html;

namespace proyecto_chicha_deleali
{
    public partial class FormReporte : Form
    {
        private SQLiteConnection conn;
        public FormReporte()
        {

            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void GenerarReportePDF(string nombreArchivo, string nombre, string documento)
        {


            if (ventas.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
                
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                 
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID de Venta</th>
                            <th>Nombre del Cliente</th>
                            <th>Cedula del Comprador</th>
                            <th>Monto Total</th>
                            <th>Fecha</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"SELECT V.ID_venta, C.Nombre_cliente,V.ID_clientes, V.monto_total, V.fecha from ventas V INNER JOIN clientes C on C.ID_clientes = V.ID_clientes"; 
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_venta"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_cliente"] + "</td>";
                            tableRows += "<td>" + reader["ID_clientes"] + "</td>";
                            tableRows += "<td>" + reader["monto_total"] + "</td>";
                            tableRows += "<td>" + reader["fecha"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }



            if (check_todos.Checked == true || check_bebidas.Checked == true && check_concina.Checked == true && check_ingredientes.Checked == true && check_otros.Checked == true)
            {
                check_bebidas.Checked = true;
                check_ingredientes.Checked = true;
                check_otros.Checked = true;
                check_concina.Checked = true;

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
              
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                    
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1}";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }




            }       //Trios                                                                                                                         BIO
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == true && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
               
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                    
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'utiles de cocina'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }



            }                                                                                                                                         //BIC
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
             
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                 
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'otros'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }                                                                                                                                       //BOC
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
           
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                   
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'ingredientes'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }                                                                                                                                       //IOC
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == true && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
               
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                  
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto,P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND NOT C.Categoria = 'bebidas'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }

            // parejas
            // BO
            else if (check_bebidas.Checked == true && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == false)
            {


                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
                
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                  
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas'  OR C.Categoria = 'otros'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

            }                                                                                                                                   //IO
            else if (check_ingredientes.Checked == true && check_otros.Checked == true && check_bebidas.Checked == false && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
              
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
          
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros'  OR C.Categoria = 'ingredientes'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }
            //BC
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
            
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                    
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas' OR C.Categoria = 'utiles de cocina' ";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }                                                                                                                                       //BI
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
                
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                 
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes' OR C.Categoria = 'bebidas'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }                                                                                                                                       //IC
            else if (check_bebidas.Checked == false && check_otros.Checked == false && check_ingredientes.Checked == true && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
             
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                 
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes' OR C.Categoria = 'utiles de cocina'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }                                                                                                                                       // OC
            else if (check_bebidas.Checked == false && check_otros.Checked == true && check_ingredientes.Checked == false && check_concina.Checked == true)
            {

                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
               
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                   
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias" +
                $" C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros' OR C.Categoria = 'utiles de cocina'";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }


            }



            //aqui para abajo son individuales                       B
            else if (check_bebidas.Checked == true && check_otros.Checked == false && check_ingredientes.Checked == false && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
             
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                  
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'bebidas'"; 
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

            }                                                                                                        //I
            else if (check_ingredientes.Checked == true && check_otros.Checked == false && check_bebidas.Checked == false && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
               
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                   
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'ingredientes'"; 
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

            }                                                                                                        //O
            else if (check_otros.Checked == true && check_ingredientes.Checked == false && check_bebidas.Checked == false && check_concina.Checked == false)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
                       
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                            <th>Conversion</th>
                            <th>Medida 2</th>
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,P.conver,P.medida_2,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'otros' "; 

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>";
                            tableRows += "<td>" + reader["Conver"] + "</td>";
                            tableRows += "<td>" + reader["Medida_2"] + "</td>";
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

            }                                                                                                                                          // C
            else if (check_otros.Checked == false && check_ingredientes.Checked == false && check_bebidas.Checked == false && check_concina.Checked == true)
            {
                string html = @"
<!DOCTYPE html>
<html>
<head>
    <title>Chicha Deliali - Reporte de Productos</title>
    <style>
        table.borde {
            border-collapse: collapse;
        }

        table.border th {
            padding: 5px;
            border: 1px solid black;
        }

        table.border td {
            padding: 5px;
            border: 1px solid black;
        }

        button {
            background-color: #008CBA;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            float: right;
            margin-top: 20px; /* Agregar margen arriba */
            margin-right: 20px;
            margin-bottom: 20px;
        }

        button:hover {
            background-color: #005f7a;
        }
    </style>
</head>
<body>
    <table border='0' style='width:100%'>
        <tr>
            <td style='width: 20%;' align='center'>
               
            </td>
            <td style='width: 60%;' align='center'>
                <table>
                    <tr><td align='center'>CHICHA DELIALI</td></tr>
                    <tr><td align='center'>Drieccion: Calle Ecuador</td></tr>
                    <tr><td align='center'>telefono 0414-6883691</td></tr>
                </table>
            </td>
            <td style='width: 20%;'>
                <table class='border' style='width: 100%;'>
                    <tr><td align='center'>Fecha: @Fecha</td></tr>
                    <tr><td align='center'>Tipo: Reporte</td></tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3' height='20'></td>
        </tr>
        <tr>
            <td colspan='2'>
                <table style='width: 100%;'>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Nombre:</td>
                        <td colspan='3' style='width: 80%; border-bottom: 1px solid black;'>@Nombre</td>
                    </tr>
                    <tr>
                        <td colspan='1' style='width: 20%;'>Documento:</td>
                        <td colspan='1' style='width: 30%; border-bottom: 1px solid black;'>@Documento</td>
                        <td colspan='1' style='width: 10%;'>Firma:</td>
                        <td colspan='1' style='width: 40%; border-bottom: 1px solid black;'></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan='3'>
                <table class='border' style='width: 100%;'>
                    <thead style='background-color: #d8d8d8;'>
                        <tr>
                            <th>ID del Producto</th>
                            <th>Nombre del Producto</th>
                            <th>Cantidad del Producto</th>
                            <th>Medida 1</th>
                           
                            <th>Categoria</th>
                        </tr>
                    </thead>
                    <tbody>
                        @html
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
    <button onclick='window.print()'>Imprimir</button>
</body>
</html>";

                // Replace variables in HTML
                html = html.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                //html = html.Replace("@Categoria", categoria);
                html = html.Replace("@Nombre", nombre);
                html = html.Replace("@Documento", documento);

                // Add table rows from database
                conn.Open();
                string query = $"select P.ID_Productos,P.Nombre_Producto,P.Cantidad_Producto," +
                $"P.medida_1,C.Categoria from productos P INNER JOIN Categorias C on C.ID_categorias = P.ID_categorias WHERE existe = {1} AND C.Categoria = 'utiles de cocina' "; 
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string tableRows = "";
                        while (reader.Read())
                        {
                            tableRows += "<tr>";
                            tableRows += "<td>" + reader["ID_Productos"] + "</td>";
                            tableRows += "<td>" + reader["Nombre_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Cantidad_Producto"] + "</td>";
                            tableRows += "<td>" + reader["Medida_1"] + "</td>"; 
                            tableRows += "<td>" + reader["Categoria"] + "</td>";
                            tableRows += "</tr>";
                        }
                        html = html.Replace("@html", tableRows);
                    }
                }
                conn.Close();

                // Generate PDF
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                }

            }

            
        }


        private void boton_generar_reporte_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string documento = "Documento"; // Aquí debes proporcionar el valor correcto del documento
            string categoria = "Categoria"; // Aquí debes proporcionar el valor correcto de la categoría

            if (nombre != "")
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = $"Reporte.pdf";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    GenerarReportePDF(guardar.FileName, nombre, documento);
                    MessageBox.Show("Reporte generado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre válido.");
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_cerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        int contador; 
        private void butto_flitrar_Click(object sender, EventArgs e)
        {
            contador++;
            panel_de_filtrar.Visible = true;
            if (contador == 2)
            {
                contador = 0;
                panel_de_filtrar.Visible = false;
            }
            conn.Open();
            if (ventas.Checked == true)
            {

                check_otros.Checked = false;
                check_ingredientes.Checked = false;
                check_bebidas.Checked = false;
                check_concina.Checked = false;


                SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT V.ID_venta, C.Nombre_cliente,V.ID_clientes, V.monto_total, V.fecha from ventas V INNER JOIN clientes C on C.ID_clientes = V.ID_clientes",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.Invalidate();
                dataGridView3.Update();
                conn.Close();



            }

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

        private void ventas_CheckedChanged(object sender, EventArgs e)
        {
            if (ventas.Checked == true)
            {
                check_todos.Checked = false; 
                check_otros.Checked = false;
                check_ingredientes.Checked = false;
                check_bebidas.Checked = false;
                check_concina.Checked = false; 
            }
        }
    }
}

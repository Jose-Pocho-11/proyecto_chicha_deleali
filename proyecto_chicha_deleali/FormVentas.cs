using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_chicha_deleali
{
    public partial class FormVentas : Form
    {
        private SQLiteConnection conn;
        public FormVentas()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=C:\\Users\\jose daniel moreno\\OneDrive\\Escritorio\\proyecto_chicha_deleali\\proyecto_chicha_deleali\\Proyecto_python.db;Version=3;");

            txt_Categorias.SelectedIndex = 0;
            combo_A.SelectedIndex = 0;
            combo_C.SelectedIndex = 0;
            combo_CH.SelectedIndex = 0;
            combo_E.SelectedIndex = 0;
            combo_PL.SelectedIndex = 0;
            combo_R.SelectedIndex = 0;
            combo_TC.SelectedIndex = 0;
            Combo_P.SelectedIndex = 0;
            Combo_G.SelectedIndex = 0;

        }





        /*int combo_A  = combo_A.SelectedIndex; 
          int combo_C  = combo_C.SelectedIndex; 
          int combo_CH = combo_CH.SelectedIndex; 
          int combo_E  = combo_E.SelectedIndex; 
          int combo_PL = combo_PL.SelectedIndex; 
          int combo_R  = combo_R.SelectedIndex; 
          int combo_TC = combo_TC.SelectedIndex; 
          int Combo_P  = Combo_P.SelectedIndex; 
          int Combo_G  = Combo_G.SelectedIndex;*/




        // SOLO VARIABLES                                                                  SOLO VARIABLES                                                               SOLO VARIABLES   




        // tabla Bebidas                                                                 Tabla chicha
        double cafe_conver, expresso_conver, agua_conver; double arroz_bd; double arroz_conver;
        double Expresso; double agua_bd; double agua_conver_chicha;
        double Agua; double leche_bd; double leche_conver;
        double cafe_bd; double leche_condensada_bd; double leche_condensada_conver;
        double ensencia_vainilla_bd; double esencia_vainilla_conver;
        double canela_bd; double canela_conver;










        //   tabla galletas                                                                       tabla galletas                                            tabla galletas
        double harina_bd; double harina_conver;
        double mantequilla_bd; double mantequilla_conver;
        double ensencia_vainilla_bd_galletas; double esencia_vainilla_conver_galletas;
        double azucar_bd; double azucar_conver;



        //              pie de limon                                                                pie de limon                                        pie de limon


        double harina_bd_PL; double harina_conver_PL;
        double mantequilla_bd_PL; double mantequilla_conver_PL;
        double ensencia_vainilla_bd_PL; double esencia_vainilla_conver_PL;
        double azucar_bd_PL; double azucar_conver_PL;
        int huevos_bd; double huevos_conver;
        int limon_bd; double limon_conver;
        double galleta_bd; double galleta_conver;




        // torta de chocolate                                                                      torta de chocolate                                        torta de chocolate




        double harina_bd_TCo; double harina_conver_TCo;
        double azucar_bd_TCo; double azucar_conver_TCo;
        double aceite_bd; double aceite_conver;
        int huevos_bd_TCo; int huevos_conver_TCo;
        int cacao_bd; int cacao_conver;

        //tabla topping

        double oreo_bd; double oreo_conver;
        double chispas_chocolate_bd; double chispas_chocolate_conver;
        double chispas_colores_bd; double chispas_colores_conver;
        double flips_bd; double flips_conver;













        private void boton_cancelar_ingreso_Click(object sender, EventArgs e)
        {

        }

        private void boton_Ingresar_producto_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Categorias.SelectedIndex == 3)
            {
                panel_Bebidas.Visible = true;
                panel_Postres.Visible = true;

                boton_ventas.Visible = true;
                boton_cancelar.Visible = true;



            }
            else if (txt_Categorias.SelectedIndex == 2)
            {
                panel_Bebidas.Visible = false;
                panel_Postres.Visible = true;
                boton_ventas.Visible = true;
                boton_cancelar.Visible = true;
            }
            else if (txt_Categorias.SelectedIndex == 1)
            {
                panel_Bebidas.Visible = true;
                panel_Postres.Visible = false;
                boton_ventas.Visible = true;
                boton_cancelar.Visible = true;
            }
        }

        string nombre_comprador, cedula_comprador;
        double precio_total;


        List<double> cantidadesProductos = new List<double> {0,0,0,0,0,0,0,0,0 };
        private void boton_ventas_Click(object sender, EventArgs e)
        {


            nombre_comprador = txt_nombre_Comprador.Text;
            cedula_comprador = txt_cedula.Text;
            
            if (nombre_comprador != "" && cedula_comprador != "")
            {


                if (C.Checked == true)
                {
                    precio_total = combo_C.SelectedIndex * 1.5;

                   


                    conn.Open();

                    string consultaProductos = $"SELECT conver FROM Productos WHERE ID_Productos IN (54)";
                   

                    using (SQLiteCommand cmd2 = new SQLiteCommand(consultaProductos, conn))
                    {
                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["conver"] != DBNull.Value)
                                {
                                    //double cantidad = Convert.ToDouble(reader["conver"]);
                                    cantidadesProductos[0] = Convert.ToDouble(reader["conver"]);
                                    //cantidadesProductos.Add(cantidad);
                                }
                            }
                        }
                    }

                    double cantidadA = 150 * combo_C.SelectedIndex;


                    // Restar las cantidades utilizadas
                    cantidadesProductos[0] -= cantidadA;

                    // Verificar si hay suficiente cantidad antes de actualizar


                    //pdiamos meter un if 
                  





                        bool actualizar = true;

                        if (cantidadesProductos[0] < 0)
                        {
                            actualizar = false;
                            MessageBox.Show("No hay suficiente cantidad en la tabla de productos para completar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                        if (actualizar)
                        {
                            // Actualizar la tabla 'Productos' con las nuevas cantidades convertidas a kilogramos
                            string updateQuery = "UPDATE Productos SET conver = @nuevaCantidad WHERE ID_Productos = @idProducto";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                // Actualizar cantidad del cafe
                                updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[0]);
                                updateCmd.Parameters.AddWithValue("@idProducto", 54);
                                updateCmd.ExecuteNonQuery();


                            }
                            // Convertir las cantidades a Litro
                            cantidadesProductos[0] /= 1000;


                            // Actualizar la tabla 'Productos' con las cantidades en kilogramos
                            string updateQueryKg = "UPDATE Productos SET Cantidad_Producto = @nuevaCantidad WHERE ID_Productos = @idProducto";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQueryKg, conn))
                            {
                                // Actualizar cantidad del producto 54
                                updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[0]);
                                updateCmd.Parameters.AddWithValue("@idProducto", 54);
                                updateCmd.ExecuteNonQuery();


                            }

                          //  MessageBox.Show("Venta realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }



                        conn.Close();





                    
                }

                if (A.Checked == true)
                {
                    precio_total += combo_A.SelectedIndex * 1;



                    conn.Open();

                    string consultaProductos2 = $"SELECT conver FROM Productos WHERE ID_Productos IN (56)";


                    using (SQLiteCommand cmd2 = new SQLiteCommand(consultaProductos2, conn))
                    {
                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["conver"] != DBNull.Value)
                                {
                                    //double cantidad = Convert.ToDouble(reader["conver"]);
                                    cantidadesProductos[2] = Convert.ToDouble(reader["conver"]);
                                    //cantidadesProductos.Add(cantidad);
                                }
                            }
                        }
                    }

                    double cantidadB = 150 * combo_A.SelectedIndex;


                    // Restar las cantidades utilizadas
                    cantidadesProductos[2] -= cantidadB;

                    // Verificar si hay suficiente cantidad antes de actualizar


                    //pdiamos meter un if 
                 





                        bool actualizar = true;

                        if (cantidadesProductos[2] < 0)
                        {
                            actualizar = false;
                            MessageBox.Show("No hay suficiente cantidad en la tabla de productos para completar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                        if (actualizar)
                        {
                            // Actualizar la tabla 'Productos' con las nuevas cantidades convertidas a kilogramos
                            string updateQuery = "UPDATE Productos SET conver = @nuevaCantidad WHERE ID_Productos = @idProducto";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                // Actualizar cantidad del cafe
                                updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[1]);
                                updateCmd.Parameters.AddWithValue("@idProducto", 56);
                                updateCmd.ExecuteNonQuery();


                            }
                            // Convertir las cantidades a Litro
                            cantidadesProductos[2] /= 1000;


                            // Actualizar la tabla 'Productos' con las cantidades en kilogramos
                            string updateQueryKg = "UPDATE Productos SET Cantidad_Producto = @nuevaCantidad WHERE ID_Productos = @idProducto";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQueryKg, conn))
                            {
                                // Actualizar cantidad del producto 54
                                updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[1]);
                                updateCmd.Parameters.AddWithValue("@idProducto", 56);
                                updateCmd.ExecuteNonQuery();


                            }

                            //MessageBox.Show("Venta realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }



                        conn.Close();
                    
                }


                if (Ch.Checked == true)
                {


                    precio_total += combo_CH.SelectedIndex * 1;

                    //agg los topin 
                    if (ChC.Checked || ChCo.Checked || TO.Checked || TF.Checked)
                    {
                        precio_total += 0.50;
                    }



                    conn.Open();

                    string consultaProductos2 = $"SELECT conver FROM Productos WHERE ID_Productos IN (62,56,63,64,66,67)";


                    using (SQLiteCommand cmd2 = new SQLiteCommand(consultaProductos2, conn))
                    {
                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            int i = 3;
                            while (reader.Read())
                            {
                                if (reader["conver"] != DBNull.Value)
                                {
                                    //double cantidad = Convert.ToDouble(reader["conver"]);
                                    cantidadesProductos[i] = Convert.ToDouble(reader["conver"]);
                                    i++; 
                                    //cantidadesProductos.Add(cantidad);
                                }
                            }
                        }
                    }

                    double cantidadE = 250.0 * combo_CH.SelectedIndex;
                    double cantidadF = 250.0 * combo_CH.SelectedIndex;
                    double cantidadG = 500.0 * combo_CH.SelectedIndex;
                    double cantidadH = 200.0 * combo_CH.SelectedIndex;
                    double cantidadI = 10.0 * combo_CH.SelectedIndex;
                    double cantidadJ = 10.0 * combo_CH.SelectedIndex;


                    // Restar las cantidades utilizadas
                    cantidadesProductos[3] -= cantidadE;
                    cantidadesProductos[4] -= cantidadF;
                    cantidadesProductos[5] -= cantidadG;
                    cantidadesProductos[6] -= cantidadH;
                    cantidadesProductos[7] -= cantidadI;
                    cantidadesProductos[8] -= cantidadJ;

                    // Verificar si hay suficiente cantidad antes de actualizar


                    //pdiamos meter un if 






                    bool actualizar = true;

                    if (cantidadesProductos[3] < 0 && cantidadesProductos[4]<0 && cantidadesProductos[5]<0 && cantidadesProductos[6]<0 && cantidadesProductos[7] < 0 &&  cantidadesProductos[8]<0)
                    {
                        actualizar = false;
                        MessageBox.Show("No hay suficiente cantidad en la tabla de productos para completar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    if (actualizar)
                    {
                        // Actualizar la tabla 'Productos' con las nuevas cantidades convertidas a kilogramos
                        string updateQuery = "UPDATE Productos SET conver = @nuevaCantidad WHERE ID_Productos = @idProducto";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                        {
                            // Actualizar cantidad del chicha
                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[3]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 62);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[4]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 56);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[5]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 63);
                            updateCmd.ExecuteNonQuery();


                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[6]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 64);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[7]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 66);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[8]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 67);
                            updateCmd.ExecuteNonQuery();


                        }
                        // Convertir las cantidades a Litro
                        //cantidadesProductos[1] /= 1000;
                        cantidadesProductos[3] /= 1000;
                        cantidadesProductos[4] /= 1000;
                        cantidadesProductos[5] /= 1000;
                        cantidadesProductos[6] /= 1000;
                        cantidadesProductos[7] /= 1000;
                        cantidadesProductos[8] /= 1000;


                        // Actualizar la tabla 'Productos' con las cantidades en kilogramos
                        string updateQueryKg = "UPDATE Productos SET Cantidad_Producto = @nuevaCantidad WHERE ID_Productos = @idProducto";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQueryKg, conn))
                        {
                            // Actualizar cantidad del producto  chicha 
                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[3]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 62);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[4]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 56);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[5]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 63);
                            updateCmd.ExecuteNonQuery();


                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[6]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 64);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[7]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 66);
                            updateCmd.ExecuteNonQuery();

                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[8]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 67);
                            updateCmd.ExecuteNonQuery();


                        }
                     //   MessageBox.Show($"********** Detalles del Pedido **********\n\n" +
                     //$"Comprador: {nombre_comprador}\n" +
                     //$"Cédula: {cedula_comprador}\n" +
                     //$"Pedido: {txt_Categorias.SelectedItem.ToString()}\n" +
                     //$"Precio Total: {precio_total}$\n\n" +
                     //$"***************************************", "Resumen de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     //   MessageBox.Show("Venta realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                    conn.Close();












                }


               

                if (E.Checked == true)
                {
                    precio_total += combo_E.SelectedIndex * 1.5;


                    conn.Open();

                    string consultaProductos2 = $"SELECT conver FROM Productos WHERE ID_Productos IN (55)";


                    using (SQLiteCommand cmd2 = new SQLiteCommand(consultaProductos2, conn))
                    {
                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["conver"] != DBNull.Value)
                                {
                                    //double cantidad = Convert.ToDouble(reader["conver"]);
                                    cantidadesProductos[1] = Convert.ToDouble(reader["conver"]);
                                    //cantidadesProductos.Add(cantidad);
                                }
                            }
                        }
                    }

                    double cantidadC = 250 * combo_E.SelectedIndex;


                    // Restar las cantidades utilizadas
                    cantidadesProductos[1] -= cantidadC;

                    // Verificar si hay suficiente cantidad antes de actualizar


                    //pdiamos meter un if 






                    bool actualizar = true;

                    if (cantidadesProductos[1] < 0)
                    {
                        actualizar = false;
                        MessageBox.Show("No hay suficiente cantidad en la tabla de productos para completar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    if (actualizar)
                    {
                        // Actualizar la tabla 'Productos' con las nuevas cantidades convertidas a kilogramos
                        string updateQuery = "UPDATE Productos SET conver = @nuevaCantidad WHERE ID_Productos = @idProducto";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                        {
                            // Actualizar cantidad del cafe
                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[1]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 55);
                            updateCmd.ExecuteNonQuery();


                        }
                        // Convertir las cantidades a Litro
                        cantidadesProductos[1] /= 1000;


                        // Actualizar la tabla 'Productos' con las cantidades en kilogramos
                        string updateQueryKg = "UPDATE Productos SET Cantidad_Producto = @nuevaCantidad WHERE ID_Productos = @idProducto";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQueryKg, conn))
                        {
                            // Actualizar cantidad del producto 54
                            updateCmd.Parameters.AddWithValue("@nuevaCantidad", cantidadesProductos[1]);
                            updateCmd.Parameters.AddWithValue("@idProducto", 55);
                            updateCmd.ExecuteNonQuery();


                        }

                        //MessageBox.Show("Venta realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                    conn.Close();






                }











                MessageBox.Show($"********** Detalles del Pedido **********\n\n" +
                      $"Comprador: {nombre_comprador}\n" +
                      $"Cédula: {cedula_comprador}\n" +
                      $"Pedido: {txt_Categorias.SelectedItem.ToString()}\n" +
                      $"Precio Total: {precio_total}$\n\n" +
                      $"***************************************", "Resumen de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      MessageBox.Show("Venta realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // para guardar al clinete 









                try
                    {
                        conn.Open();
                        string consulta = "INSERT into clientes(ID_clientes, Nombre_cliente) VALUES (@ID_clientes, @Nombre_cliente)";

                        using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre_cliente", nombre_comprador);
                            cmd.Parameters.AddWithValue("@ID_clientes", cedula_comprador);




                            int filasInsertadas = cmd.ExecuteNonQuery();

                            if (filasInsertadas > 0)
                            {
                                MessageBox.Show("Se ha registrado el cliente con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el producto en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }


                    //para guardar la venta 
                    try
                    {
                        conn.Open();
                        string consulta = "INSERT into ventas (ID_clientes, monto_total, fecha) VALUES (@ID_clientes, @monto_total, @fecha)";

                        using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                        {

                            cmd.Parameters.AddWithValue("@ID_clientes", cedula_comprador);
                            cmd.Parameters.AddWithValue("@monto_total", precio_total);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));




                            int filasInsertadas = cmd.ExecuteNonQuery();

                            if (filasInsertadas > 0)
                            {
                                MessageBox.Show("Se ha registrado la venta con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("No se insertaron filas. Es posible que haya ocurrido un problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el producto en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }






                




















            }
            else
            {
                MessageBox.Show("No rellenó todas las casillas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







            conn.Close();






        }
    








        

        private void boton_cancelar_ingreso_Click_1(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            txt_nombre_Comprador.Clear();
            txt_cedula.Clear();
            txt_Categorias.SelectedIndex= 0;
            panel_Bebidas.Visible=false;
            panel_Postres.Visible=false;
            panel_topping.Visible=false;
            boton_cancelar.Visible=false;
            boton_ventas.Visible=false;

            checkBox1.Checked=false;
            checkBox2.Checked=false;
            checkBox3.Checked=false;
            P.Checked=false;
            
            A.Checked=false;
            C.Checked=false;
            Ch.Checked=false;
            E.Checked=false;
            R.Checked=false;

            ChC.Checked=false;
            ChCo.Checked=false;
            TO.Checked=false;
            TF.Checked=false;



        
            combo_A.SelectedIndex=0;
            combo_C.SelectedIndex=0;
            combo_CH.SelectedIndex=0;
            combo_E.SelectedIndex=0;
            combo_R.SelectedIndex=0;

            combo_TC.SelectedIndex = 0;
            combo_PL.SelectedIndex=0;
            Combo_G.SelectedIndex=0;
            Combo_P.SelectedIndex=0;
        }
        int contador; 
        private void Ch_CheckedChanged(object sender, EventArgs e)
        {
            contador++;

            if (contador==1)
            {
                combo_CH.Visible = true; 
                if (Ch.Checked == true)
                {
                 panel_topping.Visible = true;
                }
            }
            else
            {
                combo_CH.Visible=false;
                C.Checked = false;
               panel_topping.Visible=false;
                contador = 0; 
            }

        }
           
           

        private void ChC_CheckedChanged(object sender, EventArgs e)
        {
            ChCo.Checked = false; 
            TF.Checked = false;
            TO.Checked = false;


        }

        private void ChCo_CheckedChanged(object sender, EventArgs e)
        {
            ChC.Checked = false;
            TF.Checked = false;
            TO.Checked = false;


        }

        private void list_C_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            contadorC++;
            if (contadorC == 1)
            {
                combo_C.Visible = true;
            }
            else
            {
                contadorC = 0;
                combo_C.Visible = false;
            }



        }

        private void E_CheckedChanged(object sender, EventArgs e)
        {
       
            contadorE++;
            if (contadorE == 1)
            {
                combo_E.Visible = true;
            }
            else
            {
                contadorE = 0;
                combo_E.Visible = false;
            }
        }

        private void A_CheckedChanged(object sender, EventArgs e)
        {
           

            contadorA++;
            if (contadorA == 1)
            {
                combo_A.Visible = true;
            }
            else
            {
                contadorA = 0;
                combo_A.Visible = false;
            }
        }

        private void R_CheckedChanged(object sender, EventArgs e)
        {
            combo_R.Visible = false;
            MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            combo_R.Visible = false;
            //contadorR++;
            //if (contadorR == 1)
            //{
            //    combo_R.Visible = true;
            //}
            //else
            //{
            //    contadorR = 0;
            //    combo_R.Visible = false;
            //}
        }

        private void P_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //contadorP++;
            //if (contadorP == 1)
            //{
            //    Combo_P.Visible = true;
            //}
            //else
            //{
            //    contadorP = 0;
            //    Combo_P.Visible = false;
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //contadorG++;
            //if (contadorG == 1)
            //{
            //    Combo_G.Visible = true;
            //}
            //else
            //{
            //    contadorG = 0;
            //    Combo_G.Visible = false;
            //}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //contadorTC++;
            //if (contadorTC == 1)
            //{
            //    combo_TC.Visible = true;
            //}
            //else
            //{
            //    contadorTC = 0;
            //    combo_TC.Visible = false;
            //}
        }
        int contadorC = 0;
        int contadorE = 0;
        int contadorA = 0;
        int contadorR = 0;
        int contadorP = 0;
        int contadorG = 0;
        int contadorTC = 0;
        int contadorPL = 0;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción no está disponible actualmente. ¡Próximamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //contadorPL++;
            //if (contadorPL == 1)
            //{
            //    combo_PL.Visible = true;
            //}
            //else
            //{
            //    contadorPL = 0;
            //    combo_PL.Visible = false;
            //}
        }

        private void TO_CheckedChanged(object sender, EventArgs e)
        {
            ChCo.Checked = false;
            TF.Checked = false;
            ChC.Checked = false;
        }

        private void TF_CheckedChanged(object sender, EventArgs e)
        {
        
            ChCo.Checked = false;
            ChC.Checked = false;
            TO.Checked = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

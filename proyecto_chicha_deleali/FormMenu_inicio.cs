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


namespace proyecto_chicha_deleali
{
    public partial class FormMenu_inicio : Form
    {
        private SQLiteConnection conn;
        public FormMenu_inicio()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=Proyecto_python.db;Version=3;");
            conn.Open();
            abrir_panel(new inicio());
        }

        private void boton_cerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
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

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FormMenu_inicio_Load(object sender, EventArgs e)
        {

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_configuracion_Click(object sender, EventArgs e)
        {
                
            
        }

        private void subMenu_configuracion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_cambiarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_MostrarEliminados_Click(object sender, EventArgs e)
        {
                
        }

        private void boton_CambiarContraseña_Click(object sender, EventArgs e)
        {
            
        }

        private void bonton_Ingresar_Click(object sender, EventArgs e)
        {
      
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_ocultar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void boton_actualizarNombreProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_actualizar_CantidadProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void boton_ocultar_actulizar_Click(object sender, EventArgs e)
        {
            
        }
  

        public void abrir_panel(object formpanel)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
                Form fh = formpanel as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(fh);
                this.panelPrincipal.Tag = fh;
                fh.Show();
            }
        }



       

        private void boton_cargar_datos_Click(object sender, EventArgs e)
        {
            //SQLiteDataAdapter da = new SQLiteDataAdapter("select * from productos",conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            abrir_panel(new inicio()) ;
            abrir_panel(new FormIngresar_mas_producto());
        
        }

        

        private void boton_ingresar_do_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_nuevo_producto_sub_menu_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void boton_Ingresar_Productos_al_Invetario_Click(object sender, EventArgs e)
        {
            
            abrir_panel(new FormIngresar_mas_producto());

        }

        private void boton_recuperar_productos_eliminados_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_ocultar_sub_menu_ingresar_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Ingresar_Productos_Click(object sender, EventArgs e)
        {
            

            abrir_panel(new FormNuevo_producto());
            
        }

        private void boton_actualizarNombreProducto2_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_actualizar_CantidadProducto2_Click(object sender, EventArgs e)
        {
        }

        private void boton_ocultar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void boton_actualizar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void boton_configuracion2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void boton_cambiar_usuario_Click(object sender, EventArgs e)
        {
            
            
        }

        private void boton_cambiar_contraseña_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_recuperar_datos_de_configuracion_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_mostrar_productos_eliminados_de_configuracion_Click(object sender, EventArgs e)
        {
            
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrir_panel(new FormNuevo_producto());
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            //string usuario1, contra;
            //usuario1 = "juancho";
            //contra = "123"; 

            //string consulta;
            //consulta = "insert into productos (usuario, contraseña) values ('" + usuario1 + "', '" + contra + "')";
            //SQLiteCommand cmd = new SQLiteCommand(consulta, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close(); // Cierra la conexión aquí

            MessageBox.Show("Se han registrado con éxito");

            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
           
        }

        private void boton_cambiar_nombre_producto_Click(object sender, EventArgs e)
        {
           
          
        }

        private void cambiar_cantidad_producto_Click(object sender, EventArgs e)
        {
            
        }

        private void ocultar22_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_configuracion22_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            abrir_panel(new FormNuevo_producto());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            abrir_panel(new inicio());
        }

        private void boton_ingresar_new_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Boton_nuevo_producto_new_Click(object sender, EventArgs e)
        {
          

            abrir_panel(new FormNuevo_producto());
        }

        private void boton_ingresar_mas_cantidad_producto_new_Click(object sender, EventArgs e)
        {
            
            abrir_panel(new FormIngresar_mas_producto());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            abrir_panel(new inicio());
            //abrir_panel(new FormIngresar_mas_producto());
        }
        int contador; 
        private void boton_ingresar_new_Click_1(object sender, EventArgs e)
        {
            contador++;
            submenu_new_ingresar.Visible = true;
            sub_menu_de_actualizacion.Visible = false;
            panel_de_configuracion.Visible = false; 

            if (contador==2)
            {
                contador = 0;
                submenu_new_ingresar.Visible = false;
            }
            
        }

        private void boton_Nuevo_Producto_new_Click_1(object sender, EventArgs e)
        {
            abrir_panel(new FormNuevo_producto());
            submenu_new_ingresar.Visible = false;
            
        }

        private void boton_Ingresar_Producto_inventario_Click(object sender, EventArgs e)
        {
            submenu_new_ingresar.Visible = false;
            abrir_panel(new FormIngresar_mas_producto());
        }

        private void boton_Extraer_Producto_inventario_New_Click(object sender, EventArgs e)
        {
            submenu_new_ingresar.Visible = false;
            abrir_panel(new FormExtraerCantidad()); 
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            submenu_new_ingresar.Visible = false;
            abrir_panel(new FormRecuperar());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            submenu_new_ingresar.Visible = false;
        }

        private void boton_Actualizar_nombre_Producto_Click(object sender, EventArgs e)
        {
            sub_menu_de_actualizacion.Visible = false;
            abrir_panel(new FormActualizar_nombre());
        }

        private void boton_actualizar_la_cantidad_Click(object sender, EventArgs e)
        {
            sub_menu_de_actualizacion.Visible = false;
            abrir_panel(new FormActualizando_cantidad()); 
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            sub_menu_de_actualizacion.Visible = false;
        }

        private void boton_Actualizar_New_Click(object sender, EventArgs e)
        {
            sub_menu_de_actualizacion.Visible = true;
        }

        private void botondeActualizar_Click(object sender, EventArgs e)
        {
            contador++;
            sub_menu_de_actualizacion.Visible = true;
            submenu_new_ingresar.Visible=false;
            panel_de_configuracion.Visible=false;

            if (contador == 2)
            {
                contador = 0;
                sub_menu_de_actualizacion.Visible=false;
            }
           
            
        }

        private void button_cambiar_usuario_Click(object sender, EventArgs e)
        {
            panel_de_configuracion.Visible = false;
            abrir_panel(new FormCambiar_Usuario());
        }

        private void button_cambiar_contra_Click(object sender, EventArgs e)
        {
            panel_de_configuracion.Visible = false;
            abrir_panel(new FormCambiar_Contraseña());
        }

        private void button_mostrareliminados_Click(object sender, EventArgs e)
        {
            panel_de_configuracion.Visible = false;
            abrir_panel(new FormMostrar_eliminados());
        }

        private void button2_Click_5(object sender, EventArgs e)
        {
            panel_de_configuracion.Visible = false;
        }

        private void button_Configuracion_Click(object sender, EventArgs e)
        {
            panel_de_configuracion.Visible = true;
        }

        private void button_configurate_Click(object sender, EventArgs e)
        {
            contador++;
            panel_de_configuracion.Visible = true;
            submenu_new_ingresar.Visible = false;
            sub_menu_de_actualizacion.Visible = false; 
            if (contador == 2)
            {
                contador = 0;
                panel_de_configuracion.Visible = false; 
            }
            
        }

        private void button4_Click_3(object sender, EventArgs e)
        {

            abrir_panel(new FormNuevo_producto());
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_eliminar_1_Click(object sender, EventArgs e)
        {
            submenu_new_ingresar.Visible= false;
            sub_menu_de_actualizacion.Visible= false;
            panel_de_configuracion.Visible = false; 
            abrir_panel(new FormEliminar_Producto()); 
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            this.Hide();
            formlogin.Show();
        }
    }



}

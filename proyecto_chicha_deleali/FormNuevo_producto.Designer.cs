namespace proyecto_chicha_deleali
{
    partial class FormNuevo_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_titulo_ingresar_producto = new System.Windows.Forms.Label();
            this.boton_Ingresar_producto = new System.Windows.Forms.Button();
            this.boton_cancelar_ingreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_nuevoProducto = new System.Windows.Forms.TextBox();
            this.txt_cantidad_nuevoProducto = new System.Windows.Forms.TextBox();
            this.lista_de_Opciones_de_Medida = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Categorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titulo_ingresar_producto
            // 
            this.label_titulo_ingresar_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_titulo_ingresar_producto.AutoSize = true;
            this.label_titulo_ingresar_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_ingresar_producto.Location = new System.Drawing.Point(254, 41);
            this.label_titulo_ingresar_producto.Name = "label_titulo_ingresar_producto";
            this.label_titulo_ingresar_producto.Size = new System.Drawing.Size(390, 27);
            this.label_titulo_ingresar_producto.TabIndex = 0;
            this.label_titulo_ingresar_producto.Text = "Ingresando Un nuevo Producto";
            // 
            // boton_Ingresar_producto
            // 
            this.boton_Ingresar_producto.BackColor = System.Drawing.Color.Maroon;
            this.boton_Ingresar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_Ingresar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Ingresar_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Ingresar_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_Ingresar_producto.Location = new System.Drawing.Point(193, 358);
            this.boton_Ingresar_producto.Name = "boton_Ingresar_producto";
            this.boton_Ingresar_producto.Size = new System.Drawing.Size(158, 39);
            this.boton_Ingresar_producto.TabIndex = 1;
            this.boton_Ingresar_producto.Text = "Ingresar";
            this.boton_Ingresar_producto.UseVisualStyleBackColor = false;
            this.boton_Ingresar_producto.Click += new System.EventHandler(this.boton_Ingresar_producto_Click);
            // 
            // boton_cancelar_ingreso
            // 
            this.boton_cancelar_ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cancelar_ingreso.BackColor = System.Drawing.Color.Maroon;
            this.boton_cancelar_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cancelar_ingreso.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cancelar_ingreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_cancelar_ingreso.Location = new System.Drawing.Point(557, 357);
            this.boton_cancelar_ingreso.Name = "boton_cancelar_ingreso";
            this.boton_cancelar_ingreso.Size = new System.Drawing.Size(157, 40);
            this.boton_cancelar_ingreso.TabIndex = 2;
            this.boton_cancelar_ingreso.Text = "Cancelar";
            this.boton_cancelar_ingreso.UseVisualStyleBackColor = false;
            this.boton_cancelar_ingreso.Click += new System.EventHandler(this.boton_cancelar_ingreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // txt_nombre_nuevoProducto
            // 
            this.txt_nombre_nuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre_nuevoProducto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_nuevoProducto.Location = new System.Drawing.Point(193, 120);
            this.txt_nombre_nuevoProducto.Multiline = true;
            this.txt_nombre_nuevoProducto.Name = "txt_nombre_nuevoProducto";
            this.txt_nombre_nuevoProducto.Size = new System.Drawing.Size(549, 34);
            this.txt_nombre_nuevoProducto.TabIndex = 7;
            // 
            // txt_cantidad_nuevoProducto
            // 
            this.txt_cantidad_nuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad_nuevoProducto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_nuevoProducto.Location = new System.Drawing.Point(193, 190);
            this.txt_cantidad_nuevoProducto.Multiline = true;
            this.txt_cantidad_nuevoProducto.Name = "txt_cantidad_nuevoProducto";
            this.txt_cantidad_nuevoProducto.Size = new System.Drawing.Size(549, 34);
            this.txt_cantidad_nuevoProducto.TabIndex = 8;
            // 
            // lista_de_Opciones_de_Medida
            // 
            this.lista_de_Opciones_de_Medida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_de_Opciones_de_Medida.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_de_Opciones_de_Medida.FormattingEnabled = true;
            this.lista_de_Opciones_de_Medida.Items.AddRange(new object[] {
            "Elige una medida",
            "Unica",
            "Kilo",
            "Gramo",
            "Litro",
            "Mililitro"});
            this.lista_de_Opciones_de_Medida.Location = new System.Drawing.Point(259, 307);
            this.lista_de_Opciones_de_Medida.Name = "lista_de_Opciones_de_Medida";
            this.lista_de_Opciones_de_Medida.Size = new System.Drawing.Size(483, 35);
            this.lista_de_Opciones_de_Medida.TabIndex = 10;
            this.lista_de_Opciones_de_Medida.SelectedIndexChanged += new System.EventHandler(this.lista_de_Opciones_de_Medida_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(193, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(521, 221);
            this.dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(55, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 70);
            this.button2.TabIndex = 13;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categoria";
            // 
            // txt_Categorias
            // 
            this.txt_Categorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Categorias.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Categorias.FormattingEnabled = true;
            this.txt_Categorias.Items.AddRange(new object[] {
            "Elige una medida",
            "bebidas",
            "ingredientes",
            "utiles de cocina",
            "otros"});
            this.txt_Categorias.Location = new System.Drawing.Point(193, 255);
            this.txt_Categorias.Name = "txt_Categorias";
            this.txt_Categorias.Size = new System.Drawing.Size(549, 35);
            this.txt_Categorias.TabIndex = 16;
            this.txt_Categorias.SelectedIndexChanged += new System.EventHandler(this.txt_Categorias_SelectedIndexChanged);
            // 
            // FormNuevo_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 650);
            this.Controls.Add(this.txt_Categorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boton_cancelar_ingreso);
            this.Controls.Add(this.boton_Ingresar_producto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lista_de_Opciones_de_Medida);
            this.Controls.Add(this.txt_cantidad_nuevoProducto);
            this.Controls.Add(this.txt_nombre_nuevoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_titulo_ingresar_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevo_producto";
            this.Text = "Ingresando Nuevo Producto";
            this.Load += new System.EventHandler(this.FormNuevo_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo_ingresar_producto;
        private System.Windows.Forms.Button boton_Ingresar_producto;
        private System.Windows.Forms.Button boton_cancelar_ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_nuevoProducto;
        private System.Windows.Forms.TextBox txt_cantidad_nuevoProducto;
        private System.Windows.Forms.ComboBox lista_de_Opciones_de_Medida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_Categorias;
    }
}
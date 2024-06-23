namespace proyecto_chicha_deleali
{
    partial class FormIngresar_mas_producto
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
            this.boton_buscar_id = new System.Windows.Forms.Button();
            this.txt_buscar_id = new System.Windows.Forms.TextBox();
            this.poner_id = new System.Windows.Forms.Label();
            this.label_titulo_mas_producto = new System.Windows.Forms.Label();
            this.lista_de_Opciones_de_Medida = new System.Windows.Forms.ComboBox();
            this.boton_cancelar_ingreso = new System.Windows.Forms.Button();
            this.boton_mas_producto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad_nuevoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butto_bucar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_buscar_id
            // 
            this.boton_buscar_id.BackColor = System.Drawing.Color.Maroon;
            this.boton_buscar_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_buscar_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.boton_buscar_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_buscar_id.Location = new System.Drawing.Point(230, 110);
            this.boton_buscar_id.Name = "boton_buscar_id";
            this.boton_buscar_id.Size = new System.Drawing.Size(160, 42);
            this.boton_buscar_id.TabIndex = 48;
            this.boton_buscar_id.Text = "Buscar";
            this.boton_buscar_id.UseVisualStyleBackColor = false;
            this.boton_buscar_id.Click += new System.EventHandler(this.boton_buscar_id_Click);
            // 
            // txt_buscar_id
            // 
            this.txt_buscar_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_buscar_id.Location = new System.Drawing.Point(230, 68);
            this.txt_buscar_id.Multiline = true;
            this.txt_buscar_id.Name = "txt_buscar_id";
            this.txt_buscar_id.Size = new System.Drawing.Size(547, 34);
            this.txt_buscar_id.TabIndex = 49;
            // 
            // poner_id
            // 
            this.poner_id.AutoSize = true;
            this.poner_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.poner_id.Location = new System.Drawing.Point(81, 75);
            this.poner_id.Name = "poner_id";
            this.poner_id.Size = new System.Drawing.Size(143, 27);
            this.poner_id.TabIndex = 50;
            this.poner_id.Text = "Colocar ID";
            // 
            // label_titulo_mas_producto
            // 
            this.label_titulo_mas_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_titulo_mas_producto.AutoSize = true;
            this.label_titulo_mas_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_mas_producto.Location = new System.Drawing.Point(355, 20);
            this.label_titulo_mas_producto.Name = "label_titulo_mas_producto";
            this.label_titulo_mas_producto.Size = new System.Drawing.Size(317, 27);
            this.label_titulo_mas_producto.TabIndex = 51;
            this.label_titulo_mas_producto.Text = "Añadiendo más Producto";
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
            this.lista_de_Opciones_de_Medida.Location = new System.Drawing.Point(230, 239);
            this.lista_de_Opciones_de_Medida.Name = "lista_de_Opciones_de_Medida";
            this.lista_de_Opciones_de_Medida.Size = new System.Drawing.Size(602, 35);
            this.lista_de_Opciones_de_Medida.TabIndex = 52;
            this.lista_de_Opciones_de_Medida.SelectedIndexChanged += new System.EventHandler(this.lista_de_Opciones_de_Medida_SelectedIndexChanged);
            // 
            // boton_cancelar_ingreso
            // 
            this.boton_cancelar_ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cancelar_ingreso.BackColor = System.Drawing.Color.Maroon;
            this.boton_cancelar_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cancelar_ingreso.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cancelar_ingreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_cancelar_ingreso.Location = new System.Drawing.Point(672, 296);
            this.boton_cancelar_ingreso.Name = "boton_cancelar_ingreso";
            this.boton_cancelar_ingreso.Size = new System.Drawing.Size(160, 41);
            this.boton_cancelar_ingreso.TabIndex = 53;
            this.boton_cancelar_ingreso.Text = "Cancelar";
            this.boton_cancelar_ingreso.UseVisualStyleBackColor = false;
            this.boton_cancelar_ingreso.Click += new System.EventHandler(this.boton_cancelar_ingreso_Click);
            // 
            // boton_mas_producto
            // 
            this.boton_mas_producto.BackColor = System.Drawing.Color.Maroon;
            this.boton_mas_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_mas_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_mas_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_mas_producto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_mas_producto.Location = new System.Drawing.Point(230, 296);
            this.boton_mas_producto.Name = "boton_mas_producto";
            this.boton_mas_producto.Size = new System.Drawing.Size(160, 41);
            this.boton_mas_producto.TabIndex = 54;
            this.boton_mas_producto.Text = "Actualizar";
            this.boton_mas_producto.UseVisualStyleBackColor = false;
            this.boton_mas_producto.Click += new System.EventHandler(this.boton_mas_producto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo de Medida";
            // 
            // txt_cantidad_nuevoProducto
            // 
            this.txt_cantidad_nuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad_nuevoProducto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_nuevoProducto.Location = new System.Drawing.Point(230, 189);
            this.txt_cantidad_nuevoProducto.Multiline = true;
            this.txt_cantidad_nuevoProducto.Name = "txt_cantidad_nuevoProducto";
            this.txt_cantidad_nuevoProducto.Size = new System.Drawing.Size(602, 34);
            this.txt_cantidad_nuevoProducto.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cantidad";
            // 
            // butto_bucar
            // 
            this.butto_bucar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butto_bucar.BackColor = System.Drawing.Color.Maroon;
            this.butto_bucar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butto_bucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butto_bucar.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto_bucar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butto_bucar.Location = new System.Drawing.Point(718, 108);
            this.butto_bucar.Name = "butto_bucar";
            this.butto_bucar.Size = new System.Drawing.Size(59, 44);
            this.butto_bucar.TabIndex = 60;
            this.butto_bucar.Text = "ID";
            this.butto_bucar.UseVisualStyleBackColor = false;
            this.butto_bucar.Click += new System.EventHandler(this.butto_bucar_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(46, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(929, 189);
            this.dataGridView1.TabIndex = 64;
            // 
            // FormIngresar_mas_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butto_bucar);
            this.Controls.Add(this.txt_cantidad_nuevoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_mas_producto);
            this.Controls.Add(this.boton_cancelar_ingreso);
            this.Controls.Add(this.lista_de_Opciones_de_Medida);
            this.Controls.Add(this.label_titulo_mas_producto);
            this.Controls.Add(this.poner_id);
            this.Controls.Add(this.txt_buscar_id);
            this.Controls.Add(this.boton_buscar_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresar_mas_producto";
            this.Text = "FormIngresar_mas_producto";
            this.Load += new System.EventHandler(this.FormIngresar_mas_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boton_buscar_id;
        private System.Windows.Forms.TextBox txt_buscar_id;
        private System.Windows.Forms.Label poner_id;
        private System.Windows.Forms.Label label_titulo_mas_producto;
        private System.Windows.Forms.ComboBox lista_de_Opciones_de_Medida;
        private System.Windows.Forms.Button boton_cancelar_ingreso;
        private System.Windows.Forms.Button boton_mas_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad_nuevoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butto_bucar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
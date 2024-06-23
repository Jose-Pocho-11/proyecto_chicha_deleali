namespace proyecto_chicha_deleali
{
    partial class FormProveedores
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
            this.txt_Categorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_Unidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_titulo_ingresar_producto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Conctactar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.PictureBox();
            this.boton_cerra = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Categorias
            // 
            this.txt_Categorias.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Categorias.FormattingEnabled = true;
            this.txt_Categorias.Items.AddRange(new object[] {
            "Elige una medida",
            "bebidas",
            "ingredientes",
            "utiles de cocina",
            "otros"});
            this.txt_Categorias.Location = new System.Drawing.Point(185, 162);
            this.txt_Categorias.Name = "txt_Categorias";
            this.txt_Categorias.Size = new System.Drawing.Size(431, 35);
            this.txt_Categorias.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Categoria";
            // 
            // txt_cantidad_Unidad
            // 
            this.txt_cantidad_Unidad.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_Unidad.Location = new System.Drawing.Point(185, 104);
            this.txt_cantidad_Unidad.Multiline = true;
            this.txt_cantidad_Unidad.Name = "txt_cantidad_Unidad";
            this.txt_cantidad_Unidad.Size = new System.Drawing.Size(431, 34);
            this.txt_cantidad_Unidad.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad";
            // 
            // label_titulo_ingresar_producto
            // 
            this.label_titulo_ingresar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titulo_ingresar_producto.AutoSize = true;
            this.label_titulo_ingresar_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_ingresar_producto.Location = new System.Drawing.Point(292, 52);
            this.label_titulo_ingresar_producto.Name = "label_titulo_ingresar_producto";
            this.label_titulo_ingresar_producto.Size = new System.Drawing.Size(166, 27);
            this.label_titulo_ingresar_producto.TabIndex = 23;
            this.label_titulo_ingresar_producto.Text = "Proveedores";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(185, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(431, 104);
            this.dataGridView1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(100, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(186, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Proveedores Disponibles";
            // 
            // Boton_Conctactar
            // 
            this.Boton_Conctactar.BackColor = System.Drawing.Color.Maroon;
            this.Boton_Conctactar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Boton_Conctactar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Conctactar.Font = new System.Drawing.Font("MS UI Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.Boton_Conctactar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Conctactar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Conctactar.Location = new System.Drawing.Point(489, 361);
            this.Boton_Conctactar.Name = "Boton_Conctactar";
            this.Boton_Conctactar.Size = new System.Drawing.Size(129, 54);
            this.Boton_Conctactar.TabIndex = 27;
            this.Boton_Conctactar.Text = "Contactar";
            this.Boton_Conctactar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Conctactar.UseVisualStyleBackColor = false;
            this.Boton_Conctactar.Click += new System.EventHandler(this.Boton_Conctactar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.boton_minimizar);
            this.panel1.Controls.Add(this.boton_cerra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 37);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_minimizar.Image = global::proyecto_chicha_deleali.Properties.Resources.minimazar;
            this.boton_minimizar.Location = new System.Drawing.Point(633, 3);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(25, 25);
            this.boton_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_minimizar.TabIndex = 8;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Click += new System.EventHandler(this.boton_minimizar_Click);
            // 
            // boton_cerra
            // 
            this.boton_cerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_cerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerra.Image = global::proyecto_chicha_deleali.Properties.Resources.cerrar;
            this.boton_cerra.Location = new System.Drawing.Point(664, 3);
            this.boton_cerra.Name = "boton_cerra";
            this.boton_cerra.Size = new System.Drawing.Size(25, 25);
            this.boton_cerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerra.TabIndex = 7;
            this.boton_cerra.TabStop = false;
            this.boton_cerra.Click += new System.EventHandler(this.boton_cerra_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::proyecto_chicha_deleali.Properties.Resources.icons8_árbol_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(622, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 29;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Boton_Conctactar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_titulo_ingresar_producto);
            this.Controls.Add(this.txt_Categorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cantidad_Unidad);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_Categorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantidad_Unidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_titulo_ingresar_producto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Boton_Conctactar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerra;
        private System.Windows.Forms.Button button1;
    }
}
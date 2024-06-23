namespace proyecto_chicha_deleali
{
    partial class inicio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label_hora_actual = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.label_fecha_actual = new System.Windows.Forms.Label();
            this.boton_cargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_reporte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.boton_proveedores = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.boton_menu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.boton_ventas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_de_filtrar = new System.Windows.Forms.Panel();
            this.check_concina = new System.Windows.Forms.CheckBox();
            this.check_otros = new System.Windows.Forms.CheckBox();
            this.check_ingredientes = new System.Windows.Forms.CheckBox();
            this.check_bebidas = new System.Windows.Forms.CheckBox();
            this.check_todos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel_de_filtrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeight = 30;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(12, 316);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.Size = new System.Drawing.Size(623, 249);
            this.dataGridView3.TabIndex = 64;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label_hora_actual
            // 
            this.label_hora_actual.AutoSize = true;
            this.label_hora_actual.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label_hora_actual.Location = new System.Drawing.Point(30, 213);
            this.label_hora_actual.Name = "label_hora_actual";
            this.label_hora_actual.Size = new System.Drawing.Size(142, 49);
            this.label_hora_actual.TabIndex = 66;
            this.label_hora_actual.Text = "label1";
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // label_fecha_actual
            // 
            this.label_fecha_actual.AutoSize = true;
            this.label_fecha_actual.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label_fecha_actual.Location = new System.Drawing.Point(32, 262);
            this.label_fecha_actual.Name = "label_fecha_actual";
            this.label_fecha_actual.Size = new System.Drawing.Size(112, 39);
            this.label_fecha_actual.TabIndex = 67;
            this.label_fecha_actual.Text = "label1";
            // 
            // boton_cargar
            // 
            this.boton_cargar.BackColor = System.Drawing.Color.Maroon;
            this.boton_cargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boton_cargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cargar.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_cargar.Location = new System.Drawing.Point(0, 0);
            this.boton_cargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boton_cargar.Name = "boton_cargar";
            this.boton_cargar.Size = new System.Drawing.Size(68, 50);
            this.boton_cargar.TabIndex = 68;
            this.boton_cargar.Text = "Cargar";
            this.boton_cargar.UseVisualStyleBackColor = false;
            this.boton_cargar.Click += new System.EventHandler(this.boton_cargar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.boton_reporte);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(57, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 101);
            this.panel1.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::proyecto_chicha_deleali.Properties.Resources.icons8_vista_general_2_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // boton_reporte
            // 
            this.boton_reporte.BackColor = System.Drawing.Color.Maroon;
            this.boton_reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_reporte.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_reporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_reporte.Location = new System.Drawing.Point(0, 0);
            this.boton_reporte.Name = "boton_reporte";
            this.boton_reporte.Size = new System.Drawing.Size(100, 26);
            this.boton_reporte.TabIndex = 0;
            this.boton_reporte.Text = "Reporte";
            this.boton_reporte.UseVisualStyleBackColor = false;
            this.boton_reporte.Click += new System.EventHandler(this.boton_reporte_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.boton_proveedores);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(186, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 101);
            this.panel2.TabIndex = 70;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::proyecto_chicha_deleali.Properties.Resources.camion_de_reparto;
            this.pictureBox2.Location = new System.Drawing.Point(0, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // boton_proveedores
            // 
            this.boton_proveedores.BackColor = System.Drawing.Color.Maroon;
            this.boton_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_proveedores.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_proveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_proveedores.Location = new System.Drawing.Point(0, 0);
            this.boton_proveedores.Name = "boton_proveedores";
            this.boton_proveedores.Size = new System.Drawing.Size(100, 26);
            this.boton_proveedores.TabIndex = 0;
            this.boton_proveedores.Text = "Proveedores";
            this.boton_proveedores.UseVisualStyleBackColor = false;
            this.boton_proveedores.Click += new System.EventHandler(this.boton_proveedores_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.boton_menu);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(310, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 101);
            this.panel3.TabIndex = 71;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyecto_chicha_deleali.Properties.Resources.icons8_food_50__1_;
            this.pictureBox3.Location = new System.Drawing.Point(8, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // boton_menu
            // 
            this.boton_menu.BackColor = System.Drawing.Color.Maroon;
            this.boton_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.boton_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_menu.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_menu.Location = new System.Drawing.Point(0, 0);
            this.boton_menu.Name = "boton_menu";
            this.boton_menu.Size = new System.Drawing.Size(100, 26);
            this.boton_menu.TabIndex = 0;
            this.boton_menu.Text = "Menú";
            this.boton_menu.UseVisualStyleBackColor = false;
            this.boton_menu.Click += new System.EventHandler(this.boton_menu_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.boton_ventas);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(434, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 101);
            this.panel4.TabIndex = 72;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proyecto_chicha_deleali.Properties.Resources.carrito_de_compras;
            this.pictureBox4.Location = new System.Drawing.Point(9, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // boton_ventas
            // 
            this.boton_ventas.BackColor = System.Drawing.Color.Maroon;
            this.boton_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_ventas.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_ventas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_ventas.Location = new System.Drawing.Point(0, 0);
            this.boton_ventas.Name = "boton_ventas";
            this.boton_ventas.Size = new System.Drawing.Size(100, 26);
            this.boton_ventas.TabIndex = 0;
            this.boton_ventas.Text = "Ventas";
            this.boton_ventas.UseVisualStyleBackColor = false;
            this.boton_ventas.Click += new System.EventHandler(this.boton_ventas_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.boton_cargar);
            this.panel5.Location = new System.Drawing.Point(641, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 52);
            this.panel5.TabIndex = 73;
            // 
            // panel_de_filtrar
            // 
            this.panel_de_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_de_filtrar.Controls.Add(this.check_concina);
            this.panel_de_filtrar.Controls.Add(this.check_otros);
            this.panel_de_filtrar.Controls.Add(this.check_ingredientes);
            this.panel_de_filtrar.Controls.Add(this.check_bebidas);
            this.panel_de_filtrar.Controls.Add(this.check_todos);
            this.panel_de_filtrar.Location = new System.Drawing.Point(717, 402);
            this.panel_de_filtrar.Name = "panel_de_filtrar";
            this.panel_de_filtrar.Size = new System.Drawing.Size(176, 128);
            this.panel_de_filtrar.TabIndex = 74;
            this.panel_de_filtrar.Visible = false;
            // 
            // check_concina
            // 
            this.check_concina.AutoSize = true;
            this.check_concina.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.check_concina.Location = new System.Drawing.Point(20, 81);
            this.check_concina.Name = "check_concina";
            this.check_concina.Size = new System.Drawing.Size(146, 20);
            this.check_concina.TabIndex = 4;
            this.check_concina.Text = "utiles de cocina";
            this.check_concina.UseVisualStyleBackColor = true;
            // 
            // check_otros
            // 
            this.check_otros.AutoSize = true;
            this.check_otros.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.check_otros.Location = new System.Drawing.Point(20, 103);
            this.check_otros.Name = "check_otros";
            this.check_otros.Size = new System.Drawing.Size(66, 20);
            this.check_otros.TabIndex = 3;
            this.check_otros.Text = "otros";
            this.check_otros.UseVisualStyleBackColor = true;
            // 
            // check_ingredientes
            // 
            this.check_ingredientes.AutoSize = true;
            this.check_ingredientes.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.check_ingredientes.Location = new System.Drawing.Point(20, 55);
            this.check_ingredientes.Name = "check_ingredientes";
            this.check_ingredientes.Size = new System.Drawing.Size(119, 20);
            this.check_ingredientes.TabIndex = 2;
            this.check_ingredientes.Text = "Ingredientes";
            this.check_ingredientes.UseVisualStyleBackColor = true;
            // 
            // check_bebidas
            // 
            this.check_bebidas.AutoSize = true;
            this.check_bebidas.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.check_bebidas.Location = new System.Drawing.Point(20, 29);
            this.check_bebidas.Name = "check_bebidas";
            this.check_bebidas.Size = new System.Drawing.Size(85, 20);
            this.check_bebidas.TabIndex = 1;
            this.check_bebidas.Text = "Bebidas";
            this.check_bebidas.UseVisualStyleBackColor = true;
            // 
            // check_todos
            // 
            this.check_todos.AutoSize = true;
            this.check_todos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.check_todos.Location = new System.Drawing.Point(20, 3);
            this.check_todos.Name = "check_todos";
            this.check_todos.Size = new System.Drawing.Size(71, 20);
            this.check_todos.TabIndex = 0;
            this.check_todos.Text = "Todos";
            this.check_todos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::proyecto_chicha_deleali.Properties.Resources.icons8_pregunta_32__1_;
            this.button1.Location = new System.Drawing.Point(944, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 50);
            this.button1.TabIndex = 75;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 726);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_de_filtrar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_fecha_actual);
            this.Controls.Add(this.label_hora_actual);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.Text = "Form_Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel_de_filtrar.ResumeLayout(false);
            this.panel_de_filtrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label_hora_actual;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Label label_fecha_actual;
        private System.Windows.Forms.Button boton_cargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button boton_reporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button boton_proveedores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button boton_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button boton_ventas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_de_filtrar;
        private System.Windows.Forms.CheckBox check_concina;
        private System.Windows.Forms.CheckBox check_otros;
        private System.Windows.Forms.CheckBox check_ingredientes;
        private System.Windows.Forms.CheckBox check_bebidas;
        private System.Windows.Forms.CheckBox check_todos;
        private System.Windows.Forms.Button button1;
    }
}
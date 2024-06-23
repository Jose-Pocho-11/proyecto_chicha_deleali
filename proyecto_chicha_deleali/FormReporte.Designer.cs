namespace proyecto_chicha_deleali
{
    partial class FormReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.boton_generar_reporte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.PictureBox();
            this.boton_cerra = new System.Windows.Forms.PictureBox();
            this.panel_de_filtrar = new System.Windows.Forms.Panel();
            this.check_concina = new System.Windows.Forms.CheckBox();
            this.check_otros = new System.Windows.Forms.CheckBox();
            this.check_ingredientes = new System.Windows.Forms.CheckBox();
            this.check_bebidas = new System.Windows.Forms.CheckBox();
            this.check_todos = new System.Windows.Forms.CheckBox();
            this.butto_flitrar = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).BeginInit();
            this.panel_de_filtrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(157, 75);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(489, 34);
            this.txt_nombre.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(28, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 231);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeight = 30;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Size = new System.Drawing.Size(616, 229);
            this.dataGridView3.TabIndex = 15;
            // 
            // boton_generar_reporte
            // 
            this.boton_generar_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_generar_reporte.BackColor = System.Drawing.Color.Maroon;
            this.boton_generar_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_generar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_generar_reporte.Font = new System.Drawing.Font("MS UI Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.boton_generar_reporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_generar_reporte.Location = new System.Drawing.Point(534, 418);
            this.boton_generar_reporte.Name = "boton_generar_reporte";
            this.boton_generar_reporte.Size = new System.Drawing.Size(111, 43);
            this.boton_generar_reporte.TabIndex = 21;
            this.boton_generar_reporte.Text = "Generar";
            this.boton_generar_reporte.UseVisualStyleBackColor = false;
            this.boton_generar_reporte.Click += new System.EventHandler(this.boton_generar_reporte_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.boton_minimizar);
            this.panel2.Controls.Add(this.boton_cerra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 35);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_minimizar.Image = global::proyecto_chicha_deleali.Properties.Resources.minimazar;
            this.boton_minimizar.Location = new System.Drawing.Point(600, 3);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(25, 25);
            this.boton_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_minimizar.TabIndex = 11;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Click += new System.EventHandler(this.boton_minimizar_Click);
            // 
            // boton_cerra
            // 
            this.boton_cerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_cerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerra.Image = global::proyecto_chicha_deleali.Properties.Resources.cerrar;
            this.boton_cerra.Location = new System.Drawing.Point(631, 3);
            this.boton_cerra.Name = "boton_cerra";
            this.boton_cerra.Size = new System.Drawing.Size(25, 25);
            this.boton_cerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerra.TabIndex = 10;
            this.boton_cerra.TabStop = false;
            this.boton_cerra.Click += new System.EventHandler(this.boton_cerra_Click);
            // 
            // panel_de_filtrar
            // 
            this.panel_de_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_de_filtrar.Controls.Add(this.ventas);
            this.panel_de_filtrar.Controls.Add(this.check_concina);
            this.panel_de_filtrar.Controls.Add(this.check_otros);
            this.panel_de_filtrar.Controls.Add(this.check_ingredientes);
            this.panel_de_filtrar.Controls.Add(this.check_bebidas);
            this.panel_de_filtrar.Controls.Add(this.check_todos);
            this.panel_de_filtrar.Location = new System.Drawing.Point(169, 135);
            this.panel_de_filtrar.Name = "panel_de_filtrar";
            this.panel_de_filtrar.Size = new System.Drawing.Size(176, 161);
            this.panel_de_filtrar.TabIndex = 67;
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
            // butto_flitrar
            // 
            this.butto_flitrar.BackColor = System.Drawing.Color.Maroon;
            this.butto_flitrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butto_flitrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butto_flitrar.Font = new System.Drawing.Font("MS UI Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.butto_flitrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butto_flitrar.Location = new System.Drawing.Point(39, 135);
            this.butto_flitrar.Name = "butto_flitrar";
            this.butto_flitrar.Size = new System.Drawing.Size(124, 41);
            this.butto_flitrar.TabIndex = 66;
            this.butto_flitrar.Text = "Filtrar";
            this.butto_flitrar.UseVisualStyleBackColor = false;
            this.butto_flitrar.Click += new System.EventHandler(this.butto_flitrar_Click);
            // 
            // ventas
            // 
            this.ventas.AutoSize = true;
            this.ventas.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ventas.Location = new System.Drawing.Point(20, 129);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(79, 20);
            this.ventas.TabIndex = 5;
            this.ventas.Text = "Ventas";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.CheckedChanged += new System.EventHandler(this.ventas_CheckedChanged);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 516);
            this.Controls.Add(this.panel_de_filtrar);
            this.Controls.Add(this.butto_flitrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.boton_generar_reporte);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).EndInit();
            this.panel_de_filtrar.ResumeLayout(false);
            this.panel_de_filtrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button boton_generar_reporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerra;
        private System.Windows.Forms.Panel panel_de_filtrar;
        private System.Windows.Forms.CheckBox check_concina;
        private System.Windows.Forms.CheckBox check_otros;
        private System.Windows.Forms.CheckBox check_ingredientes;
        private System.Windows.Forms.CheckBox check_bebidas;
        private System.Windows.Forms.CheckBox check_todos;
        private System.Windows.Forms.Button butto_flitrar;
        private System.Windows.Forms.CheckBox ventas;
    }
}
namespace proyecto_chicha_deleali
{
    partial class FormMostrar_eliminados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butto_bucar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel_de_filtrar = new System.Windows.Forms.Panel();
            this.check_concina = new System.Windows.Forms.CheckBox();
            this.check_otros = new System.Windows.Forms.CheckBox();
            this.check_ingredientes = new System.Windows.Forms.CheckBox();
            this.check_bebidas = new System.Windows.Forms.CheckBox();
            this.check_todos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel_de_filtrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // butto_bucar
            // 
            this.butto_bucar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butto_bucar.BackColor = System.Drawing.Color.Maroon;
            this.butto_bucar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butto_bucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butto_bucar.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto_bucar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butto_bucar.Location = new System.Drawing.Point(345, 42);
            this.butto_bucar.Name = "butto_bucar";
            this.butto_bucar.Size = new System.Drawing.Size(151, 44);
            this.butto_bucar.TabIndex = 68;
            this.butto_bucar.Text = "Mostrar";
            this.butto_bucar.UseVisualStyleBackColor = false;
            this.butto_bucar.Click += new System.EventHandler(this.butto_bucar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.ColumnHeadersHeight = 30;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(81, 92);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView3.Size = new System.Drawing.Size(653, 325);
            this.dataGridView3.TabIndex = 67;
            // 
            // panel_de_filtrar
            // 
            this.panel_de_filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_de_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_de_filtrar.Controls.Add(this.check_concina);
            this.panel_de_filtrar.Controls.Add(this.check_otros);
            this.panel_de_filtrar.Controls.Add(this.check_ingredientes);
            this.panel_de_filtrar.Controls.Add(this.check_bebidas);
            this.panel_de_filtrar.Controls.Add(this.check_todos);
            this.panel_de_filtrar.Location = new System.Drawing.Point(502, 12);
            this.panel_de_filtrar.Name = "panel_de_filtrar";
            this.panel_de_filtrar.Size = new System.Drawing.Size(176, 128);
            this.panel_de_filtrar.TabIndex = 69;
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
            // FormMostrar_eliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_de_filtrar);
            this.Controls.Add(this.butto_bucar);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMostrar_eliminados";
            this.Text = "FormMostrar_eliminados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel_de_filtrar.ResumeLayout(false);
            this.panel_de_filtrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butto_bucar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel_de_filtrar;
        private System.Windows.Forms.CheckBox check_concina;
        private System.Windows.Forms.CheckBox check_otros;
        private System.Windows.Forms.CheckBox check_ingredientes;
        private System.Windows.Forms.CheckBox check_bebidas;
        private System.Windows.Forms.CheckBox check_todos;
    }
}
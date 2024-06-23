namespace proyecto_chicha_deleali
{
    partial class FormRecuperar
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
            this.butto_bucar = new System.Windows.Forms.Button();
            this.poner_id = new System.Windows.Forms.Label();
            this.txt_buscar_id = new System.Windows.Forms.TextBox();
            this.boton_buscar_id = new System.Windows.Forms.Button();
            this.label_titulo_mas_producto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_recuperar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butto_bucar
            // 
            this.butto_bucar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butto_bucar.BackColor = System.Drawing.Color.Maroon;
            this.butto_bucar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butto_bucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butto_bucar.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto_bucar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butto_bucar.Location = new System.Drawing.Point(716, 111);
            this.butto_bucar.Name = "butto_bucar";
            this.butto_bucar.Size = new System.Drawing.Size(59, 44);
            this.butto_bucar.TabIndex = 98;
            this.butto_bucar.Text = "ID";
            this.butto_bucar.UseVisualStyleBackColor = false;
            this.butto_bucar.Click += new System.EventHandler(this.butto_bucar_Click);
            // 
            // poner_id
            // 
            this.poner_id.AutoSize = true;
            this.poner_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.poner_id.Location = new System.Drawing.Point(72, 74);
            this.poner_id.Name = "poner_id";
            this.poner_id.Size = new System.Drawing.Size(143, 27);
            this.poner_id.TabIndex = 97;
            this.poner_id.Text = "Colocar ID";
            // 
            // txt_buscar_id
            // 
            this.txt_buscar_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_buscar_id.Location = new System.Drawing.Point(221, 71);
            this.txt_buscar_id.Multiline = true;
            this.txt_buscar_id.Name = "txt_buscar_id";
            this.txt_buscar_id.Size = new System.Drawing.Size(582, 34);
            this.txt_buscar_id.TabIndex = 96;
            // 
            // boton_buscar_id
            // 
            this.boton_buscar_id.BackColor = System.Drawing.Color.Maroon;
            this.boton_buscar_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_buscar_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.boton_buscar_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_buscar_id.Location = new System.Drawing.Point(221, 113);
            this.boton_buscar_id.Name = "boton_buscar_id";
            this.boton_buscar_id.Size = new System.Drawing.Size(150, 42);
            this.boton_buscar_id.TabIndex = 95;
            this.boton_buscar_id.Text = "Buscar";
            this.boton_buscar_id.UseVisualStyleBackColor = false;
            this.boton_buscar_id.Click += new System.EventHandler(this.boton_buscar_id_Click);
            // 
            // label_titulo_mas_producto
            // 
            this.label_titulo_mas_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_titulo_mas_producto.AutoSize = true;
            this.label_titulo_mas_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_mas_producto.Location = new System.Drawing.Point(308, 28);
            this.label_titulo_mas_producto.Name = "label_titulo_mas_producto";
            this.label_titulo_mas_producto.Size = new System.Drawing.Size(332, 27);
            this.label_titulo_mas_producto.TabIndex = 94;
            this.label_titulo_mas_producto.Text = "Recuperando un Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 27);
            this.label1.TabIndex = 99;
            this.label1.Text = "Recuperar Producto";
            // 
            // boton_recuperar
            // 
            this.boton_recuperar.BackColor = System.Drawing.Color.Maroon;
            this.boton_recuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_recuperar.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.boton_recuperar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_recuperar.Location = new System.Drawing.Point(376, 264);
            this.boton_recuperar.Name = "boton_recuperar";
            this.boton_recuperar.Size = new System.Drawing.Size(150, 42);
            this.boton_recuperar.TabIndex = 100;
            this.boton_recuperar.Text = "Recuperar";
            this.boton_recuperar.UseVisualStyleBackColor = false;
            this.boton_recuperar.Click += new System.EventHandler(this.boton_recuperar_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(116, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(687, 189);
            this.dataGridView1.TabIndex = 101;
            // 
            // FormRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton_recuperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butto_bucar);
            this.Controls.Add(this.poner_id);
            this.Controls.Add(this.txt_buscar_id);
            this.Controls.Add(this.boton_buscar_id);
            this.Controls.Add(this.label_titulo_mas_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecuperar";
            this.Text = "FormRecuperar";
            this.Load += new System.EventHandler(this.FormRecuperar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butto_bucar;
        private System.Windows.Forms.Label poner_id;
        private System.Windows.Forms.TextBox txt_buscar_id;
        private System.Windows.Forms.Button boton_buscar_id;
        private System.Windows.Forms.Label label_titulo_mas_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_recuperar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
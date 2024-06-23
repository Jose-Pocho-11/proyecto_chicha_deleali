namespace proyecto_chicha_deleali
{
    partial class FormArbol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.PictureBox();
            this.boton_cerra = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.boton_minimizar);
            this.panel1.Controls.Add(this.boton_cerra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 37);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boton_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_minimizar.Image = global::proyecto_chicha_deleali.Properties.Resources.minimazar;
            this.boton_minimizar.Location = new System.Drawing.Point(582, 3);
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
            this.boton_cerra.Location = new System.Drawing.Point(613, 3);
            this.boton_cerra.Name = "boton_cerra";
            this.boton_cerra.Size = new System.Drawing.Size(25, 25);
            this.boton_cerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerra.TabIndex = 7;
            this.boton_cerra.TabStop = false;
            this.boton_cerra.Click += new System.EventHandler(this.boton_cerra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::proyecto_chicha_deleali.Properties.Resources.Arbol_de_grafo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArbol";
            this.Text = "FormArbol";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
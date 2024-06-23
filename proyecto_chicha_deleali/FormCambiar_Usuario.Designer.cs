namespace proyecto_chicha_deleali
{
    partial class FormCambiar_Usuario
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
            this.label_titulo_mas_producto = new System.Windows.Forms.Label();
            this.label_colocarContra = new System.Windows.Forms.Label();
            this.txt_Contraseña_actual = new System.Windows.Forms.TextBox();
            this.boton_buscar_id = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nuevo_usuario = new System.Windows.Forms.TextBox();
            this.boton_actualizar_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo_mas_producto
            // 
            this.label_titulo_mas_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_titulo_mas_producto.AutoSize = true;
            this.label_titulo_mas_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_mas_producto.Location = new System.Drawing.Point(191, 29);
            this.label_titulo_mas_producto.Name = "label_titulo_mas_producto";
            this.label_titulo_mas_producto.Size = new System.Drawing.Size(417, 27);
            this.label_titulo_mas_producto.TabIndex = 64;
            this.label_titulo_mas_producto.Text = "Actualizando Nombre del Usuario";
            // 
            // label_colocarContra
            // 
            this.label_colocarContra.AutoSize = true;
            this.label_colocarContra.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label_colocarContra.Location = new System.Drawing.Point(12, 100);
            this.label_colocarContra.Name = "label_colocarContra";
            this.label_colocarContra.Size = new System.Drawing.Size(344, 27);
            this.label_colocarContra.TabIndex = 76;
            this.label_colocarContra.Text = "Colocar Contraseña Actual";
            // 
            // txt_Contraseña_actual
            // 
            this.txt_Contraseña_actual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Contraseña_actual.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_Contraseña_actual.Location = new System.Drawing.Point(179, 130);
            this.txt_Contraseña_actual.Multiline = true;
            this.txt_Contraseña_actual.Name = "txt_Contraseña_actual";
            this.txt_Contraseña_actual.PasswordChar = '*';
            this.txt_Contraseña_actual.Size = new System.Drawing.Size(487, 34);
            this.txt_Contraseña_actual.TabIndex = 75;
            // 
            // boton_buscar_id
            // 
            this.boton_buscar_id.BackColor = System.Drawing.Color.Maroon;
            this.boton_buscar_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_buscar_id.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.boton_buscar_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_buscar_id.Location = new System.Drawing.Point(179, 170);
            this.boton_buscar_id.Name = "boton_buscar_id";
            this.boton_buscar_id.Size = new System.Drawing.Size(150, 42);
            this.boton_buscar_id.TabIndex = 74;
            this.boton_buscar_id.Text = "Ingresar";
            this.boton_buscar_id.UseVisualStyleBackColor = false;
            this.boton_buscar_id.Click += new System.EventHandler(this.boton_buscar_id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 27);
            this.label1.TabIndex = 77;
            this.label1.Text = "Colocar Nuevo Nombre de  Usuario";
            this.label1.Visible = false;
            // 
            // txt_Nuevo_usuario
            // 
            this.txt_Nuevo_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nuevo_usuario.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_Nuevo_usuario.Location = new System.Drawing.Point(179, 301);
            this.txt_Nuevo_usuario.Multiline = true;
            this.txt_Nuevo_usuario.Name = "txt_Nuevo_usuario";
            this.txt_Nuevo_usuario.Size = new System.Drawing.Size(487, 34);
            this.txt_Nuevo_usuario.TabIndex = 78;
            this.txt_Nuevo_usuario.Visible = false;
            // 
            // boton_actualizar_usuario
            // 
            this.boton_actualizar_usuario.BackColor = System.Drawing.Color.Maroon;
            this.boton_actualizar_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_actualizar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_actualizar_usuario.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.boton_actualizar_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_actualizar_usuario.Location = new System.Drawing.Point(179, 341);
            this.boton_actualizar_usuario.Name = "boton_actualizar_usuario";
            this.boton_actualizar_usuario.Size = new System.Drawing.Size(150, 42);
            this.boton_actualizar_usuario.TabIndex = 79;
            this.boton_actualizar_usuario.Text = "Actualizar";
            this.boton_actualizar_usuario.UseVisualStyleBackColor = false;
            this.boton_actualizar_usuario.Visible = false;
            this.boton_actualizar_usuario.Click += new System.EventHandler(this.boton_actualizar_usuario_Click);
            // 
            // FormCambiar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_actualizar_usuario);
            this.Controls.Add(this.txt_Nuevo_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_colocarContra);
            this.Controls.Add(this.txt_Contraseña_actual);
            this.Controls.Add(this.boton_buscar_id);
            this.Controls.Add(this.label_titulo_mas_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCambiar_Usuario";
            this.Text = "FormCambiar_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo_mas_producto;
        private System.Windows.Forms.Label label_colocarContra;
        private System.Windows.Forms.TextBox txt_Contraseña_actual;
        private System.Windows.Forms.Button boton_buscar_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nuevo_usuario;
        private System.Windows.Forms.Button boton_actualizar_usuario;
    }
}
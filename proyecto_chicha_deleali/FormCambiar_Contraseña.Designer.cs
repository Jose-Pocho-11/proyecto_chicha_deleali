namespace proyecto_chicha_deleali
{
    partial class FormCambiar_Contraseña
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
            this.label_titulo_ingresar_producto = new System.Windows.Forms.Label();
            this.txt_contraseña_actual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_Contra_actual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contraseña_nueva = new System.Windows.Forms.TextBox();
            this.txt_verificacion_contraseña = new System.Windows.Forms.TextBox();
            this.boton_actualizar_contraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo_ingresar_producto
            // 
            this.label_titulo_ingresar_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_titulo_ingresar_producto.AutoSize = true;
            this.label_titulo_ingresar_producto.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_ingresar_producto.Location = new System.Drawing.Point(307, 32);
            this.label_titulo_ingresar_producto.Name = "label_titulo_ingresar_producto";
            this.label_titulo_ingresar_producto.Size = new System.Drawing.Size(314, 27);
            this.label_titulo_ingresar_producto.TabIndex = 1;
            this.label_titulo_ingresar_producto.Text = "Actualizando contraseña";
            // 
            // txt_contraseña_actual
            // 
            this.txt_contraseña_actual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contraseña_actual.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña_actual.Location = new System.Drawing.Point(273, 123);
            this.txt_contraseña_actual.Multiline = true;
            this.txt_contraseña_actual.Name = "txt_contraseña_actual";
            this.txt_contraseña_actual.PasswordChar = '*';
            this.txt_contraseña_actual.Size = new System.Drawing.Size(507, 34);
            this.txt_contraseña_actual.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña actual ";
            // 
            // boton_Contra_actual
            // 
            this.boton_Contra_actual.BackColor = System.Drawing.Color.Maroon;
            this.boton_Contra_actual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_Contra_actual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Contra_actual.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Contra_actual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_Contra_actual.Location = new System.Drawing.Point(273, 163);
            this.boton_Contra_actual.Name = "boton_Contra_actual";
            this.boton_Contra_actual.Size = new System.Drawing.Size(137, 49);
            this.boton_Contra_actual.TabIndex = 10;
            this.boton_Contra_actual.Text = "Ingresar";
            this.boton_Contra_actual.UseVisualStyleBackColor = false;
            this.boton_Contra_actual.Click += new System.EventHandler(this.boton_Contra_actual_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nueva Contraseña ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmar Contraseña";
            this.label3.Visible = false;
            // 
            // txt_contraseña_nueva
            // 
            this.txt_contraseña_nueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contraseña_nueva.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña_nueva.Location = new System.Drawing.Point(273, 288);
            this.txt_contraseña_nueva.Multiline = true;
            this.txt_contraseña_nueva.Name = "txt_contraseña_nueva";
            this.txt_contraseña_nueva.PasswordChar = '*';
            this.txt_contraseña_nueva.Size = new System.Drawing.Size(507, 34);
            this.txt_contraseña_nueva.TabIndex = 13;
            this.txt_contraseña_nueva.Visible = false;
            // 
            // txt_verificacion_contraseña
            // 
            this.txt_verificacion_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_verificacion_contraseña.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verificacion_contraseña.Location = new System.Drawing.Point(273, 377);
            this.txt_verificacion_contraseña.Multiline = true;
            this.txt_verificacion_contraseña.Name = "txt_verificacion_contraseña";
            this.txt_verificacion_contraseña.PasswordChar = '*';
            this.txt_verificacion_contraseña.Size = new System.Drawing.Size(507, 34);
            this.txt_verificacion_contraseña.TabIndex = 14;
            this.txt_verificacion_contraseña.Visible = false;
            // 
            // boton_actualizar_contraseña
            // 
            this.boton_actualizar_contraseña.BackColor = System.Drawing.Color.Maroon;
            this.boton_actualizar_contraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.boton_actualizar_contraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_actualizar_contraseña.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_actualizar_contraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_actualizar_contraseña.Location = new System.Drawing.Point(273, 417);
            this.boton_actualizar_contraseña.Name = "boton_actualizar_contraseña";
            this.boton_actualizar_contraseña.Size = new System.Drawing.Size(137, 49);
            this.boton_actualizar_contraseña.TabIndex = 15;
            this.boton_actualizar_contraseña.Text = "Ingresar";
            this.boton_actualizar_contraseña.UseVisualStyleBackColor = false;
            this.boton_actualizar_contraseña.Visible = false;
            this.boton_actualizar_contraseña.Click += new System.EventHandler(this.boton_actualizar_contraseña_Click);
            // 
            // FormCambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 542);
            this.Controls.Add(this.boton_actualizar_contraseña);
            this.Controls.Add(this.txt_verificacion_contraseña);
            this.Controls.Add(this.txt_contraseña_nueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_Contra_actual);
            this.Controls.Add(this.txt_contraseña_actual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_titulo_ingresar_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCambiar_Contraseña";
            this.Text = "FormCambiar_Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo_ingresar_producto;
        private System.Windows.Forms.TextBox txt_contraseña_actual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_Contra_actual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contraseña_nueva;
        private System.Windows.Forms.TextBox txt_verificacion_contraseña;
        private System.Windows.Forms.Button boton_actualizar_contraseña;
    }
}
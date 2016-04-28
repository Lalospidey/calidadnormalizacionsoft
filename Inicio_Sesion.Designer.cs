namespace Flonkerton
{
    partial class Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            this.encabezado_login = new System.Windows.Forms.Label();
            this.nombre_usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.boton_iniciar = new System.Windows.Forms.Button();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encabezado_login
            // 
            this.encabezado_login.AutoSize = true;
            this.encabezado_login.Location = new System.Drawing.Point(83, 20);
            this.encabezado_login.Name = "encabezado_login";
            this.encabezado_login.Size = new System.Drawing.Size(91, 13);
            this.encabezado_login.TabIndex = 0;
            this.encabezado_login.Text = "Inicio de Sesion   ";
            this.encabezado_login.Click += new System.EventHandler(this.encabezado_login_Click);
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.Location = new System.Drawing.Point(83, 59);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(109, 20);
            this.nombre_usuario.TabIndex = 1;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(83, 94);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(109, 20);
            this.contraseña.TabIndex = 2;
            this.contraseña.UseSystemPasswordChar = true;
            // 
            // boton_iniciar
            // 
            this.boton_iniciar.Location = new System.Drawing.Point(47, 125);
            this.boton_iniciar.Name = "boton_iniciar";
            this.boton_iniciar.Size = new System.Drawing.Size(62, 21);
            this.boton_iniciar.TabIndex = 3;
            this.boton_iniciar.Text = "Iniciar";
            this.boton_iniciar.UseVisualStyleBackColor = true;
            this.boton_iniciar.Click += new System.EventHandler(this.boton_iniciar_Click);
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(115, 126);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(59, 20);
            this.boton_limpiar.TabIndex = 4;
            this.boton_limpiar.Text = "Limpiar ";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.boton_iniciar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre_usuario);
            this.Controls.Add(this.encabezado_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio_Sesion";
            this.Text = "Flonkerton - Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encabezado_login;
        private System.Windows.Forms.TextBox nombre_usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button boton_iniciar;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace Flonkerton
{
    partial class Modificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion));
            this.Archivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boton_selecion = new System.Windows.Forms.Button();
            this.boton_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Archivo
            // 
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(61, 4);
            // 
            // boton_selecion
            // 
            this.boton_selecion.Location = new System.Drawing.Point(86, 122);
            this.boton_selecion.Name = "boton_selecion";
            this.boton_selecion.Size = new System.Drawing.Size(77, 32);
            this.boton_selecion.TabIndex = 1;
            this.boton_selecion.Text = "button1";
            this.boton_selecion.UseVisualStyleBackColor = true;
            // 
            // boton_regresar
            // 
            this.boton_regresar.Location = new System.Drawing.Point(173, 122);
            this.boton_regresar.Name = "boton_regresar";
            this.boton_regresar.Size = new System.Drawing.Size(71, 31);
            this.boton_regresar.TabIndex = 2;
            this.boton_regresar.Text = "button2";
            this.boton_regresar.UseVisualStyleBackColor = true;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 179);
            this.Controls.Add(this.boton_regresar);
            this.Controls.Add(this.boton_selecion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificacion";
            this.Text = "Modificacion-Flonkerton";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Archivo;
        private System.Windows.Forms.Button boton_selecion;
        private System.Windows.Forms.Button boton_regresar;
    }
}
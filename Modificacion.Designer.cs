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
            this.button1 = new System.Windows.Forms.Button();
            this.Seleccion_modificacion = new System.Windows.Forms.ComboBox();
            this.ppm = new System.Windows.Forms.DataGridView();
            this.campo_modificar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ppm)).BeginInit();
            this.SuspendLayout();
            // 
            // Archivo
            // 
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(61, 4);
            // 
            // boton_selecion
            // 
            this.boton_selecion.Location = new System.Drawing.Point(372, 19);
            this.boton_selecion.Name = "boton_selecion";
            this.boton_selecion.Size = new System.Drawing.Size(77, 32);
            this.boton_selecion.TabIndex = 1;
            this.boton_selecion.Text = "Actualizar";
            this.boton_selecion.UseVisualStyleBackColor = true;
            this.boton_selecion.Click += new System.EventHandler(this.boton_selecion_Click);
            // 
            // boton_regresar
            // 
            this.boton_regresar.Location = new System.Drawing.Point(472, 18);
            this.boton_regresar.Name = "boton_regresar";
            this.boton_regresar.Size = new System.Drawing.Size(91, 32);
            this.boton_regresar.TabIndex = 2;
            this.boton_regresar.Text = "Borrar registro";
            this.boton_regresar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Seleccion_modificacion
            // 
            this.Seleccion_modificacion.FormattingEnabled = true;
            this.Seleccion_modificacion.Location = new System.Drawing.Point(17, 29);
            this.Seleccion_modificacion.Name = "Seleccion_modificacion";
            this.Seleccion_modificacion.Size = new System.Drawing.Size(109, 21);
            this.Seleccion_modificacion.TabIndex = 4;
            // 
            // ppm
            // 
            this.ppm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppm.Location = new System.Drawing.Point(17, 68);
            this.ppm.Name = "ppm";
            this.ppm.Size = new System.Drawing.Size(655, 162);
            this.ppm.TabIndex = 5;
            // 
            // campo_modificar
            // 
            this.campo_modificar.Location = new System.Drawing.Point(232, 31);
            this.campo_modificar.Name = "campo_modificar";
            this.campo_modificar.Size = new System.Drawing.Size(124, 20);
            this.campo_modificar.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 242);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.campo_modificar);
            this.Controls.Add(this.ppm);
            this.Controls.Add(this.Seleccion_modificacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_regresar);
            this.Controls.Add(this.boton_selecion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificacion";
            this.Text = "Modificacion-Flonkerton";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ppm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Archivo;
        private System.Windows.Forms.Button boton_selecion;
        private System.Windows.Forms.Button boton_regresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Seleccion_modificacion;
        private System.Windows.Forms.DataGridView ppm;
        private System.Windows.Forms.TextBox campo_modificar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
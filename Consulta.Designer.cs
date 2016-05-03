namespace Flonkerton
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Consulta_Principal = new System.Windows.Forms.Label();
            this.tipo_consulta = new System.Windows.Forms.Label();
            this.tipo_consulta2 = new System.Windows.Forms.ComboBox();
            this.Busqueda_tipo = new System.Windows.Forms.Label();
            this.seleccion_boton = new System.Windows.Forms.Button();
            this.panel_principal = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Consulta_Principal
            // 
            this.Consulta_Principal.AutoSize = true;
            this.Consulta_Principal.Location = new System.Drawing.Point(1, -1);
            this.Consulta_Principal.Name = "Consulta_Principal";
            this.Consulta_Principal.Size = new System.Drawing.Size(46, 13);
            this.Consulta_Principal.TabIndex = 1;
            this.Consulta_Principal.Text = "Archivo ";
            // 
            // tipo_consulta
            // 
            this.tipo_consulta.AutoSize = true;
            this.tipo_consulta.Location = new System.Drawing.Point(6, 22);
            this.tipo_consulta.Name = "tipo_consulta";
            this.tipo_consulta.Size = new System.Drawing.Size(50, 13);
            this.tipo_consulta.TabIndex = 3;
            this.tipo_consulta.Text = "Producto";
            // 
            // tipo_consulta2
            // 
            this.tipo_consulta2.FormattingEnabled = true;
            this.tipo_consulta2.Items.AddRange(new object[] {
            "Fideos",
            "Galletas"});
            this.tipo_consulta2.Location = new System.Drawing.Point(62, 19);
            this.tipo_consulta2.Name = "tipo_consulta2";
            this.tipo_consulta2.Size = new System.Drawing.Size(87, 21);
            this.tipo_consulta2.TabIndex = 4;
            this.tipo_consulta2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Busqueda_tipo
            // 
            this.Busqueda_tipo.AutoSize = true;
            this.Busqueda_tipo.Location = new System.Drawing.Point(155, 22);
            this.Busqueda_tipo.Name = "Busqueda_tipo";
            this.Busqueda_tipo.Size = new System.Drawing.Size(55, 13);
            this.Busqueda_tipo.TabIndex = 6;
            this.Busqueda_tipo.Text = "Busqueda";
            // 
            // seleccion_boton
            // 
            this.seleccion_boton.Location = new System.Drawing.Point(322, 17);
            this.seleccion_boton.Name = "seleccion_boton";
            this.seleccion_boton.Size = new System.Drawing.Size(74, 23);
            this.seleccion_boton.TabIndex = 7;
            this.seleccion_boton.Text = "Buscar";
            this.seleccion_boton.UseVisualStyleBackColor = true;
            this.seleccion_boton.Click += new System.EventHandler(this.seleccion_boton_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel_principal.Location = new System.Drawing.Point(22, 55);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(373, 156);
            this.panel_principal.TabIndex = 8;
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(214, 20);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(92, 20);
            this.Tipo.TabIndex = 9;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 229);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.seleccion_boton);
            this.Controls.Add(this.Busqueda_tipo);
            this.Controls.Add(this.tipo_consulta2);
            this.Controls.Add(this.tipo_consulta);
            this.Controls.Add(this.Consulta_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.Text = "Consulta-Flonkerton";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Consulta_Principal;
        private System.Windows.Forms.Label tipo_consulta;
        private System.Windows.Forms.ComboBox tipo_consulta2;
        private System.Windows.Forms.Label Busqueda_tipo;
        private System.Windows.Forms.Button seleccion_boton;
        private System.Windows.Forms.DataGridView panel_principal;
        private System.Windows.Forms.TextBox Tipo;
    }
}
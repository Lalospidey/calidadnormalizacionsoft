using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
//Programa:Flonkerton
//Autor:Vazquez Cortes Gerardo
//Fecha:26/Abril/2016
//Version:1.0
//Descripcion:Programa elaborado para el control de inventario de galletas y fideos
namespace Flonkerton
{
    public partial class Consulta : Form
    {
        string dbConnectionString = @"Data Source=base.sqlite; Version=3; FailIfMissing=True; New=False;Compress=True;";
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);

            sqliteCon.Open();
            if (tipo_consulta2.SelectedItem.ToString() == "Fideos")
            {
                string query = "select * from fideo ";//order by '"+this.Tipo.Text +"'";
                SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                DataSet ds = new DataSet();
                ds.Reset();
                DataTable dt = new DataTable();
                db.Fill(ds);
                dt = ds.Tables[0];
                panel_principal.DataSource = dt;
            }
            if (tipo_consulta2.SelectedItem.ToString() == "Galletas")
            {
                string query = "select * from Tg ";//order by '"+this.Tipo.Text +"'";
                SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                DataSet ds = new DataSet();
                ds.Reset();
                DataTable dt = new DataTable();
                db.Fill(ds);
                dt = ds.Tables[0];
                panel_principal.DataSource = dt;
            }
        }

        private void seleccion_boton_Click(object sender, EventArgs e)
        {
            
               
            
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

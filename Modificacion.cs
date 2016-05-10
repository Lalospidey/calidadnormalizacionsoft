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
    public partial class Modificacion : Form
    {
        string dbConnectionString = @"Data Source=base.sqlite; Version=3; FailIfMissing=True; New=False;Compress=True;"
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            
                sqliteCon.Open();
               if (Seleccion_modificacion.SelectedItem.ToString()=="Fideos")
                {
                   string query = "select * from fideo ";//order by '"+this.Tipo.Text +"'";
                   SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                   DataSet ds = new DataSet();
                   ds.Reset();
                   DataTable dt = new DataTable();
                   db.Fill(ds);
                   dt = ds.Tables[0];
                   ppm.DataSource = dt;
                 }
               if (Seleccion_modificacion.SelectedItem.ToString() == "Galletas")
               {
                   string query = "select * from Tg ";//order by '"+this.Tipo.Text +"'";
                   SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                   DataSet ds = new DataSet();
                   ds.Reset();
                   DataTable dt = new DataTable();
                   db.Fill(ds);
                   dt = ds.Tables[0];
                   ppm.DataSource = dt;
               }}

        private void boton_selecion_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
                sqliteCon.Open();
               if (Seleccion_modificacion.SelectedItem.ToString()=="Fideos")
                {
                   string query = "update from fideo ";//order by '"+this.Tipo.Text +"'";
                   SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                   DataSet ds = new DataSet();
                   ds.Reset();
                   DataTable dt = new DataTable();
                   db.Fill(ds);
                   dt = ds.Tables[0];
                   ppm.DataSource = dt;
                 }
               if (Seleccion_modificacion.SelectedItem.ToString() == "Galletas")
               {
                   string query = "select * from Tg ";//order by '"+this.Tipo.Text +"'";
                   SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
                   DataSet ds = new DataSet();
                   ds.Reset();
                   DataTable dt = new DataTable();
                   db.Fill(ds);
                   dt = ds.Tables[0];
                   ppm.DataSource = dt;
               }}
        }
        

    }
 
    }


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
        string dbConnectionString = @"Data Source=base.sqlite; Version=3;";
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seleccion_boton_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                sqliteCon.Open();
               if (tipo_consulta2.SelectedItem.ToString()=="Fideos")
                {
                    string query = "select * from Tf ";//order by '"+this.Tipo.Text +"'";
                    SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);
                    createCommand.ExecuteNonQuery();
                    SQLiteDataReader dr = createCommand.ExecuteReader();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(createCommand);
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        this.panel_principal.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                   
                }
               if (tipo_consulta2.SelectedItem.ToString() == "Galletas")
               {
                   string query = "select * from Tg";// order by '" + this.Tipo.Text + "'";
                   SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);
                   createCommand.ExecuteNonQuery();
                   SQLiteDataReader dr = createCommand.ExecuteReader();
                   SQLiteDataAdapter da = new SQLiteDataAdapter(createCommand);
                   DataSet ds = new DataSet();
                   try
                   {
                       da.Fill(ds);
                       DataTable dt = ds.Tables[0];
                       this.panel_principal.DataSource = dt;
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Error");
                   }
                   

               }
               else
               { MessageBox.Show("No se ha encontrado la consulta"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

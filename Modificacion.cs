using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.VisualBasic;
//Programa:Flonkerton
//Autor:Vazquez Cortes Gerardo
//Fecha:26/Abril/2016
//Version:1.0
//Descripcion:Programa elaborado para el control de inventario de galletas y fideos
namespace Flonkerton
{
    public partial class Modificacion : Form
    {
        string dbConnectionString = @"Data Source=base.sqlite; Version=3; FailIfMissing=True; New=False;Compress=True;";
       
        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
         List<MyComboBoxItem> cb1Items = new List<MyComboBoxItem>();
            cb1Items.Add(new MyComboBoxItem("Fideos")
            {
            SubItems = {new MyComboBoxItem("Id_fideos"), new MyComboBoxItem("Tipo"), new MyComboBoxItem("Marca"), new MyComboBoxItem("Precio Paquete"), new MyComboBoxItem("Peso Paquete"), new MyComboBoxItem("Cantidad Paquetes Stock") }
            });
            cb1Items.Add(new MyComboBoxItem("Galletas")
            {
           SubItems = {new MyComboBoxItem("Id_Galletas"),new MyComboBoxItem("Nombre"), new MyComboBoxItem("Sabor") , new MyComboBoxItem("Marca"), new MyComboBoxItem("Precio Paquete") , new MyComboBoxItem("Cantidad Paquete") , new MyComboBoxItem("Cantidad Paquete Stock ")
                  }
             });
            //load data items into combobox 1
            Seleccion_modificacion.Items.AddRange(cb1Items.ToArray());
               }

        private void boton_selecion_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            string query = "Update " + Seleccion_modificacion.SelectedItem.ToString() + " set '" + campos_tabla.SelectedItem.ToString() + "'='" + campo_modificar.Text + "' where id='" + producto.Text + "'";
            SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
          }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Seleccion_modificacion.SelectedItem.ToString() == "Fideos")
            {
              string[] array = new string[6];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Microsoft.VisualBasic.Interaction.InputBox("Introduce  los datos",
                                                  "Fideos",
                                                  "Introduce el " + (i + 1) + " Registro",
                                                  -1, -1);
                  }}
                //string txtSQLQuery = "insert into  Fideos (desc) values ('" + txtDesc.Text + "')";
                //ExecuteQuery(txtSQLQuery);
             if (Seleccion_modificacion.SelectedItem.ToString() == "Galletas")
                {
                    string[] arrayg = new string[7];
                    for (int i = 0; i < arrayg.Length; i++)
                    {
                        arrayg[i] = Microsoft.VisualBasic.Interaction.InputBox("Introduce  los datos",
                                                      "Galletas",
                                                      "Introduce el " + (i + 1) + " Registro",
                                                      -1, -1);
                    }

                }
            }
        
          //  SubItems = {new MyComboBoxItem("Id_fideos"), new MyComboBoxItem("Tipo"), new MyComboBoxItem("Marca"), new MyComboBoxItem("Precio Paquete"), new MyComboBoxItem("Peso Paquete"), new MyComboBoxItem("Cantidad Paquetes Stock") }
            
            //SubItems = {new MyComboBoxItem("Id_Galletas"),new MyComboBoxItem("Nombre"), new MyComboBoxItem("Sabor") , new MyComboBoxItem("Marca"), new MyComboBoxItem("Precio Paquete") , new MyComboBoxItem("Cantidad Paquete") , new MyComboBoxItem("Cantidad Paquete Stock "


        

        private void boton_regresar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            string query = "delete * from'"+Seleccion_modificacion.SelectedItem.ToString() +"'where'"+this.campo_modificar.Text +"'";
            SQLiteDataAdapter db = new SQLiteDataAdapter(query, sqliteCon);
        }
        private void Seleccion_modificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            //get the combobox item
            MyComboBoxItem item = (sender as ComboBox).SelectedItem as MyComboBoxItem;

            //make sure no shinanigans are going on
            if (item == null)
                return;


            campos_tabla.Items.Clear();

            //add sub items
            campos_tabla.Items.AddRange(item.SubItems.ToArray());
            if (Seleccion_modificacion.SelectedItem.ToString() == "Fideos")
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
            }
        }
private void campo_modificar_TextChanged(object sender, EventArgs e)
        {

        }

        
       
        }
    public class MyComboBoxItem
    {
        public string Name;
        public List<MyComboBoxItem> SubItems = new List<MyComboBoxItem>();

        public MyComboBoxItem(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }   
    }   




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
            SQLiteCommand queryU = new SQLiteCommand("Update " + Seleccion_modificacion.SelectedItem.ToString() + " set '" + campos_tabla.SelectedItem.ToString() + "'='" + campo_modificar.Text + "' where id='" + producto.Text + "'",sqliteCon);
            try
            {
                queryU.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }    
          }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Seleccion_modificacion.SelectedItem.ToString() == "Fideos")
            {
                SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
              string[] array = new string[6];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Microsoft.VisualBasic.Interaction.InputBox("Introduce  los datos",
                                                  "Fideos",
                                                  "Introduce el " + (i + 1) + " Registro",
                                                  -1, -1);
                     
                }
                sqliteCon.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO fideo (Id_fideos,Tipo,Marca,Precio_Paquete, Peso_Paquete,Cantidades_paquetes_stock) VALUES (?,?,?,?,?,?)",sqliteCon);
                insertSQL.Parameters.AddWithValue("Id_fideos",(array[0]));
                insertSQL.Parameters.AddWithValue("Tipo",(array[1]));
                insertSQL.Parameters.AddWithValue("Marca",(array[2]));
                insertSQL.Parameters.AddWithValue("Precio_Paquete",(array[3]));
                insertSQL.Parameters.AddWithValue("Peso_Paquete",(array[4]));
                insertSQL.Parameters.AddWithValue("Cantidad_Paquetes_Stock",(array[5]));
                try
                {
                    insertSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                sqliteCon.Close();

             }
               
             if (Seleccion_modificacion.SelectedItem.ToString() == "Galletas")
                {
                    SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
                    string[] arrayg = new string[7];
                    for (int i = 0; i < arrayg.Length; i++)
                    {
                        arrayg[i] = Microsoft.VisualBasic.Interaction.InputBox("Introduce  los datos",
                                                      "Galletas",
                                                      "Introduce el " + (i + 1) + " Registro",
                                                      -1, -1);
                    }
                    sqliteCon.Open();
                    SQLiteCommand insertSQLg = new SQLiteCommand("INSERT INTO Tg (Id_galletas,nombre,sabor,marca,precio_paquete,cantidad_paquete,cantidad_paquete_stock) VALUES (?,?,?,?,?,?,?)", sqliteCon);
                    insertSQLg.Parameters.AddWithValue("Id_galletas",(arrayg[0]));
                    insertSQLg.Parameters.AddWithValue("nombre",(arrayg[1]));
                    insertSQLg.Parameters.AddWithValue("sabor",(arrayg[2]));
                    insertSQLg.Parameters.AddWithValue("marca",(arrayg[3]));
                    insertSQLg.Parameters.AddWithValue("precio_paquete",(arrayg[4]));
                    insertSQLg.Parameters.AddWithValue("cantidad_paquete",(arrayg[5]));
                    insertSQLg.Parameters.AddWithValue("cantidad_paquete_stock",(arrayg[6]));
                    try
                    {
                        insertSQLg.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    sqliteCon.Close();
                }
            }
      private void boton_regresar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
           string selectt;
           selectt = (Seleccion_modificacion.SelectedItem.ToString() == "Fideos") ? "fideo" : "tg";
           string idss;
           idss = (selectt == "fideo") ? "Id_fideos" : "Id_galletas";
           sqliteCon.Open();
           if ((selectt == "fideo") && (idss =="Id_fideos"))
           { SQLiteCommand queryd = new SQLiteCommand("delete from fideo where Id_fideos ='" + Int32.Parse(this.campo_modificar.Text) + "'", sqliteCon);
           try
            {
                queryd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           sqliteCon.Close();
           }
          if(selectt=="tg"&& idss=="Id_galletas")
          {SQLiteCommand queryd = new SQLiteCommand("delete  from tg where Id_galletas ='"+Int32.Parse( this.campo_modificar.Text) + "'", sqliteCon);
          try
            {
                queryd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqliteCon.Close();  }
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




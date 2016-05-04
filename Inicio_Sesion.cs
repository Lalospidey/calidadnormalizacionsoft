using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                    //Librerias estandar a utilizar 
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
    public partial class Inicio_Sesion : Form
    {  
        string dbConnectionString = @"Data Source=base.sqlite; Version=3;";
        public Inicio_Sesion()
        {
            InitializeComponent();

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encabezado_login_Click(object sender, EventArgs e)
        {

        }

 private void boton_limpiar_Click(object sender, EventArgs e)//funcion
        {
            nombre_usuario.Text = "";
            contraseña.Text = "";
        }

        private void boton_iniciar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                sqliteCon.Open();
                string Query ="select * from Usuarios where nombre_usuario ='"+this.nombre_usuario.Text+"' and pass='"+this.contraseña.Text+"'";
                string tipo = "select tipo_usuario  from Usuarios where nombre_usuario ='" + this.nombre_usuario.Text + "' and pass='" + this.contraseña.Text + "'";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();
                int contador=0;
               int x=0;
               
                while(dr.Read())
                {
                    contador++;
                    x =Convert.ToInt32(dr[2]);
                }
                if (contador == 1 &&  x==2)
                {
                 Consulta frm2 = new Consulta();
                    this.Hide();
                    frm2.ShowDialog();
                    nombre_usuario.Text = "";
                    contraseña.Text = "";
                    this.Show(); 
                    
                 }
                if(contador ==1  && (x==3||x==1) )
                {
                  Modificacion frm3 = new Modificacion();
                  this.Hide();
                  frm3.ShowDialog();
                  nombre_usuario.Text = "";
                  contraseña.Text = "";
                   this.Show();
                   }
                if (contador<1 && nombre_usuario.Text.Length == 0 && contraseña.Text.Length == 0)
                //funcion que verifica que tipo de usuario
                //intenta ingresar al sistema asi mismo verifica que los campos no sean nulos 
                {
                    string message = "No haz introducido ningun dato. ";
                    string caption = "Error ";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);
                }
                if (contador < 1 && nombre_usuario.Text.Length == 0 && contraseña.Text.Length != 0)
                {
                    string message = "No haz introducido el nombre de usuario. ";
                    string caption = "Error ";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);
                }
                if (contador < 1 && nombre_usuario.Text.Length != 0 && contraseña.Text.Length == 0)
                 {
                    string message = "No haz introducido la contraseña. ";
                    string caption = "Error ";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);
                }
                if(contador <1 && nombre_usuario.Text.Length != 0 && contraseña.Text.Length != 0 )
                {
                 string message = "Usuario no valido . ";
                 string caption = "Error ";
                 DialogResult result;
                 result = MessageBox.Show(message, caption);
                }
                }
           catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
            }
            
    }
}
    
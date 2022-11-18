using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class GestionDeUsuarios : Form
    {


        Bitmap bitmap;
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "192.168.5.50";
        String username = "gabriel.moreira";
        String password = "5474809-6";
        String database = "gabriel_moreira"; // cambiar al momento de entrega



        public GestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
           "password=" + password + ";" + "database=" + database;

            try
            {

                sqlConn.Open();
                sqlQuery = "INSERT INTO  gabriel_moreira.Usuario (ID_Usuario , Nom_Usuario, Mail, password, nivelPermmiso )" + "VALUES('" + txtIdUsuario.Text + "' , '" + txtUsuario.Text + "', '" + txtMail.Text + "' , '" + txtContra.Text + "' , '" + txtNivelPermiso.Text + "' )";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                sqlConn.Close();


            }
            upLoadData();



        }



        private void upLoadData()
        {

            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
               "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM gabriel_moreira.Usuario";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Nom_Usuario LIKE '%{0}%' ", txtBuscar.Text);
                dataGridView1.DataSource = dv.ToTable();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
          "password=" + password + ";" + "database=" + database;



            sqlConn.Open();


            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE gabriel_moreira.Usuario SET ID_Usuario = @ID_Usuario , Nom_Usuario = @Nom_usuario , Mail = @Mail, password = @password , nivelPermiso = @nivelPermiso";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_Usuario", txtIdUsuario.Text);
                sqlCmd.Parameters.AddWithValue("@Nom_Usuario", txtUsuario.Text);
                sqlCmd.Parameters.AddWithValue("@Mail", txtMail.Text);
                sqlCmd.Parameters.AddWithValue("@password", txtContra.Text);
                sqlCmd.Parameters.AddWithValue("@nivelPermiso", txtNivelPermiso.Text);

                sqlCmd.ExecuteNonQuery();

                sqlConn.Clone();
                upLoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
            "password=" + password + ";" + "database=" + database;

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "DELETE FROM gabriel_moreira.Usuario WHERE Nom_Usuario = @Nom_usuario";

            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);


            }

            upLoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel1.Controls)
                {

                    if (c is TextBox)
                        ((TextBox)c).Clear();

                }

                txtBuscar.Text = "";


            }
            catch { }
        }
    }
}

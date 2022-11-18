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
    public partial class GestionDeEncuentros : Form
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



        public GestionDeEncuentros()
        {
            InitializeComponent();
        }

        private void GestionDeEncuentros_Load(object sender, EventArgs e)
        {

        }

        private void upLoadData()
        {

            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
               "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM gabriel_moreira.Encuentro";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;



        }

        private void btnAgregaEncuentro_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
          "password=" + password + ";" + "database=" + database;

            try
            {

                sqlConn.Open();
                sqlQuery = "INSERT INTO  gabriel_moreira.Encuentro (ID_Encuentro , Hora, Fecha)" + " VALUES ('" + txtIdEncuentro.Text + "' , '" + txtHora.Text + "', '" + txtFecha.Text + "')";


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
         "password=" + password + ";" + "database=" + database;



            sqlConn.Open();


            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE gabriel_moreira.Encuentro SET ID_Encuentro = @ID_Encuentro , Hora = @Hora , Fecha = @Fecha";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_Encuentro", txtIdEncuentro.Text);
                sqlCmd.Parameters.AddWithValue("@Hora", txtHora.Text);
                sqlCmd.Parameters.AddWithValue("@fecha", txtFecha.Text);

                sqlCmd.ExecuteNonQuery();

                sqlConn.Clone();
                upLoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }
        }

        private void btnBorrarEncuentro_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
             "password=" + password + ";" + "database=" + database;

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "DELETE FROM gabriel_moreira.Encuentro WHERE ID_Evento = @ID_Evento";

            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);


            }

            upLoadData();

        }

        private void Reset_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtIdEncuentro.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFecha.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtHora.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);





            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("ID_Encuentro LIKE '%{0}%' ", txtBuscar.Text);
                dataGridView1.DataSource = dv.ToTable();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}

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
    public partial class GestionDeEventos : Form
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



        public GestionDeEventos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             
          
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
          

            
        }

        private void GestionDeEventos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
           "password=" + password + ";" + "database=" + database;

            try
            {

                sqlConn.Open();
                sqlQuery = "INSERT INTO  gabriel_moreira.Evento (ID_Evento , Nom_Evento,Fecha_Evento, Hora_Evento , Lugar_Evento )" + "VALUES('" + txtIdEvento.Text + "' , '" + txtNombreEvento.Text + "', '" + txtFechaEvento.Text + "' , '" + txtHoraEvento + "' , '" + txtLugarEvento + "' )";

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


   
        

        private void dtpFechaCrear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFecha1_ValueChanged(object sender, EventArgs e)
        {

        }







        bool CambiarFormatoDeFecha(string user , string value = ":") {


            return user.Contains(value);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
          "password=" + password + ";" + "database=" + database;

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "DELETE FROM gabriel_moreira.Evento WHERE Nom_Evento = @Nom_Evento";

            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

            foreach (DataGridViewRow item in this.dtgEventos.SelectedRows)
            {

                dtgEventos.Rows.RemoveAt(item.Index);


            }

            upLoadData();
        }

        private void dtgEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void upLoadData()
        {

            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
               "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM gabriel_moreira.Evento";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dtgEventos.DataSource = sqlDt;



        }

        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Nom_Evento LIKE '%{0}%' ", txtBuscarNombre.Text);
                dtgEventos.DataSource = dv.ToTable();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dtgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtIdEvento.Text = dtgEventos.SelectedRows[0].Cells[0].Value.ToString();
                txtNombreEvento.Text = dtgEventos.SelectedRows[0].Cells[1].Value.ToString();               
                txtFechaEvento.Text = dtgEventos.SelectedRows[0].Cells[2].Value.ToString();
                txtHoraEvento.Text = dtgEventos.SelectedRows[0].Cells[3].Value.ToString();
                txtLugarEvento.Text = dtgEventos.SelectedRows[0].Cells[4].Value.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);





            }
        }

        private void txtIdEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
           "password=" + password + ";" + "database=" + database;



            sqlConn.Open();


            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE gabriel_moreira.Evento SET ID_Evento = @ID_Evento , Nom_Evento = @Nom_Evento , Fecha_Evento = @Fecha_Evento, Hora_Evento = @Hora_Evento , Lugar_Evento = @Lugar_Evento";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_Evento", txtIdEvento.Text);
                sqlCmd.Parameters.AddWithValue("@Nom_Evento", txtNombreEvento.Text);
                sqlCmd.Parameters.AddWithValue("@Fecha_Evento", txtFechaEvento.Text);
                sqlCmd.Parameters.AddWithValue("@Hora_Evento", txtHoraEvento.Text);
                sqlCmd.Parameters.AddWithValue("@Lugar_Evento", txtLugarEvento.Text);

                sqlCmd.ExecuteNonQuery();

                sqlConn.Clone();
                upLoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }
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

                txtBuscarNombre.Text = "";


            }
            catch { }
        }
    }
}

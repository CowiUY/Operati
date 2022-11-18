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
    public partial class GestionDeDeportes : Form
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



        public GestionDeDeportes()
        {
            InitializeComponent();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
            "password=" + password + ";" + "database=" + database;

            try
            {

                sqlConn.Open();
                sqlQuery = "INSERT INTO gabriel_moreira.Deporte (ID_Deporte , Nom_Deporte, Categoria_Deporte)" + "VALUES('" + txtIdDeporte.Text + "' , '" + txtNomDeporte.Text + "', '" + txtCategoria.Text + "')";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally {

                sqlConn.Close();


            }
            upLoadData();






        }
               

            // metodo con json :
            /*Deporte newDeporte = new Deporte
            {
                Categoria = txtCategoria.Text,
                IdDeporte = txtTipoDeporte.Text,
                NomEquipo = txtNomEquipo.Text
            };

            var Deporte = Logica.DeserializeDeportes(Logica.GetJson("SerialJson\\Deportes.json"));
            Logica.SerializeDeportes(Deporte);

            if (Deporte != null)
            {
                Deporte.Add(newDeporte);
                Logica.SerializeDeportes(Deporte);
            }
       
            else
            {

                List<Deporte> Depo = new List<Deporte>();
                Logica.SerializeDeportes(Depo);

            }*/
        
        

        private void txtTipoDeporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void GestionDeDeportes_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e, int id, Panel p)
        {
            

        }

        private void upLoadData() {

            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
               "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM gabriel_moreira.Deporte";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
              "password=" + password + ";" + "database=" + database;

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "DELETE FROM gabriel_moreira.Deporte WHERE ID_Deporte = @ID_Deporte";

            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) {

                dataGridView1.Rows.RemoveAt(item.Index);


            }

            upLoadData();









        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try {
                foreach (Control c in panel1.Controls) {

                    if (c is TextBox)
                        ((TextBox)c).Clear();

                }

                txtBuscar.Text = "" ;


            } catch { }
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

                sqlCmd.CommandText = "UPGRADE gabriel_moreira.Deporte SET ID_Deporte = @ID_Deporte , Nom_Deporte = @Nom_Deporte , Categoria_Deporte = @Categoria_Deporte";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_Deporte", txtIdDeporte.Text);
                sqlCmd.Parameters.AddWithValue("@Nom_Deporte", txtNomDeporte.Text);
                sqlCmd.Parameters.AddWithValue("@Categoria_Deporte", txtCategoria.Text);

                sqlCmd.ExecuteNonQuery();

                sqlConn.Clone();
                upLoadData();
               

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);




            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                txtIdDeporte.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtNomDeporte.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtCategoria.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();



            } catch (Exception ex) {

                MessageBox.Show(ex.Message);





            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Nom_deporte LIKE '%{0}%' ", txtBuscar.Text);
                dataGridView1.DataSource = dv.ToTable();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


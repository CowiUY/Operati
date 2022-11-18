﻿using MySql.Data.MySqlClient;
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
    public partial class GestionDeEquipo : Form
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





        public GestionDeEquipo()
        {
            InitializeComponent();
        }

        private void GestionDeEquipo_Load(object sender, EventArgs e)
        {

        }

        private void upLoadData()
        {

            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
               "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM gabriel_moreira.Equipo";

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

            try
            {

                sqlConn.Open();
                sqlQuery = "INSERT INTO  gabriel_moreira.Equipo (ID_Equipo , Nom_Equipo, Pais_Origen)" + "VALUES('" + txtIDEquipo.Text + "' , '" + txtNomEquipo.Text + "', '" + txtPaisOrigen.Text + "')";

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Nom_Equipo LIKE '%{0}%' ", txtBuscar.Text);
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

                sqlCmd.CommandText = "UPDATE gabriel_moreira.Equipo SET ID_Equipo = @ID_Equipo , Nom_Equipo = @Nom_Equipo , Pais_Origen = @Pais_Origen";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_Equipo", txtIDEquipo.Text);
                sqlCmd.Parameters.AddWithValue("@Nom_Equipo", txtNomEquipo.Text);
                sqlCmd.Parameters.AddWithValue("@Pais_origen", txtPaisOrigen.Text);

                sqlCmd.ExecuteNonQuery();

                sqlConn.Clone();
                upLoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server" + server + ";" + "user id =" + username + ";" +
           "password=" + password + ";" + "database=" + database;

            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "DELETE FROM gabriel_moreira.Equipo WHERE Nom_Equipo = @Nom_Equipo";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               txtIDEquipo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtNomEquipo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPaisOrigen.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);





            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

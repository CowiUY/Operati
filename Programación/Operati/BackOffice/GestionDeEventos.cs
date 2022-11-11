﻿using System;
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
        public GestionDeEventos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             bool tipo = false;
            Evento evento = new Evento();
            evento.nombre = txtBuscarNombre.Text;
            evento.conexion = Program.conexion;

            DateTime fecha = dtFecha1.Value;
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);

            evento.fecha = fecha2;
          

            if (evento.conexion.State == 0)
            {
                MessageBox.Show("conexion cerrada");
                return;
            }
            else
            {
                if (txtBuscarNombre.Text.Length!=0)
                {
                    try
                    {
                        dtgEventos.DataSource = evento.ListarEventos(tipo);
                    }
                    catch 
                    {

                        MessageBox.Show("error de conexion");
                    }

                   

                }
                else
                {
                    MessageBox.Show("debe ingresar el nombre del evento");
                    return;
                }

                if (dtgEventos.RowCount > 1)
                {
                    btnAgregar.Visible = false;
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("", "El evento no existe ¿Desea crearlo? ", MessageBoxButtons.YesNoCancel);
                    if (respuesta == DialogResult.Yes)
                    {
                        btnAgregar.Visible = true;
                        txtNombreEncuentro.Text = txtBuscarNombre.Text;
                        txtBuscarNombre.Clear();

                    }
                }
            }
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
          

            
        }

        private void GestionDeEventos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica.
        }


        private void crearEvento(bool alta){


           
     

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

        }

        private void dtgEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class GestionDeDeportes : Form
    {
        public GestionDeDeportes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Deporte newDeporte = new Deporte
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

            }
        }
        

        private void txtTipoDeporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void GestionDeDeportes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {

        }
    }
}

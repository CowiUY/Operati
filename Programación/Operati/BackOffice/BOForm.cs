﻿using Operati2;
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
    public partial class BOForm : Form
    {
        public BOForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formUser = new GestionDeUsuarios();
            formUser.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formBanners1 = new GestionDeBanners();
            formBanners1.Show();
        }

        private void BOForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formDepo = new GestionDeDeportes();
            formDepo.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            Form formEventos = new GestionDeEventos();
            formEventos.Show();
        }
    }
}

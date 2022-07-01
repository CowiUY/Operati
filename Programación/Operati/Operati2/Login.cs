using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace Operati2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool match = false;
                String user = txtUsuario.Text;
                String password = txtContraseña.Text;
                var usuarios = Logica.DeserializeUsuarios(Logica.GetJson("SerialJson\\Usuarios.json"));

                if (usuarios != null) {


                    foreach (var usuario in usuarios)
                    {
                        if (usuario.UserID == user && usuario.password == password && usuario.nivelPermiso == 3)
                        {
                            match = true;
                        }



                    }


                }
            }
        }

        private void TxtAñadirUser_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            formulario.Show();

        }














    



    }




















}

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BackOffice;

namespace Operati2
{
    public partial class Login : Form
        match = false;
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
                bool Igualdad = false;
                String user = txtUsuario.Text;
                String password = txtContraseña.Text;

                if (Logica.VerificarSiExiste("Usuario", "Mail", user) == 3)
                {
                    var u = Logica.GetUsuarios(2, user)[0];
                    if (Logica.DesencriptamosContra(u.password, "gabriel_moreira") == password)
                    {
                        match = true;
                        uLog = u;
                    }
                    else
                    {
                        if (AjustesDeUsuario.language == "EN")
                        {
                            MessageBox.Show("Incorrect password");
                        }
                        else if (AjustesDeUsuario.language == "ES")
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                }
                else
                {
                    if (AjustesDeUsuario.language == "EN")
                    {
                        MessageBox.Show("The user does no exist");
                    }
                    else if (AjustesDeUsuario.language == "ES")
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






        }

        bool EsEmail(String user , String value = "@"){

            return user.Contains(value);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formRegister = new Registro();
            formRegister.Show();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }


        Veridf
    }
}

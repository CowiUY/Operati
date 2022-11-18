using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BackOffice;

namespace Operati2
{
    public partial class Login : Form
    {
       bool match = false;
        

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
                var usuarios = Logica.DeserializeUsuarios(Logica.GetJson("SerialJson\\Usuarios.json"));
                int contador = 0;
                if (usuarios != null)
                {
                    foreach (var usuario in usuarios)
                    {
                        if (usuario.Nom_Usuario == user && usuario.password == password && usuario.nivelPermiso == 3)
                        {
                            Igualdad = true;
                            this.Visible = false;
                            Form boform = new BOForm();
                            boform.Show();
                            contador++;
                            MessageBox.Show("Sesión iniciada correctamente como: " + usuario.Nom_Usuario);
                        }
                    }
                    if (contador == 0)
                    {
                        MessageBox.Show("Usuario Incorrecto");
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


        
    }
}

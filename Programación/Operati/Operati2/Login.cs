using System;
using System.Windows.Forms;


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
            
            
                if (EsEmail(user))
                {
                    if (Logica.CheckSiExiste("Usuarios", "Email", user) == 1) {

                        var o = Logica.GetJson


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
    }
}

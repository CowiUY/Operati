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
                bool Igualdad = false;
                String user = txtUsuario.Text;
                String password = txtContraseña.Text;
                var usuarios = Logica.DeserializeUsuarios(Logica.GetJson("SerialJson\\Usuarios.json"));
                int contador = 0;
                if (usuarios != null)
                {
                    foreach (var usuario in usuarios)
                    {
                        if (usuario.UserID == user && usuario.password == password && usuario.nivelPermiso == 3)
                        {
                            Igualdad = true;
                            this.Visible = false;
                            contador++;
                            MessageBox.Show("Sesión iniciada correctamente como: "+usuario.UserID);
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

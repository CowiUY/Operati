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
    public partial class GestionDeUsuarios : Form
    {
        public GestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var usuarios = Logica.DeserializeUsuarios(Logica.GetJson("Usuarios.json"));
            Usuario newUser = new Usuario
            {
                UserID = txtUsuario.Text,
                mail = txtMail.Text,
                password = txtContraseña.Text,
                nivelPermiso = 1
            };
            usuarios.Add(newUser);
            Logica.SerializeUsuarios(usuarios);

        }
    }
}

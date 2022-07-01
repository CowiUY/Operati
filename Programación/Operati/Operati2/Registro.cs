using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operati2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtMailusuario.Text != "" && txtContraUsuario.Text != "" && txtNombreUsuario.Text != ""){

                    if (txtContraUsuario.Text == txtConfirmarContra.Text)
                    {

                        var usuarios = Logica.DeserializeUsuarios(Logica.GetJson("SerialJson\\Usuarios.json"));
                        Usuario newUsu = new Usuario();
                        newUsu.UserID = txtNombreUsuario.Text;
                        newUsu.mail = txtMailusuario.Text;

                                 newUsu.password = txtContraUsuario.Text;

                        newUsu.nivelPermiso = 3;
         
      
                        usuarios.Add(newUsu);
                        Logica.SerializeUsuarios(usuarios);
                        MessageBox.Show("Nuevo usuario creado CORRECTAMENTE");
                    }
                    else
                    {

                        MessageBox.Show("ERROR , Las contraseñas no son iguales , verifique de nuevo.");

                    }


                }

            }
        }
    }
}

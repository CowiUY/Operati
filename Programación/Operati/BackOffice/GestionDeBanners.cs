using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operati2;




namespace BackOffice
{
    public partial class GestionDeBanners : Form
    {
        public GestionDeBanners()
        {
            InitializeComponent();
        }
        Bitmap image = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(open.FileName);
                    PBimagen.Image = image;
                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestionDeBanners_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregoBanner_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIdBanner.Text != "" && txtLink.Text != "" && txtTitulo.Text != "" && image != null)
                {

                    var Banners = Logica.DeserializeBanners(Logica.GetJson("SerialJson\\Banners.json"));

                    Banner banner = new Banner();

                    banner.IdBanner = 0;
                    banner.Link = txtLink.Text;
                    banner.Titulo = txtTitulo.Text;
                    banner.Imagen = null;

                    Banners.Add(banner);
                    Logica.SerializeBanners(Banners);

                    MessageBox.Show("Banner añadido");


                }



            }

             catch (Exception ex){

                MessageBox.Show(ex.Message);

                }


















        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form apibanner = new APIPublicidad();
            apibanner.Show();
        }
    }
}
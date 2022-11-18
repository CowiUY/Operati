using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace BackOffice
{
    public partial class GestionDeBanners : Form
    {


        int index;
        bool modifica = false;


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
                    int ancho = image.Width;
                    int largo = image.Height;
                    if (ancho == 720 || largo == 90)
                    {

                        PBimagen.Image = image;


                    }
                    else {

                        image = null;

                        PBimagen.Image = null;

                        MessageBox.Show("CUIDADO , el banner debe ser especificamente del tamaño : 720 x 90");


                    }

                }

            }
            catch (Exception ex) {
                MessageBox.Show("ERROR , espere e intente nuevamente");
                MessageBox.Show(ex.Message);
            }
        }

        private void GestionDeBanners_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregoBanner_Click(object sender, EventArgs e)
        {

            if (modifica == false) {
                try
                {

                    if (txtLink.Text != "" && txtTitulo.Text != "" && image != null)
                    {

                       

                       string Titulo_Banner = txtTitulo.Text, Link_Banner = txtLink.Text;

                       Bitmap Imagen_Banner = new Bitmap(image);

                        Directory.CreateDirectory(@"C:\Operati\GDI\Banners");

                        string FilePath = $@"C:\\Operati\\GDI\\Banners\\{Titulo_Banner}.bmp";  // extension bitmap

                        using (MemoryStream memoria = new MemoryStream())
                        {

                            using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
                            {

                                Imagen_Banner.Save(memoria, ImageFormat.Bmp);

                                Imagen_Banner.Save(memoria, ImageFormat.Bmp);
                                byte[] bytes = memoria.ToArray();
                                fs.Write(bytes, 0, bytes.Length);

                            }






                            Logica.InsertBanner(Link_Banner, Titulo_Banner, FilePath);
                            MessageBox.Show("Banner creado correctamente");
                            














                            //METODO CON SOLO JSON  : 

                            /*
                            var Banners = Logica.DeserializeBanners(Logica.GetJson("SerialJson\\Banners.json"));

                            Banner banner = new Banner();

                            banner.IdBanner = 0;
                            banner.Link = txtLink.Text;
                            banner.Titulo = txtTitulo.Text;
                            banner.Imagen = null;

                            Banners.Add(banner);
                            Logica.SerializeBanners(Banners);

                            MessageBox.Show("Banner añadido"); 
                            */


                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }



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

            private void PBimagen_Click(object sender, EventArgs e)
            {

            }

            private void txtTitulo_TextChanged(object sender, EventArgs e)
            {

            }

            private void lblTitNom_Click(object sender, EventArgs e)
            {

            }

            private void lblLink_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                


            }
        
    }
}
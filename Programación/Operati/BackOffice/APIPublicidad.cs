using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BackOffice
{
    public partial class APIPublicidad : Form
    {
        String link = "";
        String imgPath = "";
        Random r = new Random();

        int b = 0;



        public APIPublicidad()
        {
            InitializeComponent();
            SetBanner();
        }


        private void IMGdelBanner_Click(object sender, EventArgs e)
        {
            var uu = new ProcessStartInfo(link)
            {

                UseShellExecute = true,
                Verb = "open"
            };

            Process.Start(uu);

        }



        private void SetBanner()
        {

            try
            {
                var banners = Logica.GetBanner(1, null);

                int i = r.Next(banners.Count());


                var banner = banners[i];

                link = banner.Link_Banner;

                imgPath = banner.Imagen_Banner;

                IMGdelBanner.Image = new Bitmap(imgPath);









            }
            catch {}











            //metodo de json:
            
           /* var banners = Logica.DeserializeBanners(Logica.GetJson("SerialJson\\Banners.json"));


            foreach (var banner in banners)
            {

                b++;
            }
            int i = a.Next(b);
            foreach (var banner in banners)
            {

                if (banner.IdBanner == i)
                {

                    link = banner.Link_Banner;
                    imgPath = banner.Imagen_Banner;

                }
            }


            pictureBox1.Image = Image.FromFile(imgPath);*/


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void APIPublicidad_Load(object sender, EventArgs e)
        {

        }
    }
}

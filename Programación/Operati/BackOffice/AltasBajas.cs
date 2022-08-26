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
    public partial class AltasBajas : Form
    {



        private DBConnect dbConnect;





        public AltasBajas()
        {
            InitializeComponent();

            dbConnect = new DBConnect();

        }

        private void AltasBajas_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            dbConnect.Insert();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbConnect.Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbConnect.Delete();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.Select();

            dgDisplay.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                dgDisplay.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            dbConnect.Backup();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            dbConnect.Restore();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int Count = dbConnect.Count();

            dgDisplay.Rows.Clear();
            int number = dgDisplay.Rows.Add();
            dgDisplay.Rows[number].Cells[0].Value = Count + "";

        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

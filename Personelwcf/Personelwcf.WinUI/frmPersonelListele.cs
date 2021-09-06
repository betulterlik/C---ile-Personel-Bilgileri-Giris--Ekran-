
using Personelwcf.WinUI.ServisimPersonel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Personelwcf.WinUI
{
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }
        Service1Client istemci = new Service1Client();
        private void lnkGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {

            dgvPersonelListele.DataSource = istemci.Listele();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {

        }
    }
}

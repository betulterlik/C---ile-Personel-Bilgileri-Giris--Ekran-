using Personelwcf.BLL;
using Personelwcf.DAL;
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
    public partial class frmDepartman : Form
    {
        public frmDepartman()
        {
            InitializeComponent();
        }
        DepartmanRepository dr = new DepartmanRepository();
        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            dr.DepartmanEkle(new Departman
            {
                DepartmanAdi = txtDepartman.Text
            });

            Listele();
            Temizle();
        }
        public void Listele()
        {
            dgvDeparmanlistele.DataSource = dr.DepartmanListele();
        }

        public void Temizle()
        {
            txtDepartman.Text = string.Empty;
        }

        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            int Secilen = Convert.ToInt32(dgvDeparmanlistele.SelectedRows[0].Cells[0].Value);
            dr.Sil(Secilen);
            Listele();
        }

        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personelwcf.DAL;
using Personelwcf.BLL;
using System.IO;
using System.Drawing.Imaging;

namespace Personelwcf.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PersonelRepository pr = new PersonelRepository();
        PersonelDBEntities db = new PersonelDBEntities();
        OpenFileDialog ofd_resim = new OpenFileDialog();


        MemoryStream ms = new MemoryStream();
        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);
            this.pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pr.Ekle(new tblPersonel
            {
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                DogumTarihi = dtpDT.Value,
                DepartmanId = (int)cmbDepartman.SelectedValue,
                ilId = (int)cmbil.SelectedValue,
                ilceId = (int)cmbilce.SelectedValue,
                Maas = Convert.ToDecimal(txtMaas.Text+500),
                ResimImage=photo,
                pResim = ofd_resim.FileName
            });
            Listele();
            Temizle();

        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
                if (item is PictureBox)
                {
                    PictureBox pb=(PictureBox)item;
                    pb.Image = null;
                }
            }
        }
        public void Doldur()
        {
            cmbil.DisplayMember = "ilAdi";
            cmbil.ValueMember = "ilId";
            cmbil.DataSource = db.iller.ToList();

            cmbDepartman.DisplayMember = "DepartmanAdi";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.DataSource = db.Departman.ToList();
        }
        public void Listele()
        {
            var sonuc = from p in db.tblPersonel
                        select new
                        {
                            p.PersonelId,
                            p.Adi,
                            p.Soyadi,
                            p.DogumTarihi,
                            p.iller.ilAdi,
                            p.ilceler.ilce,
                            p.Departman.DepartmanAdi,
                            p.Maas,
                            p.ResimImage,
                            p.pResim
                        };
            dgvListele.DataSource = sonuc.ToList();
        }
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = (int)cmbil.SelectedValue;
            cmbilce.DisplayMember = "ilce";
            cmbilce.ValueMember = "id";
            cmbilce.DataSource = db.ilceler.Where(x => x.ilId == Id).ToList();
        }
      
        private void btnYukle_Click(object sender, EventArgs e)
        {
            ofd_resim.Filter = "Personel Resmi(jpg)|*.jpg;";
            DialogResult sonuc = ofd_resim.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(ofd_resim.FileName);
                pbResim.Tag = System.IO.Path.GetExtension(ofd_resim.FileName);
                pbResim.Image.Save(ms, ImageFormat.Jpeg);
            }
          }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvListele.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
                pr.Sil(id);
                Listele();
            }
        }
        tblPersonel Guncelle;
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
           
           
           
            if (dgvListele.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
                Guncelle = pr.Sec(id);
                txtAd.Text = Guncelle.Adi;
                txtSoyad.Text = Guncelle.Soyadi;
                dtpDT.Value = Convert.ToDateTime(Guncelle.DogumTarihi);
                cmbil.SelectedValue= Guncelle.ilId;
                cmbilce.SelectedValue = Guncelle.ilceId;
                cmbDepartman.SelectedValue = Guncelle.DepartmanId;
                txtMaas.Text = Guncelle.Maas.ToString();
           

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvListele.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
                Guncelle = pr.Sec(id);
                Guncelle.Adi = txtAd.Text;
                Guncelle.Soyadi = txtSoyad.Text;
                Guncelle.Maas = Convert.ToDecimal(txtMaas.Text+500);
                Guncelle.ilId = Convert.ToInt32(cmbil.SelectedValue);
                Guncelle.ilceId = Convert.ToInt32(cmbilce.SelectedValue);
                Guncelle.DepartmanId =Convert.ToInt32(cmbDepartman.SelectedValue);
                Guncelle.DogumTarihi = dtpDT.Value;
                pr.guncelle(Guncelle);
          
            }
            Listele();
            Temizle();
        }

        private void lnkDepartman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDepartman frm = new frmDepartman();
            frm.Show();
            this.Hide();
        }

        private void lnkPersonel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.Show();
            this.Hide();
        }

        
    }
}

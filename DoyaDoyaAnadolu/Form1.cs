using DoyaDoyaAnadolu.DATA;
using Microsoft.EntityFrameworkCore;

namespace DoyaDoyaAnadolu
{
    public partial class Form1 : Form
    {
        TurkiyeContex db = new TurkiyeContex();
        public Form1()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            cboSehirler.DataSource = db.Cities.Include(s => s.Ozellikler).Include(s => s.Ozellikler).ToList();
        }

        private void cboSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir seciliSehir = (Sehir)cboSehirler.SelectedItem;

            if (seciliSehir == null)
            {
                lstOzellikler.DataSource = null;
            }
            else
            {
                lstOzellikler.DataSource = seciliSehir.Ozellikler.ToList();
            }
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            string ad = txtSehir.Text.Trim();
            if (ad == " ")
            {
                MessageBox.Show("Bir �ehir ad� girmelisiniz");
                return;
            }

            int plakano = (int)nudPlakaDegeri.Value;

            if (db.Cities.Any(s => s.Plaka == plakano))
            {
                MessageBox.Show("Bu plaka kullan�mda");
                return;
            }

            db.Add(new Sehir() { Plaka = plakano, Ad = ad });
            db.SaveChanges();
            Listele();
        }

        private void btnOzellikEkle_Click(object sender, EventArgs e)
        {
            if (cboSehirler.SelectedIndex == -1)
            {
                MessageBox.Show("�zellik eklemek i�in �ehir se�mediniz.");
                return;
            }

            Sehir seciliSehir = (Sehir)cboSehirler.SelectedItem;
            string ozellikAdi = txtOzellik.Text.Trim();

            if (seciliSehir == null)
            {
                MessageBox.Show("�nce bir �ehir se�iniz.");
                return;
            }

            if (ozellikAdi == "")
            {

                MessageBox.Show("Eklenecek �zl belirtiniz..");
                return;
            }
            seciliSehir.Ozellikler.Add(new Ozellik() { Ad = ozellikAdi, SehirId = seciliSehir.Plaka });
            OzellikleriListele();
            db.SaveChanges();
            txtOzellik.Clear();
         

            MessageBox.Show("�zellik ba�ar�yla eklenmi�tir.");

        }

        private void btnSeciliOzellikKaldir_Click(object sender, EventArgs e)
        {
            Ozellik seciliozellik = new Ozellik();

            seciliozellik = (Ozellik)lstOzellikler.SelectedItem;
            if (seciliozellik == null)
            {
                return;
            }

            db.Remove(seciliozellik);
            db.SaveChanges();

            //listb�x yenileme k�sm�
            OzellikleriListele();
            MessageBox.Show("Se�ilen �zellik kald�r�lm��t�r.");
        }

        private void OzellikleriListele()
        {
            Sehir sehir = (Sehir)cboSehirler.SelectedItem;
            lstOzellikler.DataSource = sehir.Ozellikler.ToList();
        }
    }
}
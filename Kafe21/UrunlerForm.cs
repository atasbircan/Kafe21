using Cafe21.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe21
{
    public partial class UrunlerForm : Form
    {
        KafeVeri db;
        BindingList<Urun> blUrunler;
        public UrunlerForm(KafeVeri kafeVeri)
        {
            db = kafeVeri;
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false;//otomatik sütun oluşturma
            blUrunler = new BindingList<Urun>(db.Urunler);
            dgvUrunler.DataSource = blUrunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            if (urunAd =="")
            {
                MessageBox.Show("Ürün adı giirniz");
                return;
            }

            if (duzenlenen == null) //EKLEME MODU
            {
                blUrunler.Add(new Urun()
                {
                    UrunAd=urunAd,
                    BirimFiyat=NudBirimFiyat.Value
                });
            }
            else //Düzenleme modu
            {
                duzenlenen.UrunAd = urunAd;
                duzenlenen.BirimFiyat = NudBirimFiyat.Value;
                blUrunler.ResetBindings();
            }

            formuResetle();
        }

        private void formuResetle()
        {
            txtUrunAd.Clear  ();
            NudBirimFiyat.Value = 0;
            btnIptal.Visible = false;
            btnEkle.Text = "EKLE";
            duzenlenen = null;
            txtUrunAd.Focus();

        }

        Urun duzenlenen;
        private void dgvUrunler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var satir = dgvUrunler.Rows[e.RowIndex];
            Urun urun = (Urun)satir.DataBoundItem;
            txtUrunAd.Text = urun.UrunAd;
            NudBirimFiyat.Value = urun.BirimFiyat;
            btnEkle.Text = "KAYDET";
            btnIptal.Show();
            duzenlenen = urun;
        }

        private void UrunlerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            var json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}

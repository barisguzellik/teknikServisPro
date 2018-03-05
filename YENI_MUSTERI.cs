﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServisPro
{
    public partial class YENI_MUSTERI : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public YENI_MUSTERI()
        {
            InitializeComponent();
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] col = {
                "CARI_KODU",
                "UNVANI",
                "CARI_TURU",
                "ADRES",
                "IL",
                "ILCE",
                "TELEFON",
                "CEP_TELEFON",
                "YETKILI_KISI",
                "VERGI_DAIRESI",
                "VERGI_NUMARASI",
                "GRUP_KODU",
                "OZEL_KODLAR_1",
                "OZEL_KODLAR_2",
                "OZEL_KODLAR_3",
                "OZEL_KODLAR_4",
                "OZEL_KODLAR_5",
                "FATURA_ADRESI"
            };
            string[] val = {
                txtCariKodu.Text,
                txtCariUnvani.Text,
                txtCariTuru.Text,
                txtAdres.Text,
                txtIl.Text,
                txtIlce.Text,
                txtTelefon.Text,
                txtCepTelefon.Text,
                txtYetkiliKisi.Text,
                txtVergiDairesi.Text,
                txtVergiNumarasi.Text,
                txtGrupKodu.Text,
                txtOzelKod1.Text,
                txtOzelKod2.Text,
                txtOzelKod3.Text,
                txtOzelKod4.Text,
                txtOzelKod5.Text,
                txtFaturaAdresi.Text

            };
            try
            {
                helper.setSqlCommandForInsertWithParameters("CARI_KARTLAR_V2", col, val);
                MessageBox.Show("Cari eklendi...", "Cari");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Cari");
            }
        }
        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YENI_MUSTERI_Load(object sender, EventArgs e)
        {

        }
    }
}

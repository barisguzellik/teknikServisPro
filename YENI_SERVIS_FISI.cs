using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServisPro
{
    public partial class YENI_SERVIS_FISI : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public YENI_SERVIS_FISI()
        {
            InitializeComponent();
        }
        public int ITEM_ID = 0;
        private void YENI_SERVIS_FISI_Load(object sender, EventArgs e)
        {
            if (ITEM_ID != 0)
            {
                fATURAYISİLToolStripMenuItem.Visible = true;

                DataTable dt = helper.getDataTable("SELECT*FROM SERVIS_FISLERI WHERE SERVIS_ID=" + ITEM_ID + "");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        txtCariID.Text = row["MUSTERI_ID"].ToString();
                        txtTarih.Text = row["FIS_TARIHI"].ToString();
                        txtCihazImei.Text = row["CIHAZ_IMEI"].ToString();
                        txtCihazMarkasi.Text = row["CIHAZ_MARKASI"].ToString();
                        txtDegistirilenParcalar.Text = row["DEGISTIRILEN_PARCALAR"].ToString();
                        txtDurum.Text = row["DURUMU"].ToString();
                        txtFisNumarasi.Text = row["FIS_NUMARASI"].ToString();
                        txtKalan.Text = row["KALAN"].ToString();
                        txtOdenen.Text = row["ODENEN"].ToString();
                        txtServisAciklamasi.Text = row["SERVIS_ACIKLAMASI"].ToString();
                        txtTeslimAlan.Text = row["TESLIM_ALAN"].ToString();
                        txtTeslimAlinanParcalar.Text = row["TESLIM_ALINAN_PARCALAR"].ToString();
                        txtTeslimEden.Text = row["TESLIM_EDEN"].ToString();
                        txtTutar.Text = row["TUTAR"].ToString();

                    }
                }
                else
                {
                    fATURAYISİLToolStripMenuItem.Visible = false;
                }
            }
        }

        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUSTERI_SEC frm = new MUSTERI_SEC();
            frm.ShowDialog();
            txtCariID.Text = frm.lastSelectedUser.ToString();
        }

        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        private void txtCariID_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = helper.getDataTable("SELECT TOP 1 * FROM CARI_KARTLAR_V2 WHERE ID=" + txtCariID.Text + "");
            if (dt.Rows.Count == 1)
            {
                txtAdSoyad.Text = dt.Rows[0]["UNVANI"].ToString();
                txtCepTelefon.Text = dt.Rows[0]["CEP_TELEFON"].ToString();
                txtTelefon.Text = dt.Rows[0]["TELEFON"].ToString();
                txtAdres.Text = dt.Rows[0]["ADRES"].ToString();
            }
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ITEM_ID == 0)
            {
                newRecord();

                MessageBox.Show("Fiş kaydedildi...", "Servis Fişi");
            }
            else
            {
                updateRecord();
                MessageBox.Show("Fiş kaydedildi...", "Servis Fişi");
            }
        }
        public void newRecord()
        {
            string[] customerCol =
                {
                    "UNVANI",
                    "ADRES",
                    "TELEFON",
                    "CEP_TELEFON"
                };

            string[] customerVal =
            {
                    txtAdSoyad.Text,
                    txtAdres.Text,
                    txtTelefon.Text,
                    txtCepTelefon.Text
                };

            if (txtCariID.Text == "0")
            {
                helper.setSqlCommandForInsertWithParameters("CARI_KARTLAR_V2", customerCol, customerVal);

                int lastCustomerID = int.Parse(helper.getTableColumnData("SELECT TOP 1 ID FROM CARI_KARTLAR_V2 ORDER BY ID DESC", "ID"));

                txtCariID.Text = lastCustomerID.ToString();
            }
            else
            {
                helper.setSqlCommandForUpdateWithParameters("CARI_KARTLAR_V2", customerCol, customerVal, "ID", txtCariID.Text);

            }

            DateTime dtTime = Convert.ToDateTime(txtTarih.Text);
            string dateFormat = dtTime.Year + "-" + dtTime.Month + "-" + dtTime.Day;

            string[] COLS =
            {
                "MUSTERI_ID",
                "CIHAZ_MARKASI",
                "SERVIS_ACIKLAMASI",
                "CIHAZ_IMEI",
                "TESLIM_ALINAN_PARCALAR",
                "TUTAR",
                "ODENEN",
                "KALAN",
                "FIS_NUMARASI",
                "FIS_TARIHI",
                "KAYIT_TARIHI",
                "DUZENLENME_TARIHI",
                "TESLIM_ALAN",
                "TESLIM_EDEN",
                "DURUMU",
                "DEGISTIRILEN_PARCALAR"
            };

            string[] VALS =
            {
                txtCariID.Text,
                txtCihazMarkasi.Text,
                txtServisAciklamasi.Text,
                txtCihazImei.Text,
                txtTeslimAlinanParcalar.Text,
                txtTutar.Text,
                txtOdenen.Text,
                txtKalan.Text,
                txtFisNumarasi.Text,
                dateFormat,
                DateTime.Now.ToString(),
                DateTime.Now.ToString(),
                txtTeslimAlan.Text,
                txtTeslimEden.Text,
                txtDurum.Text,
                txtDegistirilenParcalar.Text
            };

            helper.setSqlCommandForInsertWithParameters("SERVIS_FISLERI", COLS, VALS);

            int lastID = int.Parse(helper.getTableColumnData("SELECT TOP 1 SERVIS_ID FROM SERVIS_FISLERI ORDER BY SERVIS_ID DESC", "SERVIS_ID"));

            ITEM_ID = lastID;

            //this.Close();
        }
        public void updateRecord()
        {

            string[] customerCol =
                {
                    "UNVANI",
                    "ADRES",
                    "TELEFON",
                    "CEP_TELEFON"
                };

            string[] customerVal =
            {
                    txtAdSoyad.Text,
                    txtAdres.Text,
                    txtTelefon.Text,
                    txtCepTelefon.Text
                };

            helper.setSqlCommandForUpdateWithParameters("CARI_KARTLAR_V2", customerCol, customerVal, "ID", txtCariID.Text);


            DateTime dtTime = Convert.ToDateTime(txtTarih.Text);
            string dateFormat = dtTime.Year + "-" + dtTime.Month + "-" + dtTime.Day;

            string[] COLS =
            {
                "MUSTERI_ID",
                "CIHAZ_MARKASI",
                "SERVIS_ACIKLAMASI",
                "CIHAZ_IMEI",
                "TESLIM_ALINAN_PARCALAR",
                "TUTAR",
                "ODENEN",
                "KALAN",
                "FIS_NUMARASI",
                "FIS_TARIHI",
                "DUZENLENME_TARIHI",
                "TESLIM_ALAN",
                "TESLIM_EDEN",
                "DURUMU",
                "DEGISTIRILEN_PARCALAR"
            };

            string[] VALS =
            {
                txtCariID.Text,
                txtCihazMarkasi.Text,
                txtServisAciklamasi.Text,
                txtCihazImei.Text,
                txtTeslimAlinanParcalar.Text,
                txtTutar.Text,
                txtOdenen.Text,
                txtKalan.Text,
                txtFisNumarasi.Text,
                dateFormat,
                DateTime.Now.ToString(),
                txtTeslimAlan.Text,
                txtTeslimEden.Text,
                txtDurum.Text,
                txtDegistirilenParcalar.Text
            };

            helper.setSqlCommandForUpdateWithParameters("SERVIS_FISLERI", COLS, VALS, "SERVIS_ID", ITEM_ID.ToString());
            //this.Close();
        }
        private void fATURAYISİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Belge silinecek onaylıyor musunuz?", "Belge Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                helper.setSqlCommand("DELETE FROM SERVIS_FISLERI WHERE SERVIS_ID=" + ITEM_ID + "");

                this.Close();
            }
        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
        public void calculateTotal()
        {
            try
            {
                decimal tutar = decimal.Parse(txtTutar.Text);
                decimal odenen = decimal.Parse(txtOdenen.Text);

                txtKalan.Text = (tutar - odenen).ToString();
            }
            catch { }
        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void fİŞİYAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(Application.StartupPath.ToString() + "/print.html");
            */

            StreamReader sr = new StreamReader(Application.StartupPath.ToString() + "/print.html");
            string s = sr.ReadToEnd();
            s = s.Replace("[AD_SOYAD]", txtAdSoyad.Text);
            s = s.Replace("[FIS_TARIHI]", txtTarih.Text);
            s = s.Replace("[ADRES]", txtAdres.Text);
            s = s.Replace("[TELEFON]", txtTelefon.Text);
            s = s.Replace("[CEP_TELEFON]", txtCepTelefon.Text);
            s = s.Replace("[CIHAZ_MARKASI]", txtCihazMarkasi.Text);
            s = s.Replace("[CIHAZ_IMEI]", txtCihazImei.Text);
            s = s.Replace("[TESLIM_ALINAN_PARCALAR]", txtTeslimAlinanParcalar.Text);
            s = s.Replace("[DEGISTIRILEN_PARCALAR]", txtDegistirilenParcalar.Text);
            s = s.Replace("[TESLIM_ALAN]", txtTeslimAlan.Text);
            s = s.Replace("[TESLIM_EDEN]", txtTeslimEden.Text);
            s = s.Replace("[TUTAR]", txtTutar.Text);
            s = s.Replace("[KALAN]", txtKalan.Text);
            s = s.Replace("[SERVIS_ACIKLAMASI]", txtServisAciklamasi.Text);
            sr.Close();

            string fileName = generateName();

            File.WriteAllText(Application.StartupPath.ToString() + "/print/" + fileName + "print.html", s);

            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + "/print/" + fileName + "print.html");
        }

        public string generateName()
        {
            string str = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            return str;
        }
    }

}

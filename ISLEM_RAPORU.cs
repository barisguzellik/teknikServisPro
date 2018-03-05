using System;
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
    public partial class ISLEM_RAPORU : Form
    {
        public ISLEM_RAPORU()
        {
            InitializeComponent();
        }
        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        commonClass commonClass = new commonClass();
        DefaultStyles styles = new DefaultStyles();

        private void ISLEM_RAPORU_Load(object sender, EventArgs e)
        {
            styles.dataGridStyle(dataGridView1);

            processCommand();
        }
        public string COLS = "SERVIS_ID,UNVANI,FIS_TARIHI,FIS_NUMARASI,DURUMU,CIHAZ_MARKASI,SERVIS_ACIKLAMASI,TUTAR,ODENEN,KALAN,KAYIT_TARIHI,DUZENLENME_TARIHI";
        public void processCommand()
        {
            DateTime dtTime1 = Convert.ToDateTime(date1.Text);
            DateTime dtTime2 = Convert.ToDateTime(date2.Text);

            string dateFormat1 = dtTime1.Year + "-" + dtTime1.Month + "-" + dtTime1.Day;
            string dateFormat2 = dtTime2.Year + "-" + dtTime2.Month + "-" + dtTime2.Day;
          
            dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM SERVIS_FISLERI INNER JOIN CARI_KARTLAR_V2 ON SERVIS_FISLERI.MUSTERI_ID=CARI_KARTLAR_V2.ID  WHERE FIS_TARIHI BETWEEN CONVERT(datetime, '" + dateFormat1 + "') AND CONVERT(datetime, '" + dateFormat2 + "') ORDER BY SERVIS_ID DESC");

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            styles.dataGridFormatNumber(dataGridView1);

            double drTutar = 0;
            double drOdenen = 0;
            double drKalan = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                double tutar = double.Parse(dr.Cells["TUTAR"].Value.ToString());
                double odenen = double.Parse(dr.Cells["ODENEN"].Value.ToString());
                double kalan = double.Parse(dr.Cells["KALAN"].Value.ToString());
                drTutar += tutar;
                drOdenen += odenen;
                drKalan += kalan;
            }

            sumIskonto.Text = "TUTAR : " + drTutar.ToString("N2");
            sumKdv.Text = "ÖDENEN : " + drOdenen.ToString("N2");
            sumGenelToplam.Text = "KALAN : " + drKalan.ToString("N2");
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            processCommand();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            processCommand();
        }
    }
}

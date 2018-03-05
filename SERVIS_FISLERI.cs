using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServisPro
{
    public partial class SERVIS_FISLERI : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public SERVIS_FISLERI()
        {
            InitializeComponent();
        }
        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        DefaultStyles styleHelper = new DefaultStyles();
        private void SERVIS_FISLERI_Load(object sender, EventArgs e)
        {
            styleHelper.dataGridStyle(dataGridView1);
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Thread thread = new Thread(new ThreadStart(getDefault));
            thread.Start();

            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            if (e.KeyCode == Keys.F5)
            {
                getDefault();
            }

        }
        public string COLS = "SERVIS_ID,UNVANI,TELEFON,CEP_TELEFON,FIS_TARIHI,FIS_NUMARASI,DURUMU,CIHAZ_MARKASI,SERVIS_ACIKLAMASI,TUTAR,ODENEN,KALAN,KAYIT_TARIHI,DUZENLENME_TARIHI";
        public void getDefault()
        {
            DateTime dtTime1 = Convert.ToDateTime(date1.Text);
            DateTime dtTime2 = Convert.ToDateTime(date2.Text);

            string dateFormat1 = dtTime1.Year + "-" + dtTime1.Month + "-" + dtTime1.Day;
            string dateFormat2 = dtTime2.Year + "-" + dtTime2.Month + "-" + dtTime2.Day;

            this.Invoke((MethodInvoker)delegate
            {
                this.Cursor = Cursors.WaitCursor;
                dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM SERVIS_FISLERI INNER JOIN CARI_KARTLAR_V2 ON SERVIS_FISLERI.MUSTERI_ID=CARI_KARTLAR_V2.ID WHERE FIS_TARIHI BETWEEN CONVERT(datetime, '" + dateFormat1 + "') AND CONVERT(datetime, '" + dateFormat2 + "') ORDER BY SERVIS_ID DESC");
                this.Cursor = Cursors.Default;
            });
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            styleHelper.dataGridReName(dataGridView1);
            styleHelper.dataGridFormatNumber(dataGridView1);

            styleHelper.dataGridColWidth(dataGridView1, dataGridView1.Tag.ToString());

            dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(styleHelper.testFunc);


            double drTutar = 0;
            double drOdenen = 0;
            double drKalan = 0;
            int drRecord = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                double tutar = double.Parse(dr.Cells["TUTAR"].Value.ToString());
                double odenen = double.Parse(dr.Cells["ODENEN"].Value.ToString());
                double kalan = double.Parse(dr.Cells["KALAN"].Value.ToString());
                drTutar += tutar;
                drOdenen += odenen;
                drKalan += kalan;
                drRecord++;
            }

            sumIskonto.Text ="TUTAR : " + drTutar.ToString("N2");
            sumKdv.Text = "ÖDENEN : " + drOdenen.ToString("N2");
            sumGenelToplam.Text = "KALAN : " + drKalan.ToString("N2");
            sumRecord.Text = "KAYIT : " + drRecord.ToString();
        }
        
        public void searchProcess2()
        {
            DateTime dtTime1 = Convert.ToDateTime(date1.Text);
            DateTime dtTime2 = Convert.ToDateTime(date2.Text);

            string dateFormat1 = dtTime1.Year + "-" + dtTime1.Month + "-" + dtTime1.Day;
            string dateFormat2 = dtTime2.Year + "-" + dtTime2.Month + "-" + dtTime2.Day;


            string query = "1=1 ";
            query += " AND (FIS_TARIHI BETWEEN CONVERT(datetime, '" + dateFormat1 + "') AND CONVERT(datetime, '" + dateFormat2 + "'))";
            //string[] likeColumns = helper.getColumnsNames("CARI_KARTLAR_V2");
            string[] likeColumns =
           {
                "FIS_NUMARASI",
                "CIHAZ_MARKASI",
                "CIHAZ_IMEI",
                "TESLIM_ALAN",
                "TESLIM_EDEN",
                "SERVIS_ACIKLAMASI",
                "DURUMU",
                "UNVANI",
                "TELEFON",
                "CEP_TELEFON",
                "VERGI_NUMARASI",
                "FIS_TARIHI",
                "KAYIT_TARIHI",
                "DUZENLENME_TARIHI"
            };
            if (likeColumns.Length > 0)
            {
                for (int i = 0; i < likeColumns.Length; i++)
                {
                    if (i == 0)
                    {
                        query += " AND (" + likeColumns[i] + " LIKE N'%" + toolStripTextBox1.Text + "%' ";
                    }
                    else
                    {
                        query += " OR " + likeColumns[i] + " LIKE N'%" + toolStripTextBox1.Text + "%' ";
                    }
                }
            }
            query += " ) ";
            

            dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM SERVIS_FISLERI INNER JOIN CARI_KARTLAR_V2 ON SERVIS_FISLERI.MUSTERI_ID=CARI_KARTLAR_V2.ID WHERE " + query);

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                searchProcess2();

            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchProcess2();
        }

        private void yENİSTOKKARTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YENI_SERVIS_FISI frm = new YENI_SERVIS_FISI();
            frm.ShowDialog();
            getDefault();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            YENI_SERVIS_FISI frm = new YENI_SERVIS_FISI();
            frm.ITEM_ID =int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frm.ShowDialog();

           // getDefault();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Length == 0)
            {
                getDefault();
            }
            else
            {
                searchProcess2();
            }
            
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Length == 0)
            {
                getDefault();
            }
            else
            {
                searchProcess2();
            }
        }

        private void fİŞEGİTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YENI_SERVIS_FISI frm = new YENI_SERVIS_FISI();
            frm.ITEM_ID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void iÇERİĞİSÜZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            toolStripTextBox1.Text = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
        }
    }
}

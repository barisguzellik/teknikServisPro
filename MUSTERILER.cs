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
    public partial class MUSTERILER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public MUSTERILER()
        {
            InitializeComponent();
        }
        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        DefaultStyles styleHelper = new DefaultStyles();
        private void MUSTERILER_Load(object sender, EventArgs e)
        {
            styleHelper.dataGridStyle(dataGridView2);
            styleHelper.dataGridStyle(dataGridView1);

            
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


        public string COLS = "ID,CARI_KODU,UNVANI,CARI_TURU,TELEFON,CEP_TELEFON";
        public void getDefault()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Cursor = Cursors.WaitCursor;
                dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM CARI_KARTLAR_V2");
                this.Cursor = Cursors.Default;
            });
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            styleHelper.dataGridReName(dataGridView1);
            styleHelper.dataGridFormatNumber(dataGridView1);

            styleHelper.dataGridColWidth(dataGridView1, dataGridView1.Tag.ToString());

            dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(styleHelper.testFunc);

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                searchProcess2();

            }
        }
        public void searchProcess2()
        {
            string query = "1=1 ";
            //string[] likeColumns = helper.getColumnsNames("CARI_KARTLAR_V2");
            string[] likeColumns =
           {
                "CARI_KODU",
                "UNVANI",
                "TELEFON",
                "CEP_TELEFON",
                "YETKILI_KISI",
                "CARI_TURU",
                "VERGI_NUMARASI"
            };
            if (likeColumns.Length > 0)
            {
                for (int i = 0; i < likeColumns.Length; i++)
                {
                    if (i == 0)
                    {
                        query += " AND " + likeColumns[i] + " LIKE N'%" + toolStripTextBox1.Text + "%' ";
                    }
                    else
                    {
                        query += " OR " + likeColumns[i] + " LIKE N'%" + toolStripTextBox1.Text + "%' ";
                    }
                }
            }


            dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM CARI_KARTLAR_V2 WHERE " + query);

        }

        private void yENİSTOKKARTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YENI_MUSTERI frm = new YENI_MUSTERI();
            commonClass.openFormOnForm(frm);
            //getDefault();
        }
        commonClass commonClass = new commonClass();

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MUSTERI_DUZENLE frm = new MUSTERI_DUZENLE();
            frm.ITEM_ID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            frm.ShowDialog();
            //getDefault();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchProcess2();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = helper.getDataTable("SELECT * FROM SERVIS_FISLERI WHERE MUSTERI_ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ORDER BY SERVIS_ID DESC");
            }
            catch { }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            YENI_SERVIS_FISI frm = new YENI_SERVIS_FISI();
            frm.ITEM_ID = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            styleHelper.dataGridReName(dataGridView2);
            styleHelper.dataGridFormatNumber(dataGridView2);

            styleHelper.dataGridColWidth(dataGridView2, dataGridView2.Tag.ToString());

            dataGridView2.ColumnWidthChanged += new DataGridViewColumnEventHandler(styleHelper.testFunc);


            double drTutar = 0;
            double drOdenen = 0;
            double drKalan = 0;
            foreach (DataGridViewRow dr in dataGridView2.Rows)
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
    }
}

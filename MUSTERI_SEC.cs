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
    public partial class MUSTERI_SEC : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public MUSTERI_SEC()
        {
            InitializeComponent();
        }
        carkSQLHelper.carkMsSQLHelper helper = new carkSQLHelper.carkMsSQLHelper();
        DefaultStyles styleHelper = new DefaultStyles();

        public string COLS = "ID,CARI_KODU,UNVANI,CARI_TURU,TELEFON,CEP_TELEFON";
        private void MUSTERI_SEC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = toolStripTextBox1.Control;
            styleHelper.dataGridStyle(dataGridView1);
            getDefault();
        }
        public int lastSelectedUser = 0;
        public void getDefault()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Cursor = Cursors.WaitCursor;
                dataGridView1.DataSource = helper.getDataTable("SELECT " + COLS + " FROM CARI_KARTLAR_V2");
                this.Cursor = Cursors.Default;
            });
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchProcess2();

                if (dataGridView1.Rows.Count == 1)
                {
                    lastSelectedUser = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    this.Close();
                }
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
                "YETKILI_KISI"
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

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                toolStripTextBox1.Text += e.KeyChar;
            }
            if (e.KeyChar == (Char)Keys.Space)
            {
                toolStripTextBox1.Text += " ";
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                toolStripTextBox1.Text = "";
            }

            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (toolStripTextBox1.Text.Length > 0)
                {
                    toolStripTextBox1.Text = toolStripTextBox1.Text.Remove(toolStripTextBox1.Text.Length - 1, 1);
                }

            }
            if (e.KeyChar == (Char)Keys.Enter)
            {
                searchProcess2();

            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchProcess2();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            lastSelectedUser = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }
    }
}

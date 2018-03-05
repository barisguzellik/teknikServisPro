using ComponentFactory.Krypton.Navigator;
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
    public partial class MDI_FORM : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
       

        public MDI_FORM()
        {
            InitializeComponent();
        }


        private void MDI_FORM_Load(object sender, EventArgs e)
        {

        }
        commonClass commonClass = new commonClass();
        public void openTabPanes(Form frm, string name)
        {
            frm.TopLevel = false;
            //TabPage tp = new TabPage();
            KryptonPage tp = new KryptonPage();
            tp.Width = tabControl1.Width;
            tp.Height = tabControl1.Height - 20;
            tp.Text = frm.Text;
            tp.Name = name;

            tabControl1.Pages.Add(tp);
            frm.Parent = tp;
            
            commonClass.openInTabs(frm);
            tabControl1.SelectedPage = tp;

            /*if (commonClass.checkOpened(frm))
            {
                try
                {
                    // tabControl1.SelectTab(name);
                }
                catch
                {
                    frm.TopLevel = false;
                    KryptonPage tp = new KryptonPage();
                    tp.Width = tabControl1.Width;
                    tp.Height = tabControl1.Height;
                    tp.Text = frm.Text;
                    tp.Name = name;
                    //tabControl1.TabPages.Add(tp);
                    tabControl1.Pages.Add(tp);
                    frm.Parent = tp;
                    commonClass.openInTabs(frm);
                    tabControl1.SelectedPage = tp;
                }

            }
            else
            {
                
            }*/
        }

        public void openTabPanesTwo(Form frm, string name)
        {

            frm.TopLevel = false;
            KryptonPage tp = new KryptonPage();
            tp.Width = tabControl1.Width;
            tp.Height = tabControl1.Height - 20;
            tp.Text = frm.Text;
            tp.Name = name;
            tabControl1.Pages.Add(tp);
            frm.Parent = tp;
            commonClass.openInTabs(frm);
            tabControl1.SelectedPage = tp;
        }
        private void kryptonRibbonGroupButton4_Click(object sender, EventArgs e)
        {
            KULLANICILAR frm = new KULLANICILAR();
            openTabPanes(frm, "KULLANICILAR");
        }

        private void kryptonRibbonGroupButton5_Click(object sender, EventArgs e)
        {
            GIRIS frm = new GIRIS();
            frm.Show();
            this.Close();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = tabControl1.SelectedPage.Name;

            //commonClass.closeForm(name);


            tabControl1.Pages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void tümSekmeleriKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonClass.closeAllForm();
            tabControl1.Pages.Clear();
        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {
            MUSTERILER frm = new MUSTERILER();
            openTabPanesTwo(frm, "MUSTERILER");

        }

        private void kryptonRibbonGroupButton6_Click(object sender, EventArgs e)
        {
            YENI_SERVIS_FISI frm = new YENI_SERVIS_FISI();
            //frm.Show();
            openTabPanesTwo(frm, "YENI_SERVIS_FISI");
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            SERVIS_FISLERI frm = new SERVIS_FISLERI();
            openTabPanesTwo(frm, "SERVIS_FISLERI");
        }

        private void kryptonRibbonGroupButton8_Click(object sender, EventArgs e)
        {
            ISLEM_RAPORU frm = new ISLEM_RAPORU();
            openTabPanesTwo(frm, "ISLEM_RAPORU");
        }
    }
}

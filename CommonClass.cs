using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServisPro
{
    class commonClass
    {
        public void openFormOnMdi(Form frm, Form mdi)
        {
            frm.MdiParent = mdi;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
            frm.Show();
        }
        public void openInTabs(Form frm)
        {

            frm.WindowState = FormWindowState.Maximized;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        public void openFormOnForm(Form frm)
        {
            frm.BringToFront();
            frm.ShowDialog();
        }
        public bool checkOpened(Form name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public void closeForm(string name)
        {
            FormCollection fc = Application.OpenForms;

            try
            {
                foreach (Form frm in fc)
                {
                    if (frm.Name == name)
                    {
                        frm.Close();

                    }
                }
            }
            catch { }
        }

        public void closeAllForm()
        {
            FormCollection fc = Application.OpenForms;

            try
            {
                foreach (Form frm in fc)
                {
                    if (frm.Name != "MDI_FORM" && frm.Name != "GIRIS")
                    {
                        frm.Close();
                    }


                }
            }
            catch { }
        }
    }
}

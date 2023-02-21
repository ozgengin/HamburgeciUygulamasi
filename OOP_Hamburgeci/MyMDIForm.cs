using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgeci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 23;
            this.Height = childForm.Height + 70;

            bool durum = false;

            foreach(Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                    form.Close();
            }

            if(durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void msSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void msSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void msMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void msEkstraMalEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void MyMDIForm_Load(object sender, EventArgs e)
        {

        }
    }
}

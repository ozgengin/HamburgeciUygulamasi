using OOP_Hamburgeci.Entities;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach(Siparis siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach(EkstraMalzeme ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzemeGeliri += ekstra.EkstraFiyati;
                }

                satisAdedi += siparis.Adedi;
                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblToplamSipSayisi.Text= lbxTumSiparisler.Items.Count.ToString();
            lblSatilanUrunSayisi.Text = satisAdedi.ToString();
        }
    }
}

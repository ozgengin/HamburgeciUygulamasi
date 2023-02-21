using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburgeci.Entities;


namespace OOP_Hamburgeci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new EkstraMalzeme { EkstraAdi = txtMalzemeAdi.Text, EkstraFiyati = nmrMalzemeFiyati.Value });

            Metotlar.Temizle(this.Controls);

            MessageBox.Show("Ekstra malzeme başarıyla eklendi.");
        }
    }
}

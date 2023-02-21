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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Form1.menuler.Add(new Menu{ MenuAdi = txtMenuAdi.Text, MenuFiyati=nmrMenuFiyati.Value});

            //Ekleme işleminden sonra Temizle() metodu çağırılsın.
            Metotlar.Temizle(this.Controls);

            MessageBox.Show("Menü başarıyla eklendi");
        }
    }
}

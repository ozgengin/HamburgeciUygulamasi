using OOP_Hamburgeci.Entities;

namespace OOP_Hamburgeci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu { MenuAdi = "Big King", MenuFiyati = 50.75M },
            new Menu { MenuAdi = "Whopper", MenuFiyati = 50.75M },
            new Menu { MenuAdi = "King Chicken", MenuFiyati = 50.75M },
            new Menu { MenuAdi = "Chicken Royal", MenuFiyati = 50.75M },
            new Menu { MenuAdi = "KöfteBurger", MenuFiyati = 50.75M },
        };

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi="Ketçap", EkstraFiyati=1.00M},
            new EkstraMalzeme{EkstraAdi="Mayonez", EkstraFiyati=1.00M},
            new EkstraMalzeme{EkstraAdi="Ranch", EkstraFiyati=1.00M},
            new EkstraMalzeme{EkstraAdi="BBQ", EkstraFiyati=1.00M}



        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Menu item in menuler)
            {
                cbMenuSec.Items.Add(item);
            }

            foreach(EkstraMalzeme item in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }

            foreach (Siparis item in mevcutSiparisler)
                lbxSirapisler.Items.Add(item); //Eğer form açıldığında tamamlanmamış sipariş (mevcut) varsa listboxa ekle.

            rdoKucuk.Checked = true;

            cbMenuSec.SelectedIndex = 0; //Açılışta ilk eleman seçili gelsin.

            TutarHesapla();
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < lbxSirapisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSirapisler.Items[i];
                toplamTutar+=gelenSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cbMenuSec.SelectedItem;

            if (rdoKucuk.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Orta;
            else
                yeniSiparis.Boyutu = BoyutEnum.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();

            foreach(CheckBox kontrol in flpEkstraMalzemeler.Controls)
            {
                if (kontrol.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag);//flp'nin kontrollerinden 
                //her birinin Tag propertysinin bir kopyasını aldık ve Siparis nesnesine oluştursuğumuz
                //EkstraMalzemeleri listesine ekledik.
            }

            yeniSiparis.Adedi = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla();

            mevcutSiparisler.Add(yeniSiparis);
            lbxSirapisler.Items.Add(yeniSiparis);
            //tumSiparisler.Add(yeniSiparis);

            TutarHesapla();

            Metotlar.Temizle(this.Controls); // Bu formun kontrollerini ilgili metoda gönder.

        }

        private void btnSirapisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam sipariş tutarınız: " + TutarHesapla().ToString("C2") + "\n Satın Alma İşlemini Onaylıyor Musunuz?","Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dr== DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler); //Sipariş tamamlandığında mevcut siparişleri tüm siparişlere ekler.
                lbxSirapisler.Items.Clear();
                mevcutSiparisler.Clear(); //Geçici olarak tuttuğumuz bu listeyi de temizler.
                TutarHesapla(); //labeldaki tutar değerini yeniden hesaplamak için 0 olması için.
                MessageBox.Show("Siparişiniz tamamlandı.");
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi");
            }
        }

        private void cbMenuSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
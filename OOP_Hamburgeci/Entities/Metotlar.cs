using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace OOP_Hamburgeci.Entities
{
    public class Metotlar
    {
        //To do: Temizle isimli bir metot oluşturup formlardadaki gerekli yerde çağırıldığında 
        //gerekli temizleme işlemini ypatırınız.

        //Sipariş sayfası
        //Menüde cb'de ilk elemanı seçili hale gelecek.
        //boyur rb küçük olan seçili hale gelecek.
        //flpdeki chk checked kaldıaralcak.
        //Adet numupdowndaki değer min değere eşitlenecek.

        //Menü ekle sayfası
        //İşlem başarılı olursa menü adı textbox temizlenecek
        //işlem başarılı olursa menü fiyatı numupdowndaki min değre eşitlenecek.

        //EkstraMalzeme sayfası
        //İşlem başarılı olursa menü adı textbox temizlenecek
        //işlem başarılı olursa menü fiyatı numupdowndaki min değre eşitlenecek.

        //Not-1: İlgili metodu instance almdan çağıracak şekilde yazınız.
        //Not-2: Metot parametre olarak Control Collection tipinde bir parametre alsın.

        public static void Temizle(ControlCollection formunKontrolleri)
        {
            foreach (Control item in formunKontrolleri)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                else if(item is RadioButton)
                {
                    if (((RadioButton)item).Name.Contains("Kucuk"))
                        ((RadioButton)item).Checked = true;
                }

                else if (item is CheckBox)
                {
                    //if (((CheckBox)item).Name.Contains("chk"))
                        ((CheckBox)item).Checked = false;
                }

                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
            }



        }
    }
}

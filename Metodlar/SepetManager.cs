using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {   //naming convention fonksiyon isimlerinid oğru yazma
        public void Ekle(Urun urun) //parametre aldı
        {
            Console.WriteLine("Tebrikler sepete eklendi:" + urun.Adi);
        }
        //hatalı kullanım
        public void Ekle2(string urunAdi,string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("tebrikler sepete eklendi:" + urunAdi);
        }
    }
}

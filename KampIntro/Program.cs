using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //do not repeat yourself bu yüzden değişken oluştururuz.
            //kategorietkieti aslında bir değer tutucudur
            string kategoriEtiketi = "Kategori";
            int ogrenciSsayisi = 32000;  //tam sayılar
            double faizOrani = 1.45;  //ondalıklı sayılar
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları  Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            } 

            Console.WriteLine(kategoriEtiketi);

        }
    }
}

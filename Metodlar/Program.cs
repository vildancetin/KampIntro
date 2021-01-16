using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type safe -tip güvenli sistemerl c#,java gibiler ne ile çalışacağını bilmek isterler
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------------Metodlar-----------");
            SepetManager sepetManager = new SepetManager(); //instance-class örneği oluşturmak
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //tek tek eklendi metoda sonradan farklı bir parametre ekleyince ekle2 fonk çağırdığın tüm sayfalarda
            //patlar ve hepsinde değiştirmen gerekir ama stokadedini classa property olarak eklersem bir sıkıntı olmaz bu yüzden
            //classlar kullanırız ve buna encapsülation denir.
            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "yeşil db karpuzu", 12,8);

        }
    }
}

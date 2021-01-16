using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "vildan";
            int yas = 22;
            //3 farklı kurs tanımladık birden çok özellik tanımladığımız için class kullandık tek bir değişken kullanmadık

            Kurs kurs1=new Kurs(); //kurs değişkeni tanımlamak için bunu kullanırız
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //kurs değişkeni tanımlamak için bunu kullanırız
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //kurs değişkeni tanımlamak için bunu kullanırız
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs(); //kurs değişkeni tanımlamak için bunu kullanırız
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kkurtboğan";
            kurs4.IzlenmeOrani = 100;
            //yeni kurs eklediğimde onu sadece listeye eklerim ekranda görünen kısma ellemedim.
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4}; //içinde kurs nesnesi barındıran array tanımladık

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi); //elimdeki verinin bu kısmını gösterdim sadece
            }
           // Console.WriteLine("Hello World!");
        }
    }
    class Kurs  //bizim değikenimiz artık kurs ve 3 tane özelliği var proplar
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        { //tek tek tanımladık
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya giriş";
            string kurs3 = "Java";
            //array- dizi
            //gelen veriyi kurslar değişkeninde tutuyoruz aslında 
            //arrayde tuttuk
            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Programlamaya giriş" , "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)  //1 den başla 10dan küçük olana kadar arttır
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach  (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");  //döngünün bittiğini göstermke için
        }
    }
}

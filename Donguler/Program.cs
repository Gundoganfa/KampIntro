using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Kampı";
            string kurs2 = "Programlamaya Giriş";
            string kurs3 = "Java kursu";

            //array - dizi 

            //dizi tanımlama
            string[] kurslar = new string[] { "Yazılım Kampı",
                "Programlamaya Giriş", "Java Kursu", "Python", "C++"};
            //string[] kurslar = kurslariGetir(); //gercek hayatta bir veri kaynagindan bu sekilde geliyor 
            Console.WriteLine(kurslar.Length);
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\nForeach\n");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}

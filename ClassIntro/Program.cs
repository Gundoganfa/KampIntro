using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Fatih";
            string yas = "38";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Fatih Gündoğan";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Alp Gündoğan";
            kurs2.IzlenmeOrani = 33;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Basic";
            kurs3.KursunEgitmeni = "Emir Gündoğan";
            kurs3.IzlenmeOrani = 26;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni + " " + kurs1.IzlenmeOrani + "%");

            //angular, react, html css, bootstrap vb. ile bu veriler görselleştirilir
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni + " " + kurs.IzlenmeOrani + "%");
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

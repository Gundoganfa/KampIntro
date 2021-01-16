using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun(); // Bir class örneği oluşturuldu
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun(); // Bir class örneği oluşturuldu
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Kış Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 }; // c#'da array tanımlama

            //type-safe -- tip güvenli (çalışacağın veri tipini bilmen gerekiyor)
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("--------Metotlar--------");

            //instance oluşturma
            SepetManager sepetManager = new SepetManager();

            //encapsulation - Class'ta bir property eklenirse kodlar patlamaz.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil Armut", 12); // parametre değişmesi gerekirse hata üretir.
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 44); // o  yüzden class kullan.
            sepetManager.Ekle2("Elma", "Yeşil Elma", 9);
        }
    }
}


// Don't repeat yourself
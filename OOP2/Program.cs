using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fatih";
            musteri1.Soyadi = "Gündoğan";
            musteri1.TcNo = "99999999";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12347";
            musteri2.SirketAdi = "ProBro Tech.";
            musteri2.VergiNo = "88888888";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            // inheritance'ın ne kadar etkili olduğunu göstermek adına aşağıdaki örneği inceleyiniz
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}

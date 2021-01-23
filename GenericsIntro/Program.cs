using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Generic yapılara bir örnek
            isimler.Add("Fatih");
            Console.WriteLine(isimler.Length); 
            isimler.Add("Mahmut");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}

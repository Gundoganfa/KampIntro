using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                UnitsInStock = 5, ProductName = "Kalem2", UnitPrice = 500 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //sayisallar deger tipti, ama diziler, classlar, abstract classlar, interfaceler referans tiptir.
            // ref ve out keywordleri


           
        }
    }
}

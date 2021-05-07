using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//class
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);




            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);








            //  int sayi = 100;
            //  productManager.BiseyYap(sayi);
            //  Console.WriteLine(sayi);//100

            //int,double,bool.....değer tipi--bağımsız  sadece verilen gönderilen değeri alır.
            //diziler,class,abstract class, interface...referans tip--bellekte ki adrese gider.
        }
    }
}

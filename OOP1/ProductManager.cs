using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Ürünle ilgili operasyonlar var. Güncelleme silme ekleme gibi...
    class ProductManager
    {
        //encağsulation--ürünleri int,string gibi ayırmak yerine "product" claass'ını içeren kısmı alırız. 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        //public int Topla(int sayi1,int sayi2)
        //{
        //  return sayi1 + sayi2;     //Toplar ve istediğimiz yerde kullanılır.
        //}

        //public void Topla2(int sayi1,int sayi2)   //void emir kipi gibi toplar ve işini bitirir. Programın başka yerinde kullanılmaz.
        //{
        //   Console.WriteLine(sayi1+sayi2);

        // }
        //************************************************************
        // public void BiseyYap(int sayi)
        //  {
        //      sayi = 99;

        //  }
    }
}

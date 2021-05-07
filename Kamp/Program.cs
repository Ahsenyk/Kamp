using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {//Type safety-tip güvenliği
            // do not repeat yourself-kendini tekrarlama
            //değer tutucu, alias
            String kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGİrisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGİrisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }



            Console.WriteLine(kategoriEtiketi);

        }
    }
}

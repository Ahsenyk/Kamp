using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };


            //type safe--tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("*************************");
            }

            Console.WriteLine("-----------Metotlar-----------");
            //instance-örnek
            //encapsulation-kapsülleme-düzensiz yapıyı düzenliyoruz

            BasketManager sepetManager = new BasketManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // gidip metota başka özellik eklediğimiz zaman aşağıdakiler patar.Bu yüzden bunun kullanılması doğru değildir.Class'lar kullanılır.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 10);
        }
    }
}
//dont repeat yourself=kendini tekrarlama
// best practice=doğru teknikler
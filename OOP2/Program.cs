using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerçek müşteri girişi
            RealCustomer musteri1 = new RealCustomer();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Dmiroğ";
            musteri1.TcNo = "22222222222222";


            //tüzel müşteri girişi
            JuridicalCustomer musteri2 = new JuridicalCustomer();
            musteri2.Id = 2;
            musteri2.MusteriNo = "264645";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "65656565965";



            // Gerçek Müşteri-Tüzel Müşteri
            // SOLID

            Customer musteri3 = new RealCustomer();  //new biçim için referans numarasını yansıtır. Müşteri sınıfı hem gerçek hem tüzel referansını tutar.
            Customer musteri4 = new JuridicalCustomer();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}

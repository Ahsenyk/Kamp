using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmeni = "Engin Dmeirog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;



            //Console.WriteLine(kurs1.KursAdı + " " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " " + kurs.Egitmeni);
            }
        }

        class Kurs
        {
            public string KursAdı { get; set; }

            public string Egitmeni { get; set; }

            public int IzlenmeOranı { get; set; }

        }
    }
}

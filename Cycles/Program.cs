using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geleiştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java ";

            //array=dizi

            string[] kurslar = new string[] {"yazılım geleiştirici yetiştirme kampı",
                "programlamaya başlangıç için temel kurs" ,"java ","Python","SQL"};




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}

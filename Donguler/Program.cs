using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrey - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java" };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }
            
        }
    }
}

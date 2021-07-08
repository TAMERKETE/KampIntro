using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1= "yazılım geliştirme kampı";
            string kurs2= "programlamya giriş";
            string kurs3= "java";
            string kurs4= "phyton";

            string[] kurslar = new string[] { "yazılım geliştirme kampı",
            "programlamya giriş","java","phyton","c#"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu-footer");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ ";
            kurs1.IzlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.Egitmen = "Emrah Yüksel";
            kurs2.IzlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "phyton";
            kurs3.Egitmen = "tamer kete ";
            kurs3.IzlenmeOranı = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);

            }



            Console.ReadLine();
        }

    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}

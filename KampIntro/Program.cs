using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String KategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış oku");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış oku");

            }
            else
            {
                Console.WriteLine("değişmedi oku");

            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("kullanıcı giriş yap butonu");

            }
            
           

            Console.WriteLine(KategoriEtiketi);

            Console.ReadLine();
            
        }
    }
}

using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun) ;
            {
                Console.WriteLine("Artis oku");

            }
            else
            {
                Console.WriteLine("Degismedi oku");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahminoyunu
{
    using System;

    class TahminOyunu
    {
        private int rastgeleSayi;
        private int tahminSayisi;

        public TahminOyunu()
        {
            Random rnd = new Random();
            rastgeleSayi = rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üret
            tahminSayisi = 0;
        }

        public void OyunuBaslat()
        {
            int tahmin = 0;

            Console.WriteLine("1 ile 100 arasında bir sayı söyle!");

            while (tahmin != rastgeleSayi)
            {
                Console.Write("Tahmininizi girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                tahminSayisi++;

                if (tahmin > rastgeleSayi)
                    Console.WriteLine("Daha küçük bir sayı girin!");
                else if (tahmin < rastgeleSayi)
                    Console.WriteLine("Daha büyük bir sayı girin!");
            }

            Console.WriteLine($"Tebrikler! {tahminSayisi} denemede doğru tahminde bulundunuz.");
        }
    }

}

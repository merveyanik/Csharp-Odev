using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev3
{
    public class Araba
    {
        public Marka MarkaBilgisi { get; set; }
        public Kapi KapiBilgisi { get; set; }
        public Pencere PencereBilgisi { get; set; }
        public Kasa KasaBilgisi { get; set; }
        public double Fiyat { get; set; }

        public Araba()
        {
            MarkaBilgisi = new Marka();
            KapiBilgisi = new Kapi();
            PencereBilgisi = new Pencere();
            KasaBilgisi = new Kasa();
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın markası {MarkaBilgisi.MarkaAdi}, modeli {MarkaBilgisi.Model}, kapı sayısı {KapiBilgisi.KapiSayisi}, " +
                $"pencere sayısı {PencereBilgisi.PencereSayisi}, kasası {KasaBilgisi.KasaTipi}, fiyatı {Fiyat} TL’dir.");
        }
    }
}


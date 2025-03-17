using System;

namespace Ödev3
{
    internal class Program
    {
        static void Main()
        {
            Araba bmw = new Araba
            {
                MarkaBilgisi = { MarkaAdi = "BMW", Model = "X5" },
                KapiBilgisi = { KapiSayisi = 4 },
                PencereBilgisi = { PencereSayisi = 4 },
                KasaBilgisi = { KasaTipi = "Sedan" },
                Fiyat = 2000000
            };

            bmw.BilgileriYazdir();

            {
                Matematik.Matematikk matematik = new Matematik.Matematikk();

                Console.WriteLine("Toplama İşlemleri:");
                Console.WriteLine(matematik.Topla(29, 10));
                Console.WriteLine(matematik.Topla(5, 63, 45)); 
                Console.WriteLine(matematik.Topla(5.5, 10.5));
                Console.WriteLine(matematik.Topla(9.1, 50.3, 2.5)); 

                Console.WriteLine("\nÇarpma İşlemleri:");
                Console.WriteLine(matematik.Carp(2, 5)); 
                Console.WriteLine(matematik.Carp(2, 4, 4)); 
                Console.WriteLine(matematik.Carp(2.5, 3.2)); 
                Console.WriteLine(matematik.Carp(1.5, 2.5, 3.5)); 
            }
        }

    }
}


                                         //Araştırma Ödevi
//Garbage Collector (GC) Nedir?
//GC, .NET’in bellek yönetim sistemidir. Kullanılmayan nesneleri otomatik olarak temizler.
//Çalışma prensibi: GC, kullanılmayan nesneleri "çöp" olarak işaretler ve bellekten temizler.
//Rolü: Bellek sızıntılarını önler, bellek yönetimini otomatikleştirir.
//Dezavantajı: Performans kaybı olabilir çünkü çöp toplama işlemi zaman zaman yapılır.


// Generic Class’lar ve Generic Method’lar (Boxing & Unboxing)
//Generic Class/Method: Türü çalışma zamanında belirleyerek daha esnek ve yeniden kullanılabilir kod yazmanızı sağlar.
//Boxing: Değer tipini (örneğin int) object tipine dönüştürme işlemidir.
//Unboxing: object tipini, doğru değer tipine dönüştürme işlemidir.
//Performans: Boxing ve Unboxing, ekstra bellek kullanımı ve işlem gücü gerektirir, bu yüzden performansı olumsuz etkileyebilir.

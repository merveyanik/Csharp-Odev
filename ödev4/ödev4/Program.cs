using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System;

namespace ödev4
{
class Program
        {
            static void Main()
            {
                OrtalamaHesaplayici hesaplayici = new OrtalamaHesaplayici(); 
                hesaplayici.SayilariAl(); // Kullanıcıdan sayıları alıyor.

                double ortalama = hesaplayici.OrtalamaHesapla(); // Ortalamayı hesaplayacak kısım

                Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
            }
        }
    }


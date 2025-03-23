using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

class OrtalamaHesaplayici
{
    private int[] sayilar; 
    private int toplam;

    public OrtalamaHesaplayici()
    {
        sayilar = new int[5];
        toplam = 0;
    }

    public void SayilariAl()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            toplam += sayilar[i]; 
        }
    }

    public double OrtalamaHesapla()
    {
        return (double)toplam / sayilar.Length;
    }
}

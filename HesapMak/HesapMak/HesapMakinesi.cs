using System;

class HesapMakinesi
{
    private double sayi1, sayi2;

    public void SayilariAl()
    {
        Console.Write("Birinci sayıyı girin: ");
        sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        sayi2 = Convert.ToDouble(Console.ReadLine());
    }

    public void IslemiYap(char islem)
    {
        double sonuc = 0;
        bool gecerliIslem = true;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                {
                    Console.WriteLine(" Hata: Bir sayı sıfıra bölünemez!");
                    gecerliIslem = false;
                }
                break;
            default:
                Console.WriteLine(" Geçersiz işlem!");
                gecerliIslem = false;
                break;
        }

        if (gecerliIslem)
            Console.WriteLine($"Sonuç: {sonuc}");
    }
}

namespace HesapMak_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi hesapMakinesi = new HesapMakinesi();
            hesapMakinesi.SayilariAl();

            Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            hesapMakinesi.IslemiYap(islem);
        }
    }
}

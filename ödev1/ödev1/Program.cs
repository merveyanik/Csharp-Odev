namespace ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            toyota toyota = new toyota();
            toyota.ödev("toyota", "otomatik");

            audi audi = new audi();
            audi.ödev("audi", "düz");
             
            togg togg = new togg();
            togg.ödev("togg", "otomatik");

            mercedes mercedes = new mercedes();
            mercedes.ödev("mercedes","otomatik veya düz");
             
            bmw bmw = new bmw();
            bmw.ödev("bmw","düz");

            porsche porsche = new porsche();
            porsche.ödev("porsche", "otomatik");

        }  

    }
}

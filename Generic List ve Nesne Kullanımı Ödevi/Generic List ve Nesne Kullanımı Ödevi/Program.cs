namespace Generic_List_ve_Nesne_Kullanımı_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> arabalar = new List<Car>
        {
            new Car("Toyota", "Corolla", 6.5, 5000),
            new Car("BMW", "X5", 9.0, 5000),
            new Car("Mercedes", "C200", 8.2, 5000)
        };

            foreach (var araba in arabalar)
            {
                araba.BilgileriYazdir();
            }
        }
    }
}

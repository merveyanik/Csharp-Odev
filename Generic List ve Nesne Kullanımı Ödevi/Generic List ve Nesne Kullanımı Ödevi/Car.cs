using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Car
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double FuelConsumption { get; set; }
    public double TotalDistance { get; set; } 

    public Car(string marka, string model, double fuelConsumption, double totalDistance)
    {
        Marka = marka;
        Model = model;
        FuelConsumption = fuelConsumption;
        TotalDistance = totalDistance;
    }

    public double ToplamYakıtTüketimi()
    {
        return (TotalDistance / 100) * FuelConsumption;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, 100 km'de Yaktığı Yakıt: {FuelConsumption} litre, Toplam Yakıt Tüketimi: {ToplamYakıtTüketimi()} litre");
    }
}


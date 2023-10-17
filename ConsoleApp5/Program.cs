using Home_Task.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw_M5 = new Bmw();
            bmw_M5.CarModel();
            bmw_M5.CarSound();
            bmw_M5.CarYear();
            bmw_M5.MotorPower();
            bmw_M5.TotalFuel();
            bmw_M5.TotalKm();

            Console.WriteLine("");
            Console.WriteLine("");

            Mercedes mercedes_E63 = new Mercedes();
            mercedes_E63.CarModel();
            mercedes_E63.CarSound();
            mercedes_E63.CarYear();
            mercedes_E63.MotorPower();
            mercedes_E63.TotalFuel();
            mercedes_E63.TotalKm();

            Console.WriteLine("");
            Console.WriteLine("");

            Tesla tesla = new Tesla();
            tesla.CarModel();
            tesla.CarSound();
            tesla.CarYear();
            tesla.MotorPower();
            tesla.TotalFuel();
            tesla.TotalKm();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Models
{
    internal class Tesla : Car , ITotalKmAble , IMotorPowerAble , ITotalFuelAble
    {
        

        public override void CarModel()
        {
            Console.WriteLine("Model : Tesla M2"); ;
        }

        public override void CarSound()
        {
            Console.WriteLine("Sound : -------------------"); ;
        }

        public override void CarYear()
        {
            Console.WriteLine("Year : " + 2015);
        }

        public void MotorPower()
        {
            Console.WriteLine("Motor Power : 3.5 ");
        }

        public void TotalFuel()
        {
            Console.WriteLine("Total Fuel : ----------- ");
        }

        public void TotalKm()
        {
            Console.WriteLine("Totsl Km : 50000");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Models
{
    public class Bmw : Car , ITotalKmAble , IMotorPowerAble , ITotalFuelAble
    {
        public override void CarModel()
        {
            Console.WriteLine("Model : BMW M5"); 
        }

        public override void CarSound()
        {
            Console.WriteLine("Sound : xor xor xor vizz"); 
        }

        public override void CarYear()
        {
            Console.WriteLine("Year : " + 2010); 
        }

        public void MotorPower()
        {
            Console.WriteLine("Motor Power : 5.5 ");
        }

        public void TotalFuel()
        {
            Console.WriteLine("Total Fuel : 150 l ");
        }

        public void TotalKm()
        {
            Console.WriteLine("Total Km : 150000");
        }
    }
}

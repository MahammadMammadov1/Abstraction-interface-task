using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Models
{

    public class Mercedes : Car , ITotalKmAble , IMotorPowerAble , ITotalFuelAble
    {
        public override void CarModel()
        {
            Console.WriteLine("Model : Mercedes E63"); ;
        }

        public override void CarSound()
        {
            Console.WriteLine("Sound : xor xor");

            
        }

        public override void CarYear()
        {
            Console.WriteLine("Year : " + 2008);
        }

        public void MotorPower()
        {
            Console.WriteLine("Motor Power : 4.0 ");
        }

        public void TotalFuel()
        {
            Console.WriteLine("Total Fuel : 200 l ");
        }

        public void TotalKm()
        {
            Console.WriteLine("Total km : 200000");
        }
    }
}

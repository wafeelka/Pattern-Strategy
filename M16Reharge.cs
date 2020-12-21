using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior.RechargeBehavior
{
    class M16Reharge: IRecharge
    {

       public float SpeedRecharge { get; set; } = 0.30f;
        public int AmmoCount { get; set; } = 30;
       
        public  void RechargeAction() 
        {
            float timeRecharge = SpeedRecharge * AmmoCount;
            Console.WriteLine($"M16 time recharge  = {timeRecharge} second");
        }
    }
}

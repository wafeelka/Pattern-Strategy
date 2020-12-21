using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior.RechargeBehavior
{
    class BowRecharge: IRecharge
    {
        public float SpeedRecharge { get; set; } = 5.0f;
        public int AmmoCount { get; set; } = 1;
        public void RechargeAction()
        {
            float timeRecharge = SpeedRecharge * AmmoCount;
            Console.WriteLine($"Bow time recharge  = {timeRecharge} second");
        }
    }
}


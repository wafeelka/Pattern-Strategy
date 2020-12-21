using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior.RechargeBehavior
{
    class MinigunRecharge : IRecharge
    {
        public float SpeedRecharge { get; set; } = 0.70f;
        public int AmmoCount { get; set; } = 100;
        public void RechargeAction()
        {
            float timeRecharge = SpeedRecharge * AmmoCount;
            Console.WriteLine($"Minigun time recharge  = {timeRecharge} second");
        }
    }
}


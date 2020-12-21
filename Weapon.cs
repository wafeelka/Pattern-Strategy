using Pattern_Strategy.WeaponsBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Weapons
{
    public abstract class Weapon
    {
        public IShooting shooting;
        public IRecharge recharge;
        public void PerformeShooting() 
        {
            shooting.ShootingAction();
        }
        public void PerformeRecharge() 
        {
            float speed = recharge.SpeedRecharge;
            int ammoCoint = recharge.AmmoCount;
            recharge.RechargeAction();
        }

    }
}

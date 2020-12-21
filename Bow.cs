using Pattern_Strategy.WeaponsBehavior;
using Pattern_Strategy.WeaponsBehavior.RechargeBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Weapons
{
    class Bow : Weapon
    {
       public Bow()
        {
            shooting = new BowShooting();
            recharge = new BowRecharge();
        }
    }
}

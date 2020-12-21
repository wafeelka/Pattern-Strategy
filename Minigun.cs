using Pattern_Strategy.WeaponsBehavior;
using Pattern_Strategy.WeaponsBehavior.RechargeBehavior;

namespace Pattern_Strategy.Weapons
{
    class Minigun : Weapon
    {
        public Minigun()
        {
            shooting = new MinigunShooting();
            recharge = new MinigunRecharge();
        }
           
    }
}

using Pattern_Strategy.WeaponsBehavior;
using Pattern_Strategy.WeaponsBehavior.RechargeBehavior;

namespace Pattern_Strategy.Weapons
{
    class M16: Weapon
    {
        public  M16()
        {
            shooting = new M16Shooting();
            recharge = new M16Reharge();
        }
    }
}

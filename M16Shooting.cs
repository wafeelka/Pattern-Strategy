using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior
{
    class M16Shooting : IShooting
    {
        public void ShootingAction()
        {
            Console.WriteLine("Puch-puch-Puch");
        }
    }
}

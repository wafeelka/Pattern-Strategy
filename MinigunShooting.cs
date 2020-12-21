using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior
{
    class MinigunShooting: IShooting
    {
        public void ShootingAction()
        {
            Console.WriteLine("Ta-ta-ta-ta-ta");
        }
    }
}

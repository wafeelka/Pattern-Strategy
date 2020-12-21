using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior
{
    class BowShooting: IShooting
    {
     public void ShootingAction()
        {
            Console.WriteLine("Arrow flying");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.WeaponsBehavior
{
   public interface IRecharge
    {
        float SpeedRecharge { get; set; }
        int  AmmoCount { get; set; }
        void RechargeAction();
        
    }
}

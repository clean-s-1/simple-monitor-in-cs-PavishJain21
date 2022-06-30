using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checker
{
   public class ChargeState : IBatteryChecker
    {
        public bool BatteryFunctionCheck(float validateValue)
        {
            if (validateValue < 20 || validateValue > 80)
            {
                return false;
            }
            return true;
        }
    }
}

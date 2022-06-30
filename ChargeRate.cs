using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using checker;

namespace checker
{
   public class ChargeRate : IBatteryChecker
    {

        public bool BatteryFunctionCheck(float validateValue)
        {
            if (validateValue > 0.8)
            {
                return false;
            }
            return true;
        }
        
}
}

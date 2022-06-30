using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using checker;

namespace checker
{
  public  class Temprature : IBatteryChecker
    {
        public bool BatteryFunctionCheck(float validateValue)
        {
            if (validateValue < 0 || validateValue > 45)
            {
                return false;
            }
            return true;
        }
    }

}

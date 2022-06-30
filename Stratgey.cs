using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using checker;

namespace checker
{
    public class Stratgey : IStrategy
    {

        private  IBatteryChecker  _batteryChecker;

        /// <summary>
        /// Sets the Strategy.
        /// </summary>
        /// <param name="batteryChecker"></param>
        public void SetStrategy(IBatteryChecker batteryChecker)
        {
            _batteryChecker= batteryChecker;
         }

        /// <summary>
        /// Checks the battery.
        /// </summary>
        /// <param name="batteryModel">The battery model.</param>
        /// <returns></returns>
        public bool CheckBattery(float validateValue)
        {
            return _batteryChecker.BatteryFunctionCheck(validateValue);
        }

    }
}

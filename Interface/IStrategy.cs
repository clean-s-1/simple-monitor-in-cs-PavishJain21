using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using checker;

namespace checker
{
  public interface IStrategy
    {
        void SetStrategy(IBatteryChecker batteryChecker);

        bool CheckBattery(float validatorValue);
    }
}

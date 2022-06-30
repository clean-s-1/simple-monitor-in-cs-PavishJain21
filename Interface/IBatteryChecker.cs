using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace checker
{
    public interface IBatteryChecker
    {
        bool BatteryFunctionCheck(float validateValue);
    }
}

using System;
using System.Diagnostics;
using System.Collections;
namespace checker {
    internal class Checker
    {

        private const string tempratureMsg = "Temperature is out of range!";
        private const string chargeStateMsg = "State of Charge is out of range!";
        private const string chargeRateMsg = "Charge Rate is out of range!";
        private static IStrategy _strategy = new Stratgey();

        static bool batteryIsOk(float temperature, float soc, float chargeRate) {
            bool[] arr = new bool[3];
            arr[0]=(Checktemprature(temperature));
            arr[1] = (CheckChargingRate(chargeRate));
            arr[2] = (CheckStateCharge(soc));
            foreach (var item in arr)
            {
                if (!item)
                {
                    return false;
                }
            }
            return true;
        }

        static void ExpectTrue(bool expression) {
            if (!expression) {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }

        static bool Checktemprature(float temperature)
        {
            _strategy.SetStrategy(new Temprature());
            var result= _strategy.CheckBattery(temperature);
            PrintResult(tempratureMsg, result);
            return result;
        } 

        static bool CheckStateCharge(float soc)
        {
            _strategy.SetStrategy(new ChargeState());
            var result = _strategy.CheckBattery(soc);
            PrintResult(chargeStateMsg, result);
            return result;
        }

        static bool CheckChargingRate(float chargeRate)
        {
            _strategy.SetStrategy(new ChargeRate());
            var result = _strategy.CheckBattery(chargeRate);
            PrintResult(chargeRateMsg, result);
            return result;
        }


        static void PrintResult(string message,bool result)
        {
            if (!result)
            {
                Console.WriteLine(message);
            }
        }

        static void ExpectFalse(bool expression) {
            if (expression) {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
        static int Main() {
            ExpectTrue(batteryIsOk(25, 70, 0.7f));
            ExpectFalse(batteryIsOk(50, 85, 0.0f));
            Console.WriteLine("All ok");
            return 0;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8CS
{
    interface IElectricMotor
    {
        double BatteryCapacity { get; }
        double CurrentEnergy { get; }
        double EnergyConsumption { get; }

        void ChargeBatteryUp();
        void ChargeBatteryUp(double amount);
        bool RunOnElectricMotor(double meters);
    }
}
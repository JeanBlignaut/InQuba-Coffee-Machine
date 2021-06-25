using System;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Logic
{
    public class Cappuccino : IBeverage
    {
        private byte SugarUnits { get; init; }
        public IMachineState MachineState { get; init; }
        public RBeverageMeasures BeverageMeasures { get; init; }
        public Cappuccino(IMachineState machineState, byte sugarUnits)
        {
            MachineState = machineState;
            BeverageMeasures = new(5, 3, true);
            SugarUnits = sugarUnits;
        }
    }
}

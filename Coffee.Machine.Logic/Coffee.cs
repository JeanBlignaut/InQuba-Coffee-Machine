using System;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Logic
{
    public class Coffee : IBeverage
    {
        public IMachineState MachineState { get; init; }
        public RBeverageMeasures BeverageMeasures { get; init; }
        public Coffee (IMachineState machineState, bool useMilk){
            MachineState = machineState;
            BeverageMeasures = new (5, 2, useMilk);
        }
    }
}

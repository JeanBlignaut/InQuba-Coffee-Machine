using System;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Logic
{
    public class Coffee : IBeverage
    {
        public IMachineState MachineState { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public byte BeanCount => throw new NotImplementedException();
        public byte? MilkUnits => throw new NotImplementedException();
        public RBeverageMeasures BeverageMeasures;
        public Coffee (IMachineState machineState, bool useMilk){
            BeverageMeasures = new (5, 2, useMilk);
        }
    }
}

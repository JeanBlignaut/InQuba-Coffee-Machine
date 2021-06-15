using System;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Logic
{
    public class MachineState : IMachineState
    {
        public byte BeanCount { get; set; }
        public byte MilkUnits { get; set; }
    }
}
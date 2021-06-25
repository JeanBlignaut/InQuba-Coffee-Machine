using System;

namespace Coffee.Machine.Interfaces
{
    public interface IMachineState
    {
        byte BeanCount { get; set; }
        byte MilkUnits { get; set; }

        void ReduceBeanCountBy(byte beans){
            if (BeanCount >= beans){
                BeanCount = (byte)(BeanCount - beans);
            }
            else
            {
                throw new BeansOutException($"Not enough beans! (BeanCount:{BeanCount}), please fill beans");
            }
        }

        void ReduceMilkUnitsBy(byte milk){
            if (MilkUnits >= milk){
                MilkUnits = (byte)(MilkUnits - milk);
            }
            else
            {
                throw new MilkOutException($"Not enough milk! (MilkUnits:{MilkUnits}), please fill milk");
            }
        }
    }
}

public class MilkOutException : System.ArithmeticException
{
    public MilkOutException(string? message) : base(message){
    }
}

public class BeansOutException : System.ArithmeticException
{
    public BeansOutException(string? message) : base(message){
    }
}
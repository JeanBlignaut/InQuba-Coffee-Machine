namespace Coffee.Machine.Interfaces
{
    public interface IBeverage
    {
        IMachineState MachineState { get;}
        byte BeanCount { get; }
        byte? MilkUnits { get; }

        virtual void Prepare(){
            ConsumeBeans();
            if (MilkUnits.HasValue){
                ConsumeMilk(MilkUnits.Value);
            }
        }

        virtual void ConsumeBeans(){
            MachineState.ReduceBeanCountBy(BeanCount);
        }

        virtual void ConsumeMilk(byte milkUnits)
        {
            MachineState.ReduceMilkUnitsBy(milkUnits);
        }
    }
}
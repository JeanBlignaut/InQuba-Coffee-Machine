namespace Coffee.Machine.Interfaces
{
    public interface IBeverage
    {
        IMachineState MachineState { get; init;}
        RBeverageMeasures BeverageMeasures { get; init; }

        virtual void Prepare(){
            ConsumeBeans();
            if (BeverageMeasures.UseMilk){
                ConsumeMilk();
            }
        }

        virtual void ConsumeBeans(){
            MachineState.ReduceBeanCountBy(BeverageMeasures.BeanCount);
        }

        virtual void ConsumeMilk()
        {
            MachineState.ReduceMilkUnitsBy(BeverageMeasures.MilkUnits);
        }
    }
}
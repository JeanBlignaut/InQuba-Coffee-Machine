namespace Coffee.Machine.Interfaces
{
    public interface IBeverage
    {
        IMachineState MachineState { get; init;}
        RBeverageMeasures BeverageMeasures { get; init; }

        virtual string Prepare(){
            ConsumeBeans();
            if (BeverageMeasures.UseMilk){
                ConsumeMilk();
            }

            return CompletedBeverage();
        }

        virtual string CompletedBeverage() => $"{this.GetType()}";

        virtual bool CheckSupplies() => MachineState.BeanCount >= BeverageMeasures.BeanCount && MachineState.MilkUnits >= BeverageMeasures.MilkUnits;
     

        virtual void ConsumeBeans(){
            MachineState.ReduceBeanCountBy(BeverageMeasures.BeanCount);
        }

        virtual void ConsumeMilk()
        {
            MachineState.ReduceMilkUnitsBy(BeverageMeasures.MilkUnits);
        }
    }
}
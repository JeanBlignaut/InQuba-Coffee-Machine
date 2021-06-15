namespace Coffee.Machine.Interfaces
{
    public interface IBeverage
    {
        virtual void Prepare(){
            ConsumeBeans();
            ConsumeMilk();
        }
        virtual void ConsumeBeans(){
            
        }
        abstract void ConsumeMilk();
    }
}
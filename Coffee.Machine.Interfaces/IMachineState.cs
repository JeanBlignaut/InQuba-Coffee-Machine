namespace Coffee.Machine.Interfaces
{
    public interface IMachineState
    {
        byte BeanCount { get; set; }
        byte MilkUnits { get; set; }

        void ReduceBeanCountBy(byte beans){
            
        }
    }
}
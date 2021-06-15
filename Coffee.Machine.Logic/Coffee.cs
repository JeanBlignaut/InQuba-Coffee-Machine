using System;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Logic
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            ConsumeBeans();
            
        }
        public void ConsumeBeans()
        {
            Beans =  - 5;
        }

        public void ConsumeMilk()
        {
            throw new NotImplementedException();
        }
    }
}

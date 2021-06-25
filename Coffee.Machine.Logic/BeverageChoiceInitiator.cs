using Coffee.Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Machine.Logic
{
    public class BeverageChoiceInitiator
    {
        public IMachineState MachineState { get; init; }
        public IMachineIO MachineIO { get; init; }

        public BeverageChoiceInitiator(IMachineState machineState, IMachineIO machineIO)
        {
            MachineState = machineState;
            MachineIO = machineIO;
        }

        public void BeveragePrompt()
        {
            MachineIO.WriteLine("Welcome what would you like:");
            MachineIO.WriteLine("");
            foreach (var beverage in Enum.GetValues(typeof(BeverageChoices)))
            {
                MachineIO.WriteLine($"{(int)beverage} {beverage}");
            }
            MachineIO.WriteLine("");
            MachineIO.WriteLine("Please enter the number of your beverage choice>");
            MachineIO.ReadLine();
        }

        public IBeverage ChooseBeverage(BeverageChoices beverageChoice, Func<string>? additionalUserPrompt = null)
        {
            throw new NotImplementedException();
            //switch (beverageChoice)
            //{
            //    case BeverageChoices.Coffee:
            //        return new Coffee(MachineState, (bool)additionalUserPrompt());
            
            //    case BeverageChoices.Cappuccino:
            //        return new Cappuccino(MachineState, additionalUserPrompt());

            //    default:
            //        return null;
            //}
        }



        
}
}

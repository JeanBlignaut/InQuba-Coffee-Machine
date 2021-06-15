using Coffee.Machine.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coffee.Machine.Interfaces;

namespace Coffee.Machine.Tests
{
    [TestClass]
    public class CoffeeTests
    {
        [TestMethod]
        public void TestBeansOut()
        {
            var machineState = new MachineState(); //{ BeanCount = 5, MilkUnits = 0}
            var useMilk = false;
            IBeverage coffee = new Coffee.Machine.Logic.Coffee(machineState, useMilk);

            Assert.ThrowsException<BeansOutException>(() => coffee.Prepare());

            machineState.BeanCount = 5;

            coffee.Prepare();

        }

        [TestMethod]
        public void TestMilkOut()
        {
            var machineState = new MachineState(); //{ BeanCount = 5, MilkUnits = 0}
            var useMilk = true;
            IBeverage coffee = new Coffee.Machine.Logic.Coffee(machineState, useMilk);

            machineState.BeanCount = 5;

            Assert.ThrowsException<MilkOutException>(() => coffee.Prepare());

            machineState.MilkUnits = 2;

            coffee.Prepare();

            Assert.AreEqual(0, machineState.BeanCount);
            Assert.AreEqual(0, machineState.MilkUnits);

        }
    }
}

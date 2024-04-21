using TestMVVM;

namespace TestProject1
{
    [TestClass]
    public class VieModelTest
    {
        [TestMethod]
        public void IfNNumbersNegative_ResetValue()
        {
            GameViewModel vm = new GameViewModel();
            vm.NNumbers = -10;

            Assert.AreEqual(10, vm.NNumbers);
        }

        [TestMethod]
        public void IfNCorrectNumbersNegative_ResetValue()
        {
            GameViewModel vm = new GameViewModel();
            vm.NCorrectNumbers = -10;

            Assert.AreEqual(1, vm.NCorrectNumbers);
        }
    }
}
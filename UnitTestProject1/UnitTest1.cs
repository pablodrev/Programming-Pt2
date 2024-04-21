using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using TestMVVM;

namespace UnitTestProject1
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public void IfNNumbersNegative_ResetValue()
        {
            ViewModel vm = new ViewModel();
            vm.NNumbers = -10

            Assert.AreEqual(10, vm.NNumbers);
        }

        [TestMethod]
        public void IfNCorrectNumbersNegative_ResetValue()
        {
            ViewModel vm = new ViewModel();
            vm.NCorrectNumbers = -10

            Assert.AreEqual(1, vm.NCorrectNumbers);
        }
    }
}

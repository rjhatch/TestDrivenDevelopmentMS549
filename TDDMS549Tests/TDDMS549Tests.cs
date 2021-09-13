using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentMS549;

namespace TDDMS549Tests
{
    [TestClass]
    public class TDDMS549Tests
    {
        [TestMethod]
        public void InitStackRH()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);
            Assert.AreEqual(stackSize - 1, myStack.Max);
        }
    }
}

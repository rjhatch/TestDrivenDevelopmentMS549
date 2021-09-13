using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentMS549;

namespace TDDMS549Tests
{
    [TestClass]
    public class TDDMS549Tests
    {
        int stackSize = 10;
        static StackRH myStack;

        [TestMethod]
        public void InitStackRH()
        {
            myStack = new StackRH(stackSize);
            Assert.AreEqual(stackSize - 1, myStack.Max);
            Assert.AreEqual(-1, myStack.Top);
        }

        [TestMethod]
        public void Push()
        {
            Assert.IsTrue(myStack.Push(10));
        }

        [TestMethod]
        public void PushOutOfBounds()
        {
            for (int i = 0; i < stackSize; i++)
            {
                if (!myStack.Push(5))
                {
                    Assert.AreEqual(myStack.Top, myStack.Max);
                }
            }
        }
    }
}

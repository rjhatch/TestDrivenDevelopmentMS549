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
            Assert.AreEqual(-1, myStack.Top);
        }

        [TestMethod]
        public void Push()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);
            Assert.IsTrue(myStack.Push(10));
            Assert.AreEqual(0, myStack.Top);

            Assert.IsTrue(myStack.Push(9));
            Assert.AreEqual(1, myStack.Top);
        }

        [TestMethod]
        public void PushOutOfBounds()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);
            for (int i = 0; i < stackSize; i++)
            {
                if (!myStack.Push(5))
                {
                    Assert.AreEqual(myStack.Top, myStack.Max);
                }
            }
        }

        [TestMethod]
        public void Peek()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);

            myStack.Push(10);

            Assert.AreEqual(10, myStack.Peek());
        }

        [TestMethod]
        public void PeekOnEmpty()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);

            Assert.AreEqual(null, myStack.Peek());
        }

        [TestMethod]
        public void Pop()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);

            myStack.Push(5);
            Assert.AreEqual(5, myStack.Pop());
            Assert.AreEqual(-1, myStack.Top);

            for (int i = 0; i < stackSize - 1; i++)
            {
                myStack.Push(i);
            }

            for (int i = stackSize - 1; i < 0; i--)
            {
                Assert.AreEqual(i, myStack.Pop());
            }
        }

        [TestMethod]
        public void PopOnEmpty()
        {
            int stackSize = 10;
            StackRH myStack = new StackRH(stackSize);

            Assert.AreEqual(null, myStack.Pop());
        }
    }
}

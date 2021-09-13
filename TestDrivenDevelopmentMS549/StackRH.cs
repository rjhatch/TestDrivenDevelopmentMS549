using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentMS549
{
    public class StackRH
    {
        private int[] stack;
        private int top;
        private int maxSize;

        public int Top { get { return top; } }
        public int Max { get { return maxSize; } }

        public StackRH(int stackSize)
        {
            stack = new int[stackSize];
            top = -1;
            maxSize = stackSize - 1;
        }

        public bool Push(int value)
        {
            if (top < maxSize)
            {
                top++;
                stack[top] = value;
                return true;
            }

            return false;
        }
    }
}

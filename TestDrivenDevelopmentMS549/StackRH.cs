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
        private int top = -1;
        private int maxSize;

        public int Top { get { return top; } }
        public int Max { get { return maxSize; } }

        public StackRH(int stackSize)
        {
            stack = new int[stackSize];
            maxSize = stackSize - 1;
        }

        public bool Push(int value)
        {
            if (top < maxSize)
            {
                stack[++top] = value;
                return true;
            }

            return false;
        }

        public int? Peek()
        {
            if (top >= 0)
            {
                return stack[top];
            }
            else
            {
                return null;
            }
        }

        public int? Pop()
        {
            if (top >= 0)
            {
                return stack[top--];
            }
            else
            {
                return null;
            }
        }
    }
}

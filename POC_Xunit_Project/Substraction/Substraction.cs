using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Substraction
{
    public class Substractions:ISubstraction
    {
        public int x;
        public int y;
        public Substractions(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Substractions() { }
        public int substract()
        {
            return x - y;
        }
        
        public int substract(int x, int y)
        {
            return x-y;
        }
        public int SafeSubtract(int num1, int num2)
        {
            if (num1 < num2)
            {
                throw new ArgumentException("Cannot subtract a larger number from a smaller number.");
            }
            return num1 - num2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Substraction
{
    public interface ISubstraction
    {
        public int substract();
        public int substract(int x, int y);
        public int SafeSubtract(int num1, int num2);
    }
}

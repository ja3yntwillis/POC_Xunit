using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Multiplication
{
    public interface IMultiplication
    {
        public int multiply();
        public int multiply(int x, int y, int z);
        public int multiply(List<int> list);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Operations
{
    internal interface IOperation
    {
        public List<int> CalculateMultipleOperations(int x, int y, int z);
        public int DoContinuousAddition(List<int> values);
        public int FindCountOfTheStorage(List<int> values);
        public int SafeCheck(int s, int t);

    }
}

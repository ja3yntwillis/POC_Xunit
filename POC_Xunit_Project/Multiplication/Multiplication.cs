using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Multiplication
{
    public class Multiplications:IMultiplication
    {
        public int x;
        public int y;
        public Multiplications(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Multiplications() { }
        public int multiply()
        {
            return x * y;
        }
        public int multiply(int z)
        {
            return x * y * z;
        }
        public int multiply(List<int> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result = result * list[i];
            }
            return result;
        }
        public int multiply(int x, int y, int z)
        {
            return x * y * z;
        }
        
    }
}

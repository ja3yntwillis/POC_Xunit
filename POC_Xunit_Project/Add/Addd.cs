using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Add
{
    public class Addd:IAdd
    {
        public int x;
        public int y;
        public Addd(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Addd(){}
        public int addition()
        {
            return x + y;
        }
        public int addition(int z) 
        {
            return x + y + z;
        }
        public int addition(List<int> list)
        {
            int result = 0;
            for(int i = 0; i < list.Count; i++)
            {
                result = result + list[i];
            }
            return result;
        }
        public int addition(int x, int y, int z)
        {
           return x+ y + z;
        }
    }
}

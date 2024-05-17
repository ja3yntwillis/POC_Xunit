using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Add
{
    public interface IAdd
    {
        public int addition();
        public int addition(int x, int y, int z);
        public int addition(List<int> list);

    }
}

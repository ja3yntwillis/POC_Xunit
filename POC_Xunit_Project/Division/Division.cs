using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Xunit_Project.Division
{
    internal class Divisions : IDivision
    {
        public int x;
        public int y;
        public int div()
        {
            try
            {
                return x / y;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int div(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}

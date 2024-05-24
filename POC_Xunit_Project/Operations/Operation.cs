using FluentAssertions;
using System.Collections.Generic;
using POC_Xunit_Project.Add;
using POC_Xunit_Project.Division;
using POC_Xunit_Project.Multiplication;
using POC_Xunit_Project.Substraction;

namespace POC_Xunit_Project.Operations
{
    public class Operation : IOperation
    {
        IAdd _add;
        IAdd _add2;
        IDivision _division;
        IMultiplication _multiplication;
        ISubstraction _substraction;

        public Operation(IAdd add, IAdd add2, IDivision division, IMultiplication multiplication, ISubstraction substraction)
        {
            _add = add;
            _add2 = add2;
            _division = division;
            _multiplication = multiplication;
            _substraction = substraction;
        }

        public List<int> CalculateMultipleOperations(int x, int y, int z)
        {
            var sum = _add2.addition(x, y, z);
            var subs = _substraction.substract(sum, x);
            var multi = _multiplication.multiply(subs, 1, 1);
            var div = _division.div(multi, 5);
            var summation = new List<int> { div,sum, subs, multi };
            return summation;
        }

        public int DoContinuousAddition(List<int> values)
        {
            return _add.addition(values);
        }

        public int FindCountOfTheStorage(List<int> values)
        {
            return values.Count;
        }

        public int SafeCheck(int s, int t)
        {
            return _substraction.SafeSubtract(s, t);
        }
    }
}

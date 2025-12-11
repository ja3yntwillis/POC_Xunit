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
        IDivision _division;
        IMultiplication _multiplication;
        ISubstraction _substraction;

        public Operation(IAdd add, IDivision division, IMultiplication multiplication, ISubstraction substraction)
        {
            _add = add;
            _division = division;
            _multiplication = multiplication;
            _substraction = substraction;
        }
        //5,10,15
        public List<int> CalculateMultipleOperations(int x, int y, int z)
        {
            var sum = _add.addition(x, y, z);
            var subs = _substraction.substract(y, x);
            var multi = _multiplication.multiply(z, 1, 1);
            var div = _division.div(z, 5);
            var summation = new List<int> { sum, subs, multi, div };
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

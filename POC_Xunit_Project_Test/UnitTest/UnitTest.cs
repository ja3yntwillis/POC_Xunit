using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using POC_Xunit_Project.Add;
using POC_Xunit_Project.Division;
using POC_Xunit_Project.Multiplication;
using POC_Xunit_Project.Substraction;
using POC_Xunit_Project.Operations;
using System.Collections.Generic;

namespace POC_Xunit_Project.Tests
{
    [TestFixture]
    public class OperationTests
    {
        private IAdd _addMock;
        private IAdd _add2Real;
        private IAdd _add2Mock;
        private IDivision _divisionMock;
        private IMultiplication _multiplicationMock;
        private ISubstraction _substractionMock;
        private Operation _operation;


        public OperationTests()
        {

            //type mocking
             _addMock = Substitute.For<IAdd>();// is a moq
           // _add2Mock = Substitute.For<IAdd>();
            _add2Real = new Addd();
            _divisionMock = Substitute.For<IDivision>();
            _multiplicationMock = Substitute.For<IMultiplication>();
            _substractionMock = Substitute.For<ISubstraction>();

            _operation = new Operation(_addMock, _add2Real, _divisionMock, _multiplicationMock, _substractionMock);
        }

        [Fact]
        public void CalculateMultipleOperations_RealPositive_ShouldReturnCorrectResultCheckingTheValidAdditionOperation()//is realpositive or realnegative or false,false
        {
            int x = 2, y = 3, z = 8;
           // _add2Real.addition(x, y, z);

            //behaviour mocking
            _multiplicationMock.multiply(9, 1, 1).Returns(7);
            _substractionMock.substract(13, x).Returns(9);//returns overload understanding- exception situations
            _divisionMock.div(7, 5).Returns(1);
            _add2Real.addition(x, y, z);
            var result = _operation.CalculateMultipleOperations(x, y, z);
            
            //real line
            result.Should().BeEquivalentTo(new List<int> { 13, 9, 7, 1 });

                //var sum = _add2.addition(x, y, z);
                //var subs = _substraction.substract(sum, x);
                //var multi = _multiplication.multiply(subs, 1, 1);
                //var div = _division.div(multi, 5);
                //var summation = new List<int> { sum, subs, multi, div };
                //return summation;
        }

        [Fact]
        public void DoContinuousAddition_ShouldReturnSumOfValues()
        {
            // Arrange
            var values = new List<int> { 1, 2, 3, 4 };
            _addMock.addition(values).Returns(10);

            // Act
            var result = _operation.DoContinuousAddition(values);

            // Assert
            result.Should().Be(10);
        }

        [Fact]
        public void FindCountOfTheStorage_ShouldReturnCountOfValues()
        {
            // Arrange
            var values = new List<int> { 1, 2, 3, 4 };

            // Act
            var result = _operation.FindCountOfTheStorage(values);

            // Assert
            result.Should().Be(4);
        }

        [Fact]
        public void SafeCheck_ShouldReturnSafeSubtractResult()
        {
            // Arrange
            int s = 10, t = 5;
            _substractionMock.SafeSubtract(s, t).Returns(5);

            // Act
            var result = _operation.SafeCheck(s, t);

            // Assert
            result.Should().Be(5);
        }
    }
}

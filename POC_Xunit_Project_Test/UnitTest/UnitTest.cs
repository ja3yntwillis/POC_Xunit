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
        private IAdd _add2Mock;
        private IDivision _divisionMock;
        private IMultiplication _multiplicationMock;
        private ISubstraction _substractionMock;
        private Operation _operation;

        public OperationTests()
        {
            _addMock = Substitute.For<IAdd>();
            _add2Mock = Substitute.For<IAdd>();
            _divisionMock = Substitute.For<IDivision>();
            _multiplicationMock = Substitute.For<IMultiplication>();
            _substractionMock = Substitute.For<ISubstraction>();

            _operation = new Operation(_addMock, _add2Mock, _divisionMock, _multiplicationMock, _substractionMock);
        }

        [Fact]
        public void CalculateMultipleOperations_ShouldReturnCorrectResults()
        {
            // Arrange
            int x = 2, y = 3, z = 3;
            _add2Mock.addition(x, y, z).Returns(8);
            _substractionMock.substract(8, x).Returns(7);
            _multiplicationMock.multiply(7, 1, 1).Returns(7);
            _divisionMock.div(7, 5).Returns(1);

            // Act
            var result = _operation.CalculateMultipleOperations(x, y, z);

            // Assert
            result.Should().BeEquivalentTo(new List<int> { 8, 7, 7, 1 });
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

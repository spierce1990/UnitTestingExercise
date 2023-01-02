using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 2, 2, 6)] //Add test data <-------

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator= new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = calculator.Add(num1, num2, num3);  
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculatorsub= new Calculator();

            //Act
            var actual = calculatorsub.Sub(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculatormul= new Calculator();

            //Act
            var actual = calculatormul.Mul(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 2, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculatordiv = new Calculator();

            //Act
            var actual = calculatordiv.Div(num1, num2);

            Assert.Equal(expected, actual);
            //Assert
            
        }

    }
}

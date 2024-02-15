using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 2, 4, 10)]
        [InlineData(1, 3, 4, 8)]
        [InlineData(-1, -3, 5, 1)]
        
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator willTest = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
               int actual = willTest.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 3, 2)]
        [InlineData(10, 4, 6)]
        [InlineData(-1, 3, -4)]
        [InlineData(2, 3, -1)]
        [InlineData(6, -2, 8)]

        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator willTest = new Calculator();
            //Act
            int actual = willTest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5, 3, 15)]
        [InlineData(3, 3, 9)]
        [InlineData(4, 3, 12)]
        [InlineData(10, 3, 30)]
        [InlineData(-5, 3, -15)]
        [InlineData(-5, -3, 15)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator willTest = new Calculator();
            //Act
            int actual = willTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        [InlineData(15, 3, 5)]
        [InlineData(3, 3, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(21, 3, 7)]
        [InlineData(-15, 5, -3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator willTest = new Calculator();
            //Act
            int actual = willTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}

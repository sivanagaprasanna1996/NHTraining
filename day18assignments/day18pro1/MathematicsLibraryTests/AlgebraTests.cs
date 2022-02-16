using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_input()
        {
            //Arrange
            int n = 0;
            int expected = 1;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_One_To_Seven_Input()
        {
            //Arrange
            int n = 6;
            int expected = 720;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_greater_than_Seven_Input()
        {
            //Arrange
            int n = 11;
            int expected = -999;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negitive_Input()
        {
            //Arrange
            int n = -4;
            int expected = -9999;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
  }

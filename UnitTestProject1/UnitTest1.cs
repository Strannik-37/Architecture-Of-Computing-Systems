using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegralSolution;
using CalculateLibrary;

namespace IntegralSolution
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Intergrate_xx_Gives_Correct_Result_Rectangle()
        {
            double expected = 333333.3333;
            double a = 0;
            double b = 100;
            long n = 1000000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);//Утверждает, что два объекта типа T имеют одно и то же значение

        }

        [TestMethod]
        public void Intergrate_xx_Gives_Correct_Result_Trap()
        {
            double expected = 333333.3333;
            double a = 0;
            double b = 100;
            long n = 1000000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;

            //act
            double actual = trapCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual, 0.0001);//Утверждает, что два объекта типа T имеют одно и то же значение

        }

        [TestMethod]
        public void Intergrate_xx_Gives_0()
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = a;

            long n = 100000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x*x;

            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);

            //assert

            Assert.AreEqual(expected, actual);//Утверждает, что два объекта типа T имеют одно и то же значение

        }


        [TestMethod]
        public void Intergrate_different_objects()
        {

            double a = 1;
            double b = 100;
            long n = 1000000;
            TrapCalculator trapCalculator = new TrapCalculator();
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => 10 * x - Math.Log(14 * x);


            //act
            double actual = trapCalculator.Calculate(a, b, n, f);
            double expected = rectangleCalculator.Calculate(a, b, n, f);
            //assert

            Assert.AreNotSame(actual, expected);//Утверждает, что две переменные ссылаются на разные объекты

        }

        [TestMethod]
        public void Intergrate_IsNotNull()
        {

            double a = 1;
            double b = 100;
            long n = 1000000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => 10 * x - Math.Log(14 * x);


            //act
            double expected = rectangleCalculator.Calculate(a, b, n, f);
            //assert

            Assert.IsNotNull(expected); //Утверждает, что переменная присвоена объектной ссылке

        }



    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class ArrayHelper
    {
        public static double ProductOfMinMax(double[] array, int precision)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не должен быть пустым.");
            if (precision < 0)
                throw new ArgumentException("Точность не может быть отрицательной.");

            double min = array.Min();
            double max = array.Max();
            double product = min * max;

            // Округляем результат до заданной точности
            return Math.Round(product, precision);
        }
    }
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        public void ProductOfMinMax_ValidArray_ReturnsCorrectResult()
        {
            double[] array = { 1.5, 2.2, 3.1, -4.0, 0.5 };
            int precision = 2;

            double expected = Math.Round(-4.0 * 3.1, precision); // -12.40
            double actual = ArrayHelper.ProductOfMinMax(array, precision);

            Assert.AreEqual(expected, actual, 0.01); // Погрешность 0.01
        }

        [TestMethod]
        public void ProductOfMinMax_ArrayWithSingleElement_ReturnsSquare()
        {
            double[] array = { 2.5 };
            int precision = 3;

            double expected = Math.Round(2.5 * 2.5, precision); // 6.250
            double actual = ArrayHelper.ProductOfMinMax(array, precision);

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProductOfMinMax_EmptyArray_ThrowsException()
        {
            double[] array = { };
            ArrayHelper.ProductOfMinMax(array, 2); // Должен выбросить исключение
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProductOfMinMax_NegativePrecision_ThrowsException()
        {
            double[] array = { 1.0, 2.0, 3.0 };
            ArrayHelper.ProductOfMinMax(array, -1); // Должен выбросить исключение
        }

        [TestMethod]
        public void ProductOfMinMax_AllNegativeValues_ReturnsCorrectResult()
        {
            double[] array = { -1.1, -2.2, -3.3, -4.4 };
            int precision = 1;

            double expected = Math.Round(-4.4 * -1.1, precision); // 4.8
            double actual = ArrayHelper.ProductOfMinMax(array, precision);

            Assert.AreEqual(expected, actual, 0.1); // Погрешность 0.1
        }
    }
}

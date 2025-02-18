using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace modultest
{
    public class MatrixHelper
    {
        public static bool IsSymmetric(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }


    [TestClass]
    public class MatrixHelperTests
    {
        [TestMethod]
        public void IsSymmetric_SymmetricMatrix_ReturnsTrue()
        {
            int[,] matrix = { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };
            bool result = MatrixHelper.IsSymmetric(matrix);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSymmetric_NonSymmetricMatrix_ReturnsFalse()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            bool result = MatrixHelper.IsSymmetric(matrix);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSymmetric_1x1Matrix_ReturnsTrue()
        {
            int[,] matrix = { { 1 } };
            bool result = MatrixHelper.IsSymmetric(matrix);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsSymmetric_NonSquareMatrix_ThrowsException()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            MatrixHelper.IsSymmetric(matrix);
        }
    }
}
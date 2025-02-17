//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace UnitTestProject2
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        static int IsSimple(int x)
//        {
//            bool simple = true;
//            for (int i = 2; i <= x; i++)
//                if (x % i == 0)
//                {
//                    simple = false;
//                    break;
//                }
//            return simple;
//        }
//        [TestMethod]
//        public void Simple17()
//        {
//            Assert.IsTrue(IsSimple(17));
//        }


//        [TestMethod]
//        public void Simple72()
//        {
//            Assert.IsTrue(IsSimple(72));
//        }


//        [TestMethod]
//        public void Simple1()
//        {
//            Assert.IsTrue(IsSimple(1));
//        }

//        [TestMethod]
//        public void Simple0()
//        {
//            Assert.IsTrue(IsSimple(0));
//        }

//        [TestMethod]
//        public void SimpleNegative()
//        {
//            Assert.IsTrue(IsSimple(-5));
//        }
//    }
//}

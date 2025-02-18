//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PasswordLibrary;
//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using WordListLibrary;

//namespace UnitTestProject2
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        static bool IsSimple(int x)
//        {
//            bool simple = x > 1;
//            for (int i = 2; i < x; i++)
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
//            Assert.IsFalse(IsSimple(72));
//        }


//        [TestMethod]
//        public void Simple1()
//        {
//            Assert.IsFalse(IsSimple(1));
//        }

//        [TestMethod]
//        public void Simple0()
//        {
//            Assert.IsFalse(IsSimple(0));
//        }

//        [TestMethod]
//        public void SimpleNegative()
//        {
//            Assert.IsFalse(IsSimple(-5));
//        }
//    }







//    [TestClass]
//    public class UnitTest2
//    {
//        static long Fact(long n)
//        {
//            if (n < 0)
//                return 0;
//            long f = 1;
//            for (long i = 2; i <= n; i++)
//                f *= i; return f;
//        }
//        [TestMethod]
//        public void Fact6()
//        {
//            Assert.AreEqual(720, Fact(6));
//        }


//        [TestMethod]
//        public void Fact1()
//        {
//            Assert.AreEqual(1, Fact(1));
//        }


//        [TestMethod]
//        public void Fact0()
//        {
//            Assert.AreEqual(1, Fact(0));
//        }

//        [TestMethod]
//        public void FactNegative()
//        {
//            Assert.AreEqual(0, Fact(-5));
//        }
//        //Факториал числа 13 равен 6,227,020,800, что превышает максимальное значение, которое может хранить int.
//        //нужно использовать тип данных, который может хранить большие значения.В C# для этого подходит тип long
//        [TestMethod]
//        public void Fact13()
//        {
//            Assert.AreEqual(6227020800, Fact(13));
//        }
//    }

//    [TestClass]
//    public class UnitTest3
//    {
//        static double Square(double a, double b)
//        {
//            if (a > 0 && b > 0)
//                return a * b;
//            else return 0;
//        }
//        [TestMethod]
//        public void Test1()
//        {
//            Assert.AreEqual(27, Square(6, 4.5));
//        }

//        [TestMethod]
//        public void Test2()
//        {
//            //Assert.AreEqual(6.82, Square(3.1,2.2));
//            // Использую допустимую погрешность (delta) для сравнения чисел с плавающей запятой
//            Assert.AreEqual(6.82, Square(3.1, 2.2), 0.0001);
//        }

//        [TestMethod]
//        public void Test3()
//        {
//            Assert.AreEqual(0, Square(5, -3));
//        }
//        [TestMethod]
//        public void Test4()
//        {
//            Assert.AreEqual(0, Square(-5, -3));
//        }
//    }
//}
//namespace PasswordLibrary
//{
//    public class Password
//    {
//        public string UserPassword { get; set; }
//        public bool CheckPassword()

//        {
//            Regex number = new Regex(@"\d");
//            return number.IsMatch(UserPassword) &&
//                UserPassword.Length > 6;
//        }
//    }
//}
//namespace TestPassword
//{
//    [TestClass]
//    public class UnitTestPassword
//    {
//        [TestMethod]
//        public void PasswordOK6()
//        {
//            Password password = new Password();
//            password.UserPassword = "d21f9st";
//            Assert.IsTrue(password.CheckPassword());
//        }

//        [TestMethod]
//        public void PasswordOK10()
//        {
//            Password password = new Password();
//            password.UserPassword = "d21f9stz!";
//            Assert.IsTrue(password.CheckPassword());
//        }

//        [TestMethod]
//        public void PasswordNotOKNoNumber()
//        {
//            Password password = new Password();
//            password.UserPassword = "dzyo!_x";
//            Assert.IsFalse(password.CheckPassword());
//        }


//        [TestMethod]
//        public void PasswordNotOKLenghtLessThan6()
//        {
//            Password password = new Password();
//            password.UserPassword = "d23j";
//            Assert.IsFalse(password.CheckPassword());
//        }
//    }
//}
//namespace WordListLibrary
//{
//    public class WordList
//    {
//        public List<string> wordList { get; set; }

//        public WordList(List<string> words)
//        {
//            wordList = words;
//        }
//        public int DeleteWords(int masLen)
//        {
//            int count = 0;
//            for (int i = 0; i < wordList.Count; i++)
//                if (wordList[i].Length > masLen)
//                {
//                    count++;
//                    wordList.RemoveAt(i);
//                }
//            return count;
//        }
//    }
//}
//namespace TestWordList
//{
//    [TestClass]
//    public class UnitTestWords
//    {
//        [TestMethod]
//        public void TestDelete2()
//        {
//            List<string> input = new List<string> { "word", "world", "and", "library", "help" };
//            List<string> output = new List<string> { "word", "and", "help" };
//            WordList words = new WordList(input);
//            int count = words.DeleteWords(4);
//            CollectionAssert.AreEquivalent(output, words.wordList);
//            Assert.AreEqual(2, count);
//        }
//        [TestMethod]
//        public void TestDelete0()
//        {
//            List<string> input = new List<string> { "word", "world", "and", "library", "hello" };
//            List<string> output = new List<string> { "word", "world", "and", "library", "hello" };
//            WordList words = new WordList(input);
//            int count = words.DeleteWords(7);
//            CollectionAssert.AreEquivalent(output, words.wordList);
//            Assert.AreEqual(0, count);
//        }

      
//        [TestMethod]
//        public void TestDeleteAll()
//        {
//            List<string> input = new List<string>
//            {"world","mouse","library", "hello"};
//            List<string> output = new List<string> { };
//            WordList words = new WordList(input);
//            int count = words.DeleteWords(4);
//            CollectionAssert.AreEqual(output, words.wordList);
//            Assert.AreEqual(4, count);
//        }
//    }
//    public class WordList
//    {
       
//        public List<string> wordList { get; set; }
     
//        public WordList(List<string> words)
//        {
//            wordList = words;
//        }
       
//        public int DeleteWords(int maxLen)
//        {
//            int count = 0;

//            for (int i = wordList.Count - 1; i >= 0; i--)
//            {
              
//                if (wordList[i].Length > maxLen)
//                {
//                    count++;
//                    wordList.RemoveAt(i); 
//                }
//            }

//            return count;
//        }//с

//    }
//}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjerciciosEtermax;



namespace EjerciciosEtermaxTests
{
    [TestClass]
    public class ReplaceLettersTest
    {
        [TestMethod]
        public void TextAB()
        {
            ReplaceLetters sf = new ReplaceLetters();
            string res =   sf.Replace("ab");
            Assert.AreEqual("1 2", res);
        }
        [TestMethod]
        public void TextARBOL()
        {
            ReplaceLetters sf = new ReplaceLetters();
            string res = sf.Replace("arbol");
            Assert.AreEqual("1 18 2 15 12", res);
        }

        [TestMethod]
        public void Textcontra123()
        {
            ReplaceLetters sf = new ReplaceLetters();
            string res = sf.Replace("contra123()a");
            Assert.AreEqual("3 15 14 20 18 1 1", res);
        }
        [TestMethod]
        public void TextFreemium()
        {
            ReplaceLetters sf = new ReplaceLetters();
            string res = sf.Replace("Wednesday is hump day, but has anyone asked the camel if he’s happy about it?");
            Assert.AreEqual("23 5 4 14 5 19 4 1 25 9 19 8 21 13 16 4 1 25 2 21 20 8 1 19 1 14 25 15 14 5 1 19 11 5 4 20 8 5 3 1 13 5 12 9 6 8 5 19 8 1 16 16 25 1 2 15 21 20 9 20", res);
        }
    }
}

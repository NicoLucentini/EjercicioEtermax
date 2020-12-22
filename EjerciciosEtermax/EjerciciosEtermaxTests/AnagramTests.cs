using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjerciciosEtermax;

namespace EjerciciosEtermaxTests
{
    [TestClass]
    public class AnagramTests
    {

        [TestMethod]
        public void Test_car_race()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("car", "race");

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test_bag_grab()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("bag", "grab");

            Assert.IsFalse(res);
        }


        [TestMethod]
        public void Test_pepe()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("pepe", "pepepepe");

            Assert.IsTrue(res);
        }

     

        [TestMethod]
        public void Test_vein()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("vein", "universal");

            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_salt()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("salt", "universal");

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test_roast()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("roast", "pastoral");

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test_roast2()
        {
            Anagram anagram = new Anagram();

            //r o a s a 
            bool res = anagram.AnagramStrStr("roast", "proasasdsoral");

            Assert.IsFalse(res);
        }
        [TestMethod]
        public void Test_roast3()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("roast", "proaszzztl");

            Assert.IsFalse(res);
        }
        [TestMethod]
        public void Test_zzz()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("zzz", "zzzzzz");

            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_roast4()
        {
            Anagram anagram = new Anagram();

            bool res = anagram.AnagramStrStr("roast", "zzroaszzroast");

            Assert.IsTrue(res);
        }
    }
}

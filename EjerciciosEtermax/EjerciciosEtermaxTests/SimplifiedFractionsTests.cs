using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjerciciosEtermax;



namespace EjerciciosEtermaxTests
{
    [TestClass]
    public class SimplifiedFractionsTests
    {
        [TestMethod]
        public void Test4_6()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res =   sf.Simplify("4/6");

            Assert.AreEqual("2/3", res);
        }

        [TestMethod]
        public void Test_the_answer_is_an_integer()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("12/6");

            Assert.AreEqual("2", res);
        }

        [TestMethod]
        public void Test_300_200()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("300/200");

            Assert.AreEqual("3/2", res);
        }

        [TestMethod]
        public void Test_Numbers_Are_Equals_Result_1()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("6/6");

            Assert.AreEqual("1", res);
        }
        [TestMethod]
        public void Test_first_Number_bigger_than_second_and_not_integer()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("8/6");

            Assert.AreEqual("4/3", res);
        }
        [TestMethod]
        public void Test_No_se_puede_simplificar()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("3/4");

            Assert.AreEqual("3/4", res);
        }

        [TestMethod]
        public void Test_Numbers_are_letters()
        {
            SimplifiedFractions sf = new SimplifiedFractions();

            var ex = Assert.ThrowsException<Exception>(() => sf.Simplify("a/b"));
            Assert.AreEqual("Los valores no son numeros", ex.Message);
        }
        [TestMethod]
        public void Test_0_0()
        {
            SimplifiedFractions sf = new SimplifiedFractions();
            string res = sf.Simplify("0/0");

            Assert.AreEqual("0/0", res);

        }
    }
}

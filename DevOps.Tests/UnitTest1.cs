using NUnit.Framework;

namespace DevOps.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.add(a, b);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestSub()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.sub(b, a);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMul()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.mul(b, a);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestDiv()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.div(b, a);

            Assert.AreEqual(2, result);

            a = 0;
            b = 4;
            result = calc.div(b, a);

            Assert.AreEqual(0, result);
        }
    }
}
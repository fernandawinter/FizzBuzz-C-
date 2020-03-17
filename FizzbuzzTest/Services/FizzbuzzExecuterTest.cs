using Fizzbuzz.Src.Services;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        FizzbuzzExecuter executer;

        [SetUp]
        public void Setup()
        {
            executer = new FizzbuzzExecuter();
        }


        [Test]
        public void CalculateFizzbuzz_0_Fizz()
        {
            string result = executer.CalculateFizzbuzz(0);

            Assert.AreEqual("0", result);
        }

        [Test]
        public void CalculateFizzbuzz_1_1() //o que eu envio, o que eu espero
        {
            string result = executer.CalculateFizzbuzz(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void CalculateFizzbuzz_3_Fizz()
        {
            string result = executer.CalculateFizzbuzz(3);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void CalculateFizzbuzz_5_Fizz()
        {
            string result = executer.CalculateFizzbuzz(5);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void CalculateFizzbuzz_6_Fizz()
        {
            string result = executer.CalculateFizzbuzz(6);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void CalculateFizzbuzz_10_Fizz()
        {
            string result = executer.CalculateFizzbuzz(10);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void CalculateFizzbuzz_15_Fizz()
        {
            string result = executer.CalculateFizzbuzz(15);

            Assert.AreEqual("Fizzbuzz", result);
        }


        [Test]
        public void CalculateFizzbuzz_60_Fizz()
        {
            string result = executer.CalculateFizzbuzz(60);

            Assert.AreEqual("Fizzbuzz", result);
        }
    }
}
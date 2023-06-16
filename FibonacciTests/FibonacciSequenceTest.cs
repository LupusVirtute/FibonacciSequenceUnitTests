using FibonacciSequenceTests;

namespace FibonacciTests
{
    [TestClass]
    public class FibonacciSequenceTest
    {
        FibonacciSequence fibonacciSequenceImpl;

        [TestInitialize]
        public void Initialize()
        {
            fibonacciSequenceImpl = new FibonacciSequence();
        }

        [TestMethod]
        public void Expect_Return_1()
        {
            var output = fibonacciSequenceImpl.CalculateFibonacci(1);
            Assert.AreEqual(1, output);
        }
        
        [TestMethod]
        public void Expect_Return_2()
        {
            var output = fibonacciSequenceImpl.CalculateFibonacci(2);
            Assert.AreEqual(2, output);
        }
        
        [TestMethod]
        public void Expect_Return_3()
        {
            var output = fibonacciSequenceImpl.CalculateFibonacci(3);
            Assert.AreEqual(3, output);
        }
        
        [TestMethod]
        public void Expect_Return_5()
        {
            var output = fibonacciSequenceImpl.CalculateFibonacci(4);
            Assert.AreEqual(5, output);
        }

        [TestMethod]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Expect_Throw_ArgumentOutOfRangeException(int length)
        {
            fibonacciSequenceImpl.CalculateFibonacci(length);
        }
        
        [TestMethod]
        [DataRow(-1)]
        public void Expect_Throw_ArgumentOutOfRangeException_Try_Catch(int length)
        {
            try
            {
                fibonacciSequenceImpl.CalculateFibonacci(length);
                Assert.Fail($"No exception was thrown");

            }
            catch(ArgumentOutOfRangeException ex)
            {
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                Assert.Fail($"Expected {nameof(ArgumentOutOfRangeException)}");
            }
        }
    }
}
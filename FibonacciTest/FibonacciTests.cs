using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciCache;

namespace FibonacciTest
{
    [TestClass]
    public class FibonacciTests
    {
        Fibonacci fib;
        Fibonacci fibRedis;

        [TestInitialize]
        public void Initialize()
        {
            fib = new Fibonacci(new CacheInt());
            fibRedis = new Fibonacci(new CacheIntRedis());
        }

        [TestMethod]
        public void GetFibonacci1()
        {
            int expected = 1;

            Assert.AreEqual(expected, fib.GetNumber(1));
        }

        [TestMethod]
        public void GetFibonacci2()
        {
            int expected = 1;

            Assert.AreEqual(expected, fib.GetNumber(2));
        }

        [TestMethod]
        public void GetFibonacci5()
        {
            int expected = 5;

            Assert.AreEqual(expected, fib.GetNumber(5));
        }

        [TestMethod]
        public void GetFibonacci10()
        {
            int expected = 55;

            Assert.AreEqual(expected, fib.GetNumber(10));
        }

        [TestMethod]
        public void GetFibonacciRedis1()
        {
            int expected = 1;

            Assert.AreEqual(expected, fibRedis.GetNumber(1));
        }

        [TestMethod]
        public void GetFibonacciRedis2()
        {
            int expected = 1;

            Assert.AreEqual(expected, fibRedis.GetNumber(2));
        }

        [TestMethod]
        public void GetFibonacciRedis5()
        {
            int expected = 5;

            Assert.AreEqual(expected, fibRedis.GetNumber(5));
        }

        [TestMethod]
        public void GetFibonacciRedis10()
        {
            int expected = 55;

            Assert.AreEqual(expected, fibRedis.GetNumber(10));
        }
    }
}

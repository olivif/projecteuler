﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetDivisors()
        {
            var divisors = new List<int>();

            {
                //220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110
                divisors = Utils.GetDivisors(220).ToList();

                Assert.AreEqual(divisors.Count, 11);
                Assert.AreEqual(divisors.Sum(), 284);
            }

            {
                //284 are 1, 2, 4, 71 and 142
                divisors = Utils.GetDivisors(284).ToList();

                Assert.AreEqual(divisors.Count, 5);
                Assert.AreEqual(divisors.Sum(), 220);
            }
        }

        [TestMethod]
        public void GetFactorial()
        {
            //4! = 1×2×3×4 = 24
            Assert.AreEqual(Utils.GetFactorial(4), 24);

            //5! = 1×2×3×4×5 = 120
            Assert.AreEqual(Utils.GetFactorial(5), 120);
        }

        [TestMethod]
        public void GetCombiations()
        {
            Assert.AreEqual(Utils.GetCombinations(3, 2), 3);
            Assert.AreEqual(Utils.GetCombinations(5, 2), 10);
        }
    }
}
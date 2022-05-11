using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHall.Game;
using System;
using System.Collections.Generic;

namespace MontyHall.Test
{
    [TestClass]
    public class TestMonty
    {
        private readonly MontyGame _montygame;
        private int[] _simulationNoArray = new int[] { 100, 1000, 10000, 100000, 1000000, 10000000 };
        public TestMonty()
        {
            _montygame = new MontyGame();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var simulationNo = 1000;
            var withChangeDoor = _montygame.Run(simulationNo, true);
            var withNoChangeDoor = _montygame.Run(simulationNo, false);
            Assert.IsTrue(withChangeDoor.TrueGuess > withNoChangeDoor.TrueGuess);
        }
        [TestMethod]
        public void TestMethod2()
        {
            for (int i = 0; i < _simulationNoArray.Length; i++)
            {
                var result = _montygame.Run(_simulationNoArray[i], true);
                Assert.AreEqual((result.TrueGuess+result.WrongGuess), _simulationNoArray[i]);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            for (int i = 0; i < _simulationNoArray.Length; i++)
            {
                var result = _montygame.Run(_simulationNoArray[i], true);
                var trueTowrong = (double)(result.TrueGuess / result.WrongGuess);
                Assert.IsTrue(trueTowrong >1);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            for (int i = 0; i < _simulationNoArray.Length; i++)
            {
                var result = _montygame.Run(_simulationNoArray[i], false);
                var wrongToTrue = (double)(result.WrongGuess / result.TrueGuess);
                Assert.IsTrue(wrongToTrue >1);
            }
        }
    }
}
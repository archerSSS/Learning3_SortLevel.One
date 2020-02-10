using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 1, 3, 4, 7, 9, 10 };

            BinarySearch BS = new BinarySearch(array);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(3);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(2, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(3);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(2, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_1()
        {
            int[] array = new int[] { 1, 3, 4, 7, 9, 10, 11, 12 };

            BinarySearch BS = new BinarySearch(array);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(7);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(3, BS.Right);
            Assert.AreEqual(0, BS.GetResult());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSelection_1()
        {
            int[] array = new int[] { 7, 42, 25 };
            SortLevel.SelectionSortStep(array, 1);

            Assert.AreEqual(7, array[0]);
            Assert.AreEqual(25, array[1]);
            Assert.AreEqual(42, array[2]);
            Assert.AreEqual(3, array.Length);
        }

        [TestMethod]
        public void TestSelection_2()
        {
            int[] array = new int[] { 7, 42, 25, 82, 5, 20 };
            int[] expay = new int[] { 7, 5, 25, 82, 42, 20 };
            SortLevel.SelectionSortStep(array, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestSelection_3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };
            SortLevel.SelectionSortStep(array, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestSelection_4()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            int[] expay = new int[] { 1, 4, 3, 2, 5 };
            SortLevel.SelectionSortStep(array, 0);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestSelection_5()
        {
            int[] array = new int[] { 1, 4, 5, 2, 3 };
            int[] expay = new int[] { 1, 2, 5, 4, 3 };
            SortLevel.SelectionSortStep(array, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_1()
        {
            int[] array = new int[] { 1, 4, 5, 2, 3 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(true, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_3()
        {
            int[] array = new int[] { 3, 5, 4, 1, 2 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_4()
        {
            int[] array = new int[] { 2, 3, 4, 5, 1 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_5()
        {
            int[] array = new int[] { 2, 1, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }
    }
}

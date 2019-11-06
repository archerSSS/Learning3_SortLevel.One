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

            Assert.AreEqual(false, SortLevel.BubbleSortAll(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(true, SortLevel.BubbleSortAll(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_3()
        {
            int[] array = new int[] { 3, 5, 4, 1, 2 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortAll(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_4()
        {
            int[] array = new int[] { 2, 3, 4, 5, 1 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortAll(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubbles_5()
        {
            int[] array = new int[] { 2, 1, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortAll(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_1()
        {
            int[] array = new int[] { 2, 1, 3, 4, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_2()
        {
            int[] array = new int[] { 1, 5, 3, 4, 2 };
            int[] expay = new int[] { 1, 3, 4, 2, 5 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_3()
        {
            int[] array = new int[] { 4, 3, 1, 2 };
            int[] expay1 = new int[] { 3, 1, 2, 4 };
            int[] expay2 = new int[] { 1, 2, 3, 4 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay1[i], array[i]);

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay2[i], array[i]);

            Assert.AreEqual(true, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay2[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_4()
        {
            int[] array = new int[] { 7, 5, 3, 1, -1 };
            int[] expay1 = new int[] { 5, 3, 1, -1, 7 };
            int[] expay2 = new int[] { 3, 1, -1, 5, 7 };
            int[] expay3 = new int[] { 1, -1, 3, 5, 7 };
            int[] expay4 = new int[] { -1, 1, 3, 5, 7 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay1[i], array[i]);

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay2[i], array[i]);

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay3[i], array[i]);

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay4[i], array[i]);

            Assert.AreEqual(true, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay4[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_5()
        {
            int[] array = new int[] { 1, -3 };
            int[] expay = new int[] { -3, 1 };

            Assert.AreEqual(false, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);

            Assert.AreEqual(true, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestBubble_6()
        {
            int[] array = new int[] { 2, 2, 2 };
            int[] expay = new int[] { 2, 2, 2 };

            Assert.AreEqual(true, SortLevel.BubbleSortStep(array));
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsert_1()
        {
            int[] array = new int[] { 1, 3, 5, 2, 8 };
            int[] expay = new int[] { 1, 2, 5, 3, 8 };

            SortLevel.InsertSortStep(array, 2, 1);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsert_2()
        {
            int[] array = new int[] { 6, 3, 5, 2, 8, 4, 1 };
            int[] expay = new int[] { 1, 3, 5, 2, 8, 4, 6 };

            SortLevel.InsertSortStep(array, 3, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }
    }
}

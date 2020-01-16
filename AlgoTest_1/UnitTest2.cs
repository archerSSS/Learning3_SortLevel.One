using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestHeapSort_1()
        {
            int[] array = new int[] { 3, 10, 1, 8, 5, 9, 6, 2, 7, 4 };
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(10, hs.GetNextMax());
            Assert.AreEqual(9, hs.GetNextMax());
            Assert.AreEqual(8, hs.GetNextMax());
            Assert.AreEqual(7, hs.GetNextMax());
            Assert.AreEqual(6, hs.GetNextMax());
            Assert.AreEqual(5, hs.GetNextMax());
            Assert.AreEqual(4, hs.GetNextMax());
            Assert.AreEqual(3, hs.GetNextMax());
            Assert.AreEqual(2, hs.GetNextMax());
            Assert.AreEqual(1, hs.GetNextMax());
            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(15, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_2()
        {
            int[] array = new int[] { 9, 8, 4, 6, 7, 1 };
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(9, hs.GetNextMax());
            Assert.AreEqual(8, hs.GetNextMax());
            Assert.AreEqual(7, hs.GetNextMax());
            Assert.AreEqual(6, hs.GetNextMax());
            Assert.AreEqual(4, hs.GetNextMax());
            Assert.AreEqual(1, hs.GetNextMax());
            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(7, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_3()
        {
            int[] array = new int[11];
            HeapSort hs = new HeapSort(array);
            
            Assert.AreEqual(-1, hs.GetNextMax());
            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(15, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_4()
        {
            int[] array = new int[1];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(1, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_5()
        {
            int[] array = new int[2];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(3, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_6()
        {
            int[] array = new int[3];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(3, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_7()
        {
            int[] array = new int[4];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(7, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_8()
        {
            int[] array = new int[6];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(7, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_9()
        {
            int[] array = new int[7];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(7, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_10()
        {
            int[] array = new int[8];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(15, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_11()
        {
            int[] array = new int[16];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(31, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_12()
        {
            int[] array = new int[31];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(31, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_13()
        {
            int[] array = new int[32];
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(-1, hs.GetNextMax());

            Assert.AreEqual(63, hs.HeapObject.HeapArray.Length);
        }

        [TestMethod]
        public void TestHeapSort_14()
        {
            int[] array = new int[] { 5, 2, 3, 1, 4 };
            HeapSort hs = new HeapSort(array);

            Assert.AreEqual(5, hs.GetNextMax());
            Assert.AreEqual(4, hs.GetNextMax());

            Assert.AreEqual(7, hs.HeapObject.HeapArray.Length);
        }
    }
}

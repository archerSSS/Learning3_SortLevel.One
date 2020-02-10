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
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(3);
            Assert.AreEqual(1, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(3);
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
            Assert.AreEqual(7, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_2()
        {
            int[] array = new int[] { 1, 3, 4, 7, 9, 10, 11, 12 };

            BinarySearch BS = new BinarySearch(array);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(9);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(7, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(9);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(9);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }
        
        //
        // Test Array with 5 elements
        //  Finding last element in a few steps
        //
        [TestMethod]
        public void Test_StepContinuous_3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            BinarySearch BS = new BinarySearch(array);
            
            BS.Step(5);
            Assert.AreEqual(3, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(5);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(5);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(5);
            Assert.AreEqual(4, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        //
        // Test Array with 6 elements
        //  Finding last element in a few steps
        //
        [TestMethod]
        public void Test_StepContinuous_4()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(6);
            Assert.AreEqual(3, BS.Left);
            Assert.AreEqual(5, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(5, BS.Left);
            Assert.AreEqual(5, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(5, BS.Left);
            Assert.AreEqual(5, BS.Right);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(5, BS.Left);
            Assert.AreEqual(5, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }
        
        [TestMethod]
        public void Test_StepResult_1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);
            Assert.AreEqual(0, BS.GetResult());
            Assert.AreEqual(0, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(1);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(1, BS.Right);

            Assert.AreEqual(0, BS.GetResult());
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(1, BS.GetResult());
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(3);
            Assert.AreEqual(1, BS.GetResult());
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_4()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(5);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(5);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(5);
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_5()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(7);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(7);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(7);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(7);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_6()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(8);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_7()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(0);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_8()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(0);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest4
    {

        // Test for v.0.4
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
            Assert.AreEqual(1, BS.GetResult());

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
            Assert.AreEqual(1, BS.GetResult());
        }
        
        //
        // Test for v.0.4
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
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(5, BS.Left);
            Assert.AreEqual(5, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        //
        // Test for v.0.4
        //
        // Second element find.
        //  6 elements-array
        //
        [TestMethod]
        public void Test_StepContinuous_5()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(2);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(2);
            Assert.AreEqual(1, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(2);
            Assert.AreEqual(1, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_6()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(2);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(2);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(4, BS.Right);
            Assert.AreEqual(1, BS.GetResult());
        }

        //
        // Test for v.0.4
        //
        [TestMethod]
        public void Test_StepContinuous_7()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(1);
            Assert.AreEqual(0, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(1, BS.Left);
            Assert.AreEqual(1, BS.Right);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_8()
        {
            int[] array = new int[] { 0, 1, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(2);
            BS.Step(2);
            BS.Step(2);
            BS.Step(2);
            BS.Step(2);

            Assert.AreEqual(-1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_9()
        {
            int[] array = new int[] { -1, 1, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(0);
            BS.Step(0);
            BS.Step(0);
            BS.Step(0);
            BS.Step(0);

            Assert.AreEqual(-1, BS.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_10()
        {
            int[] array = new int[] { 1, 3, 5, 7, 9, 11 };

            BinarySearch BS0 = new BinarySearch(array);
            BinarySearch BS1 = new BinarySearch(array);
            BinarySearch BS2 = new BinarySearch(array);
            BinarySearch BS3 = new BinarySearch(array);
            BinarySearch BS4 = new BinarySearch(array);
            BinarySearch BS5 = new BinarySearch(array);
            BinarySearch BS6 = new BinarySearch(array);

            BS0.Step(0);
            BS0.Step(0);
            Assert.AreEqual(-1, BS0.GetResult());

            BS1.Step(2);
            BS1.Step(2);
            Assert.AreEqual(-1, BS1.GetResult());

            BS2.Step(4);
            BS2.Step(4);
            Assert.AreEqual(-1, BS2.GetResult());

            BS3.Step(6);
            BS3.Step(6);
            Assert.AreEqual(-1, BS3.GetResult());

            BS4.Step(8);
            BS4.Step(8);
            Assert.AreEqual(-1, BS4.GetResult());

            BS5.Step(10);
            BS5.Step(10);
            Assert.AreEqual(-1, BS5.GetResult());

            BS6.Step(12);
            BS6.Step(12);
            Assert.AreEqual(-1, BS6.GetResult());
        }

        [TestMethod]
        public void Test_StepContinuous_11()
        {
            int[] array = new int[] { 1, 3, 5, 7, 9, 11, 13 };

            BinarySearch BS0 = new BinarySearch(array);
            BinarySearch BS1 = new BinarySearch(array);
            BinarySearch BS2 = new BinarySearch(array);
            BinarySearch BS3 = new BinarySearch(array);
            BinarySearch BS4 = new BinarySearch(array);
            BinarySearch BS5 = new BinarySearch(array);
            BinarySearch BS6 = new BinarySearch(array);

            BS0.Step(0);
            BS0.Step(0);
            Assert.AreEqual(-1, BS0.GetResult());

            BS1.Step(2);
            BS1.Step(2);
            Assert.AreEqual(-1, BS1.GetResult());

            BS2.Step(4);
            BS2.Step(4);
            Assert.AreEqual(-1, BS2.GetResult());

            BS3.Step(6);
            BS3.Step(6);
            Assert.AreEqual(-1, BS3.GetResult());

            BS4.Step(8);
            BS4.Step(8);
            Assert.AreEqual(-1, BS4.GetResult());

            BS5.Step(10);
            BS5.Step(10);
            Assert.AreEqual(-1, BS5.GetResult());

            BS6.Step(12);
            BS6.Step(12);
            Assert.AreEqual(-1, BS6.GetResult());
        }

        [TestMethod]
        public void Test_StepResult_1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);
            Assert.AreEqual(0, BS.GetResult());
            Assert.AreEqual(0, BS.GetResult());
        }

        //
        // Test for v.0.4
        //
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
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.4
        //
        [TestMethod]
        public void Test_StepResult_7()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(0);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(0);
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
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());

            BS.Step(0);
            Assert.AreEqual(-1, BS.GetResult());
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.4
        //
        [TestMethod]
        public void Test_StepResult_9()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(1);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(1, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_10()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(1);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_11()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(1);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(1);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_12()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(6);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_13()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 7, 8 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(6);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(6);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_14()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(8);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_15()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(8);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(8);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_16()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6 };

            BinarySearch BS = new BinarySearch(array);
            
            BS.Step(-1);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_17()
        {
            int[] array = new int[] { 0, 2, 3, 4, 5, 6, 7 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(-1);
            Assert.AreEqual(0, BS.GetResult());

            BS.Step(-1);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_18()
        {
            int[] array = new int[] { 0, 2, 3, 5 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(4);
            Assert.AreEqual(-1, BS.GetResult());
        }

        //
        // Test for v.0.5
        //
        [TestMethod]
        public void Test_StepResult_19()
        {
            int[] array = new int[] { 0, 2, 3, 5, 6 };

            BinarySearch BS = new BinarySearch(array);

            BS.Step(4);
            Assert.AreEqual(-1, BS.GetResult());
        }
    }
}

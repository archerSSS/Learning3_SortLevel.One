using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
        public void TestInsertAll_1()
        {
            int[] array = new int[] { 1, 3, 5, 2, 8 };
            int[] expay = new int[] { 1, 2, 5, 3, 8 };

            SortLevel.InsertSortStep(array, 2, 1);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_2()
        {
            int[] array = new int[] { 6, 3, 5, 2, 8, 4, 1 };
            int[] expay = new int[] { 1, 3, 5, 2, 8, 4, 6 };

            SortLevel.InsertSortStep(array, 3, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_3()
        {
            int[] array = new int[] { 2, 2, 2 };
            int[] expay = new int[] { 2, 2, 2 };

            SortLevel.InsertSortStep(array, 3, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_4()
        {
            int[] array = new int[] { 9, 5, 7, 11, 3, 1, 6 };
            int[] expay = new int[] { 3, 5, 6, 11, 7, 1, 9 };

            SortLevel.InsertSortStep(array, 2, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_5()
        {
            int[] array = new int[] { 4, 3, 2, -1 };
            int[] expay = new int[] { -1, 2, 3, 4 };

            SortLevel.InsertSortStep(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_6()
        {
            int[] array = new int[] { 4, 3, 2, -1 };
            int[] expay = new int[] { 4, 3, 2, -1 };

            SortLevel.InsertSortStep(array, 4, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_7()
        {
            int[] array = new int[] { 4, 3, 2, -1 };
            int[] expay = new int[] { -1, 3, 2, 4 };

            SortLevel.InsertSortStep(array, 3, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_8()
        {
            int[] array = new int[] { 1 };
            int[] expay = new int[] { 1 };

            SortLevel.InsertSortStep(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertAll_9()
        {
            int[] array = new int[1];
            int[] expay = new int[1];

            SortLevel.InsertSortStep(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);

            Assert.AreEqual(0, expay[0]);
            Assert.AreEqual(0, array[0]);
        }

        [TestMethod]
        public void TestInsertAll_10()
        {
            int[] array = new int[] { 0, 0, 1, 0, 0 };
            int[] expay = new int[] { 0, 0, 1, 0, 0 };

            SortLevel.InsertSortStep(array, 0, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertStep_1()
        {
            int[] array = new int[] { 0, 0, 1, 0, 0 };
            int[] expay = new int[] { 0, 0, 0, 0, 1 };

            SortLevel.InsertSortSingle(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertStep_2()
        {
            int[] array = new int[] { 2, 4, 1, 3, 7 };
            int[] expay = new int[] { 2, 3, 1, 4, 7 };

            SortLevel.InsertSortSingle(array, 2, 1);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertStep_3()
        {
            int[] array = new int[] { 8, 4, 5, 11, 2, 1 };
            int[] expay = new int[] { 5, 4, 2, 11, 8, 1 };

            SortLevel.InsertSortSingle(array, 2, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertStep_4()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            int[] expay = new int[] { 4, 3, 2, 1, 5 };

            SortLevel.InsertSortSingle(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestInsertStep_5()
        {
            int[] array = new int[] { 3, 2, 1, 5, 4 };
            int[] expay = new int[] { 2, 1, 3, 4, 5 };

            SortLevel.InsertSortSingle(array, 1, 0);
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestKnuth_1()
        {
            int[] array = new int[] { 1 };
            int[] expay = new int[] { 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_2()
        {
            int[] array = new int[] { 3, 2, 1, 5, 4 };
            int[] expay = new int[] { 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_3()
        {
            int[] array = new int[] { 3, 2, 1, 5, 4, 1, 56, 2, 5, 6, 4, 3, 11, 20, 42 };
            int[] expay = new int[] { 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_4()
        {
            int[] array = new int[72];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_5()
        {
            int[] array = new int[120];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_6()
        {
            int[] array = new int[121];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 121, 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_7()
        {
            int[] array = new int[405];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 364, 121, 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_8()
        {
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_9()
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_10()
        {
            int[] array = new int[12];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_11()
        {
            int[] array = new int[13];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_12()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_13()
        {
            int[] array = new int[40];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestKnuth_14()
        {
            int[] array = new int[45];
            for (int i = 0; i < array.Length; i++) array[i] = i;
            int[] expay = new int[] { 40, 13, 4, 1 };

            int count = 0;
            List<int> list = SortLevel.KnuthSequence(array.Length);
            foreach (Int32 n in list)
            {
                Assert.AreEqual(expay[count], n);
                count++;
            }
        }

        [TestMethod]
        public void TestShellSort_1()
        {
            int[] array = new int[] { 12, 8, 17, 13, 10, 16, 15, 2, 5, 1, 4, 6, 14, 7, 11, 9, 3 };
            SortLevel.ShellSort(array);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(i + 1, array[i]);
        }

        [TestMethod]
        public void TestShellSort_2()
        {
            int[] array = new int[] { 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 35, 34, 33, 32, 31, 17, 16, 15, 14, 13, 12, 11, 10, 30, 29, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expay = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
            SortLevel.ShellSort(array);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestShellSort_3()
        {
            int[] array = new int[] { 3, 2, 1 };
            int[] expay = new int[] { 1, 2, 3 };
            SortLevel.ShellSort(array);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestShellSort_4()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };
            SortLevel.ShellSort(array);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestShellSort_5()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            int[] expay = new int[] { 0, 33, 11, 7, 9 };
            SortLevel.ShellSort(array);

            for (int i = 0; i < array.Length; i++)
                Assert.IsTrue(expay[i] != array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_1()
        {
            int[] array = new int[] { 7, 5, 6, 4, 3, 1, 2 };
            int[] expay = new int[] { 2, 1, 3, 4, 6, 5, 7 };
            Assert.AreEqual(3, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_2()
        {
            int[] array = new int[] { 4, 3, 9, 1, 2 };
            int[] expay = new int[] { 4, 2, 3, 1, 9 };
            Assert.AreEqual(4, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_3()
        {
            int[] array = new int[] { 9, 6, 8, 7, 5, 4, 1, 2, 3 };
            int[] expay = new int[] { 3, 2, 1, 4, 5, 7, 8, 6, 9 };
            Assert.AreEqual(4, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_4()
        {
            int[] array = new int[] { 9, 6, 8, 7, 5, 4, 1, 2 };
            int[] expay = new int[] { 2, 4, 1, 5, 7, 8, 6, 9 };
            Assert.AreEqual(3, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_5()
        {
            int[] array = new int[] { 7, 4, 9, 1, 6, 10 };
            int[] expay = new int[] { 1, 4, 9, 6, 7, 10 };
            Assert.AreEqual(0, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }
    }
}

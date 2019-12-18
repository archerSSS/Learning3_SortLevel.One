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
        public void TestLomuto_1()
        {
            int[] array = new int[] { 3, 2, 1 };
            int[] expay = new int[] { 1, 3, 2 };
            // SortLevel.ArrayLomuto(array, 0, 0, 2);

            // for (int i = 0; i< array.Length; i++) Assert.AreEqual(expay[i], array[i]);
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
            int[] expay = new int[] { 4, 3, 2, 1, 9 };
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
            int[] expay = new int[] { 2, 1, 4, 5, 6, 7, 8, 9 }; 
            Assert.AreEqual(4, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestArrayChunk_5()
        {
            int[] array = new int[] { 7, 4, 9, 1, 6, 10 };
            int[] expay = new int[] { 1, 4, 9, 7, 6, 10 };
            Assert.AreEqual(0, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }
        
        [TestMethod]
        public void TestArrayChunk_6()
        {
            int[] array = new int[] { 1, 3, 4, 6, 5, 2, 8 };
            int[] expay = new int[] { 1, 3, 4, 2, 5, 6, 8 };
            Assert.AreEqual(5, SortLevel.ArrayChunk(array));

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_1()
        {
            int[] array = new int[] { 1, 3, 4, 6, 5, 2, 8 };
            int[] expay = new int[] { 1, 2, 3, 4, 5, 6, 8 };
            SortLevel.QuickSort(array, 0, 6);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_2()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5 };
            int[] expay = new int[] { 1, 2, 4, 5, 7, 8 };
            SortLevel.QuickSort(array, 0, 5);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_3()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5 };
            int[] expay = new int[] { 4, 2, 7, 1, 5, 8 };
            SortLevel.QuickSort(array, 3, 5);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_4()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5 };
            int[] expay = new int[] { 2, 4, 7, 1, 8, 5 };
            SortLevel.QuickSort(array, 0, 2);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_5()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5 };
            int[] expay = new int[] { 4, 1, 2, 7, 8, 5 };
            SortLevel.QuickSort(array, 1, 4);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_6()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5, 3, 9, 15, 11, 13, 12, 14 };
            int[] expay = new int[] { 4, 2, 7, 1, 8, 5, 3, 9, 11, 12, 13, 14, 15 };
            SortLevel.QuickSort(array, 6, 12);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_7()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5, 3, 9, 15, 11, 13, 12, 14 };
            int[] expay = new int[] { 4, 2, 7, 1, 3, 5, 8, 9, 15, 11, 13, 12, 14 };
            SortLevel.QuickSort(array, 3, 8);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_8()
        {
            int[] array = new int[] { 4, 2, 7, 1, 8, 5, 3, 9, 15, 11, 13, 12, 14 };
            int[] expay = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 15, 11, 13, 12, 14 };
            SortLevel.QuickSort(array, 0, 8);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_9()
        {
            int[] array = new int[] { 2, 3, 1 };
            int[] expay = new int[] { 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 2);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_10()
        {
            int[] array = new int[] { 3, 2, 1 };
            int[] expay = new int[] { 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 2);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_11()
        {
            int[] array = new int[] { 3, 2, 1, 0 };
            int[] expay = new int[] { 0, 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_12()
        {
            int[] array = new int[] { 3, 0, 1, 2 };
            int[] expay = new int[] { 0, 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_13()
        {
            int[] array = new int[] { 0, 3, 2, 1 };
            int[] expay = new int[] { 0, 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_14()
        {
            int[] array = new int[] { 2, 1 };
            int[] expay = new int[] { 1, 2 };
            SortLevel.QuickSort(array, 0, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_15()
        {
            int[] array = new int[] { 2, 1, 3 };
            int[] expay = new int[] { 1, 2, 3 };
            SortLevel.QuickSort(array, 0, 2);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_16()
        {
            int[] array = new int[] { 1 };
            int[] expay = new int[] { 1 };
            SortLevel.QuickSort(array, 0, 0);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_17()
        {
            int[] array = new int[] { 1, 2 };
            int[] expay = new int[] { 1, 2 };
            SortLevel.QuickSort(array, 0, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSort_18()
        {
            int[] array = new int[5000];
            int[] expay = new int[5000];
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 2500)
                {
                    array[i] = i;
                    expay[i] = i;
                }
                else
                {
                    array[i] = 2500 - i;
                    expay[i] = i;
                }
            }
            SortLevel.QuickSort(array, 0, 4999);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_1()
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            int[] expay = new int[] { 1, 2, 3, 4 };
            SortLevel.QuickSortTailOptimization(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_2()
        {
            int[] array = new int[] { 1, 3, 2, 4 };
            int[] expay = new int[] { 1, 2, 3, 4 };
            SortLevel.QuickSortTailOptimization(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_3()
        {
            int[] array = new int[] { 8, 2, 3, 1 };
            int[] expay = new int[] { 1, 2, 3, 8 };
            SortLevel.QuickSortTailOptimization(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_4()
        {
            int[] array = new int[] { 7, 4, 1, 5, 2 };
            int[] expay = new int[] { 1, 4, 5, 7, 2 };
            SortLevel.QuickSortTailOptimization(array, 0, 3);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_5()
        {
            int[] array = new int[] { 7, 4, 1, 5, 2 };
            int[] expay = new int[] { 7, 1, 2, 4, 5 };
            SortLevel.QuickSortTailOptimization(array, 1, 4);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_6()
        {
            int[] array = new int[50];
            int[] expay = new int[50];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 150 - i;
                expay[i] = 101 + i;
            }
            SortLevel.QuickSortTailOptimization(array, 0, 49);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_7()
        {
            int[] array = new int[500];
            int[] expay = new int[500];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1500 - i;
                expay[i] = 1001 + i;
            }
            SortLevel.QuickSortTailOptimization(array, 0, 499);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_8()
        {
            int[] array = InstantiateArray_1();
            int[] expay = InstantiateArray_2();
            
            SortLevel.QuickSortTailOptimization(array, 0, 4999);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_9()
        {
            int[] array = new int[] { 4, 3, 2, 1, 5 };
            int[] expay = new int[] { 1, 2, 3, 4, 5 };
            SortLevel.QuickSortTailOptimization(array, 0, 4);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_10()
        {
            int[] array = new int[] { 5, 4, 1, 2, 6, 3 };
            int[] expay = new int[] { 1, 2, 3, 4, 5, 6 };
            SortLevel.QuickSortTailOptimization(array, 0, 5);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestQuickSortTailOptimization_11()
        {
            int[] array = new int[] { 5, 4 };
            int[] expay = new int[] { 4, 5 };
            SortLevel.QuickSortTailOptimization(array, 0, 1);

            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(expay[i], array[i]);
        }

        [TestMethod]
        public void TestKthOrderTest_1()
        {
            int[] array = new int[] { 5, 4, 1, 2, 6, 3, 8, 7 };
            List<int> list = SortLevel.KthOrderStatisticsStep(array, 0, 7, 3);
        }

        [TestMethod]
        public void TestKthOrderTest_2()
        {
            int[] a1 = new int[] { 1, 2, 6, 8, 11 };
            int[] a2 = new int[] { 3, 4, 5, 13, 20 };
            int[] ar = new int[] { 15, 9, 10, 1, 2, 6, 8, 11, 3, 4, 5, 13, 20, 18, 7, 16, 21, 0 };
            int[] r = new int[] { 5, 7 };
            int[] array = new int[] { 15, 9, 10, 2, 6, 8, 11, 1, 5, 3, 13, 4, 20, 18, 7, 16, 21, 0 };
            List<int> list = SortLevel.KthOrderStatisticsStep(array, 3, 12, 7);

            int c = 0;
            foreach (int i in list)
            {
                Assert.AreEqual(r[c], i);
                c++;
            }

            for (int i = 0; i < ar.Length; i++) Assert.AreEqual(ar[i], array[i]);
        }

        [TestMethod]
        public void TestKthOrderTest_3()
        {
            int[] a1 = new int[] { 1, 2, 6, 8, 11 };
            int[] a2 = new int[] { 3, 4, 5, 13, 20 };
            int[] ar = new int[] { 15, 9, 10, 1, 2, 6, 8, 11, 3, 4, 5, 13, 20, 18, 7, 16, 21, 0 };
            int[] r = new int[] { 5, 7 };
            int[] array = new int[] { 15, 9, 10, 2, 6, 8, 11, 1, 5, 3, 13, 4, 20, 18, 7, 16, 21, 0 };
            List<int> list = SortLevel.KthOrderStatisticsStep(array, 3, 13, 7);

            int c = 0;
            foreach (int i in list)
            {
                Assert.AreEqual(r[c], i);
                c++;
            }

            for (int i = 0; i < ar.Length; i++) Assert.AreEqual(ar[i], array[i]);
        }

        [TestMethod]
        public void TestKthOrderTest_4()
        {
            int[] a1 = new int[] { 2, 6, 9, 10, 15 };
            int[] a2 = new int[] { 1, 3, 5, 8, 11 };
            int[] a3 = new int[] { 4, 13 };
            int[] ar = new int[] { 2, 6, 9, 10, 15, 1, 3, 5, 8, 11, 4, 13, 20, 18, 7, 16, 21, 0 };
            int[] r = new int[] { 2, 3 };
            int[] array = new int[] { 15, 9, 10, 2, 6, 8, 11, 1, 5, 3, 13, 4, 20, 18, 7, 16, 21, 0 };
            List<int> list = SortLevel.KthOrderStatisticsStep(array, 0, 12, 3);

            int c = 0;
            foreach (int i in list)
            {
                Assert.AreEqual(r[c], i);
                c++;
            }

            for (int i = 0; i < ar.Length; i++) Assert.AreEqual(ar[i], array[i]);
        }

        private int[] InstantiateArray_1()
        {
            int[] array = new int[5000];
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 2500)
                {
                    array[i] = i;
                }
                else
                {
                    array[i] = 2500 - i;
                }
            }
            return array;
        }

        private int[] InstantiateArray_2()
        {
            int[] expay = new int[5000];
            for (int i = 0; i < expay.Length; i++)
            {
                if (i > 2500)
                {
                    expay[i] = i;
                }
                else
                {
                    expay[i] = i;
                }
            }
            return expay;
        }
    }
}

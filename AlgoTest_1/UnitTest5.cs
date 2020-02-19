using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest5
    {

        //
        // First
        //
        [TestMethod]
        public void TestGallopingSearch_1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 4));
        }

        //
        // First
        //
        [TestMethod]
        public void TestGallopingSearch_2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 4));
        }

        //
        // First
        //
        [TestMethod]
        public void TestGallopingSearch_3()
        {
            int[] array = new int[] { 1 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 1));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_4()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 1));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_5()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 2));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_6()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 3));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_7()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 4));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_8()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 1));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_9()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 2));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_10()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 3));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_11()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 4));
        }

        //
        // Second
        //
        [TestMethod]
        public void TestGallopingSearch_12()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 5));
        }

        //
        // Third
        //
        [TestMethod]
        public void TestGallopingSearch_13()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(!SortLevel.GallopingSearch(array, 0));
        }

        //
        // Third
        //
        [TestMethod]
        public void TestGallopingSearch_14()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.IsTrue(!SortLevel.GallopingSearch(array, 5));
        }

        //
        // Third
        //
        [TestMethod]
        public void TestGallopingSearch_15()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(!SortLevel.GallopingSearch(array, 0));
        }

        //
        // Third
        //
        [TestMethod]
        public void TestGallopingSearch_16()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(!SortLevel.GallopingSearch(array, 6));
        }
        
        //
        // Third
        //
        [TestMethod]
        public void TestGallopingSearch_17()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.IsTrue(SortLevel.GallopingSearch(array, 1));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 2));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 3));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 4));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 5));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 6));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 7));
            Assert.IsTrue(SortLevel.GallopingSearch(array, 8));

            Assert.IsTrue(!SortLevel.GallopingSearch(array, 0));
            Assert.IsTrue(!SortLevel.GallopingSearch(array, 9));
        }

        
    }
}

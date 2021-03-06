﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSpace;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestKSortIndex_1()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(0, ks.Index("a00"));
        }

        [TestMethod]
        public void TestKSortIndex_2()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(1, ks.Index("a01"));
        }

        [TestMethod]
        public void TestKSortIndex_3()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(10, ks.Index("a10"));
        }

        [TestMethod]
        public void TestKSortIndex_4()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(11, ks.Index("a11"));
        }

        [TestMethod]
        public void TestKSortIndex_5()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(100, ks.Index("b00"));
        }

        [TestMethod]
        public void TestKSortIndex_6()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(110, ks.Index("b10"));
        }

        [TestMethod]
        public void TestKSortIndex_7()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(401, ks.Index("e01"));
        }

        [TestMethod]
        public void TestKSortIndex_8()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(445, ks.Index("e45"));
        }

        [TestMethod]
        public void TestKSortIndex_9()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(489, ks.Index("e89"));
        }

        [TestMethod]
        public void TestKSortIndex_10()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(701, ks.Index("h01"));
        }

        [TestMethod]
        public void TestKSortIndex_11()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(799, ks.Index("h99"));
        }

        [TestMethod]
        public void TestKSortIndex_12()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("i01"));
        }

        [TestMethod]
        public void TestKSortIndex_13()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("i00"));
        }

        [TestMethod]
        public void TestKSortIndex_14()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("!00"));
        }

        [TestMethod]
        public void TestKSortIndex_15()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("00"));
        }

        [TestMethod]
        public void TestKSortIndex_16()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("!"));
        }

        [TestMethod]
        public void TestKSortIndex_17()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("j00"));
        }

        [TestMethod]
        public void TestKSortIndex_18()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("a-0"));
        }

        [TestMethod]
        public void TestKSortIndex_19()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("0a0"));
        }

        [TestMethod]
        public void TestKSortIndex_20()
        {
            Ksort ks = new Ksort();
            Assert.AreEqual(-1, ks.Index("00a"));
        }

        [TestMethod]
        public void TestKSortAdd_1()
        {
            Ksort ks = new Ksort();
            Assert.IsFalse(ks.Add("00a"));
        }

        [TestMethod]
        public void TestKSortAdd_2()
        {
            Ksort ks = new Ksort();
            Assert.IsTrue(ks.Add("a00"));
        }

        [TestMethod]
        public void TestKSortAdd_3()
        {
            Ksort ks = new Ksort();
            Assert.IsTrue(ks.Add("g72"));
        }

        [TestMethod]
        public void TestKSortAdd_4()
        {
            Ksort ks = new Ksort();
            Assert.IsFalse(ks.Add("!"));
        }

        [TestMethod]
        public void TestKSortAdd_5()
        {
            Ksort ks = new Ksort();
            Assert.IsFalse(ks.Add("j20"));
        }

        [TestMethod]
        public void TestKSortAdd_6()
        {
            Ksort ks = new Ksort();
            Assert.IsTrue(ks.Add("a01"));
            Assert.IsTrue(ks.Add("a01"));
        }

        [TestMethod]
        public void TestKSortAdd_7()
        {
            Ksort ks = new Ksort();
            ks.Add("b11");
            Assert.IsTrue(ks.items[111] != null);
            Assert.IsTrue(ks.items[110] == null);
            Assert.IsTrue(ks.items[101] == null);
            Assert.IsTrue(ks.items[011] == null);
            Assert.IsTrue(ks.items[010] == null);
            Assert.IsTrue(ks.items[001] == null);
            Assert.IsTrue(ks.items[211] == null);
            Assert.IsTrue(ks.items[210] == null);
            Assert.IsTrue(ks.items[201] == null);
            Assert.IsTrue(ks.items[200] == null);

            ks.Add("a11");
            Assert.IsTrue(ks.items[011] != null);

            ks.Add("c11");
            Assert.IsTrue(ks.items[211] != null);
        }

        [TestMethod]
        public void TestKSortAdd_8()
        {
            Ksort ks = new Ksort();
            Assert.IsTrue(!ks.Add(""));
        }

        [TestMethod]
        public void TestKSortAdd_9()
        {
            Ksort ks = new Ksort();
            Assert.IsTrue(!ks.Add(null));
        }

        [TestMethod]
        public void TestKSortAdd_10()
        {
            Ksort ks = new Ksort();
            ks.Index("a00");
            ks.Index("c54");
            
            ks.Add("a00");
            ks.Add("c54");
            ks.Add("h99");
            Assert.AreEqual("a00", ks.items[ks.Index("a00")]);
            Assert.AreEqual("c54", ks.items[ks.Index("c54")]);
            Assert.AreEqual("h99", ks.items[ks.Index("h99")]);
        }
    }
}

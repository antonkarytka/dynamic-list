using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicList;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestItems()
        {
            int[] desiredList = new int[] { 1, 2, 3 };
            var list = new DynamicList<int> {1, 2, 3};
            for (var i = 0; i < list.Count; i++)
                Assert.AreEqual(list.Items[i], desiredList[i]);
        }

        [TestMethod]
        public void TestCount()
        {
            int[] desiredList = new int[] { 1, 2, 3, 4, 5 };
            DynamicList<int> list = new DynamicList<int> {1, 2, 3, 4, 5};
            Assert.AreEqual(list.Count, desiredList.Length);
        }

        [TestMethod]
        public void TestAdd()
        {
            int[] desiredList = new int[] {123, 456, 789};
            DynamicList<int> list = new DynamicList<int> {123, 456, 789};
            Assert.AreEqual(list.Items[0], desiredList[0]);
            Assert.AreEqual(list.Items[1], desiredList[1]);
            Assert.AreEqual(list.Items[2], desiredList[2]);
        }

        [TestMethod]
        public void TestRemove()
        {
            int[] desiredList = new int[] { 123, 789 };
            DynamicList<int> list = new DynamicList<int> {123, 456, 456, 456, 789};
            list.Remove(456);
            int i = 0;
            foreach (int item in list)
            {
                Assert.AreEqual(item, desiredList[i]);
                i++;
            }
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            int[] desiredList = new int[] { 34, 56 };
            DynamicList<int> list = new DynamicList<int> {12, 34, 56};
            list.RemoveAt(0);
            int i = 0;
            foreach (int item in list)
            {
                Assert.AreEqual(item, desiredList[i]);
                i++;
            }
        }
    }
}

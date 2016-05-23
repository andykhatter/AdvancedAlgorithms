using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructInterfaces;
using AdvancedDatastructures.ArrayListImpl;

namespace DatastructureTests
{
    [TestFixture]
    public class ArrayGaddamnListTest
    {
        [Test]
        public void TestAdd()
        {
            IArrayGaddamnList<string> list = new ArrayGaddamnList<string>();
            list.Add("list1");
            list.Add("list2");
             Assert.AreEqual(2, list.Add("list3"));
             Console.ReadKey();
        }
    }
}

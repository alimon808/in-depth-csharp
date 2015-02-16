using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class Collections
    {
        public static readonly int[] Seeds = { 10, 20 };

        [Test]
        public void ArrayBasics()
        {
            int[] array = new int[10];

            Assert.AreEqual(10, array.Length);
            Assert.AreEqual(0, array[0]);
        }

        [Test]
        public void Mutability()
        {
            Seeds[0] = 100;
            Assert.AreEqual(100, Seeds[0]);
        }

        [Test]
        public void ListBasics()
        {
            List<string> names = new List<string>();
            names.Add("fred");
            Assert.AreEqual("fred", names[0]);
            Assert.AreEqual(1, names.Count);
            names.Add("betty");
            Assert.AreEqual(2, names.Count);
            names.RemoveAt(0);
            Assert.AreEqual("betty", names[0]);
            Assert.AreEqual(1, names.Count);
        }

        [Test]
        public void DictionaryBasics()
        {
            var map = new Dictionary<string, int>();
            map.Add("foo", 10);
            map["bar"] = 20;

            foreach (var entry in map)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

            int value = map["bar"];
            Assert.AreEqual(20, value);

            int value2;
            bool keyFound = map.TryGetValue("blah", out value2);
            Assert.IsFalse(keyFound);
            Assert.AreEqual(0, value2);

            keyFound = map.TryGetValue("foo", out value2);
            Assert.IsTrue(keyFound);
            Assert.AreEqual(10, value2);

            map = new Dictionary<string, int>{
                {"xyz", 3},
                {"abc", 4}
            };

            
        }

        [Test]
        public void Generics()
        {
            Fred<string> fred = new Fred<string>("hi");
            Assert.AreEqual("hi", fred.Foo());

            Fred<int> fred2 = new Fred<int>(100);
            Assert.AreEqual(100, fred2.Foo());
        }

        public class Fred<T>
        {
            T greeting;
            public Fred(T greeting)
            {
                this.greeting = greeting;
            }
            public T Foo()
            {
                return greeting;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleMethodInterface()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);
        }

        [Test]
        public void SimpleDelegateFromMethod()
        {
            Delegates target = new Delegates("Jon");
            Int32Action action = new Int32Action(target.RandomRob);
            action.Invoke(5);
        }

        [Test]
        public void DelegateFromStaticMethod()
        {
            Int32Action action = new Int32Action(Delegates.StaticRob);
            action.Invoke(7);
        }

        [Test]
        public void Multicast()
        {
            Int32Action action1 = new Int32Action(Delegates.StaticRob);
            Int32Action action2 = new Int32Action(Delegates.StaticRob2);
            Int32Action action3 = action1 + action2;
            action3.Invoke(20);
        }
    }
}

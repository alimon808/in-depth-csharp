using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    class FakeEventRaiserTest
    {
        private void ReportToConsole(string text)
        {
            Console.WriteLine("Called: {0}", text);
        }

        [Test]
        public void RaiseEvents()
        {

            FakeEventHandler handler = ReportToConsole;

            FakeEventRaiser raiser = new FakeEventRaiser();
            raiser.DoSomething("Not Subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed twice!");

            raiser.RemoveHandler(handler);
            raiser.RemoveHandler(handler);
            raiser.DoSomething("Unsubscribed");

        }
    }
}

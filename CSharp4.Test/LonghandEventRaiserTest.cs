using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    class LonghandEventRaiserTest
    {
        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("Report to console was called");
        }

        [Test]
        public void RaiseEvents()
        {

            ClickHandler handler = ReportToConsole;

            var raiser = new LonghandEventRaiser();
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click -= handler;
            raiser.Click -= handler;
            raiser.OnClick();

        }
    }
}

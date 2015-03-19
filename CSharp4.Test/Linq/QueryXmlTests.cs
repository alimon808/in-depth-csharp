using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;


namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class QueryXmlTests
    {
        [Test]
        public void ShouldQueryXml()
        {
            XDocument doc = new XDocument(
                new XElement("Processes", 
                    from p in Process.GetProcesses()
                    orderby p.ProcessName ascending
                    select new XElement("Process", 
                        new XAttribute("Name", p.ProcessName),
                        new XAttribute("PID", p.Id))));

            Console.WriteLine(doc);

            IEnumerable<int> pids = from e in doc.Descendants("Process")
                                    where e.Attribute("Name").Value == "devenv"
                                    orderby (int)e.Attribute("PID") ascending
                                    select (int)e.Attribute("PID");

            foreach (var pid in pids)
            {
                Console.WriteLine(pid);
            }
        }
    }
}

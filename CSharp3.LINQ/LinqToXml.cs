using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace CSharp3.LINQ
{
    public class LinqToXml
    {
        public void CreateSimpleXml()
        {
            XNamespace ns = "http://pluralsight.com/Modules";
            XNamespace ext = "http://pluralsight.com/Modules/ext";
            
            XDocument doc = new XDocument(
                new XElement(ns + "Modules", 
                    new XAttribute(XNamespace.Xmlns + "ext", ext),
                    new XElement(ns + "Module", "Introduction to LINQ"),
                    new XElement(ns + "Module", "LINQ and C#"),
                    new XElement(ext + "Extra", "Some Content"),
                    new XElement(ext + "Extra", "Extra content")));
            doc.Save("modules.xml");
        }

        // loading xml
        public void ReadSimpleXml()
        {
            XDocument doc = XDocument.Load("modules.xml");
            XElement root = doc.Root;
            var elements = root.Descendants();
            foreach (var elem in elements)
            {
                string value = elem.Value;
                Console.WriteLine(value);
            }
        }

        // parsing xml
        public void ParseXml()
        {
            XElement xml = XElement.Parse("<Employee Type=\"Developer\">Scott</Employee>");
            string name = (string)xml; // Scott
            string type = (string)xml.Attribute("Type"); // "Developer"

            double? salary = (double)xml.Attribute("Salary");  // null
            int age = (int)xml.Attribute("Age"); // exception
        }

        public void CreateTypeInfo()
        {
            XDocument doc = new XDocument(
                new XElement("Types",
                    Assembly.GetExecutingAssembly().GetReferencedAssemblies()
                        .Select(name => Assembly.Load(name))
                        .SelectMany(assembly => assembly.GetTypes())
                        .Select(type => new XElement("Type", type.FullName,
                                            new XAttribute("IsPublic", type.IsPublic)))));

            var publicTypes = doc.Element("Types").Elements("Type")
                                 .Where(e => (bool)e.Attribute("IsPublic") == true)
                                 .Select(e => e.Value)
                                 .OrderByDescending(s => s.Length);

            foreach (var name in publicTypes)
            {
                Console.WriteLine(name);
            }
        }
    }
}

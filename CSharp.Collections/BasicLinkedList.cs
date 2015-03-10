using System;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class BasicLinkedList
    {
        public LinkedList<string> Presidents()
        {
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            return presidents;
        }
    }
}

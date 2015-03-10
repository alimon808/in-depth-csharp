using System;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class BasicStack
    {
        public Stack<string> Books()
        {
            Stack<string> books = new Stack<string>();
            books.Push("Programming WPF");
            books.Push("The Philosophy Book");
            books.Push("Heat and Thermodynamics");
            books.Push("Harry Potter and the Chamber of Secrets");

            return books;
        }
    }
}

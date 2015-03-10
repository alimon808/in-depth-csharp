using System;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class BasicQueue
    {
        public Queue<string> Tasks()
        {
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finsih the C# Collections Pluralsight course");
            tasks.Enqueue("Buy some chocolate");
            tasks.Enqueue("Buy some more chocolate");

            return tasks;
        }
    }
}

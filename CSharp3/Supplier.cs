using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    public class Supplier
    {
        public int SupplierId { get; private set; }
        public string Name { get; private set; }

        public Supplier()
        {

        }

        public Supplier(int supplierId, string name)
        {
            SupplierId = supplierId;
            Name = name;
        }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>()
            {
                new Supplier{SupplierId = 1, Name = "Acme"},
                new Supplier{SupplierId = 2, Name = "Microsoft"},
                new Supplier{SupplierId = 3, Name = "Google"},
                new Supplier{SupplierId = 4, Name = "Apple"},
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", SupplierId, Name);
        }
    }
}

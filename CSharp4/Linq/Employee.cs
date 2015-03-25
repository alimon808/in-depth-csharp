using System;
using System.Collections.Generic;
namespace CSharp4.Linq
{
    public class Employee : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual ICollection<TimeCard> TimeCards { get; set; }
        public int DepartmentId { get; set; }
    }
}

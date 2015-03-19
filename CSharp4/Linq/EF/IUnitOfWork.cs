using System;
using System.Data.Entity.Core.Objects;

namespace CSharp4.Linq.EF
{
    public interface IUnitOfWork
    {
        IObjectSet<Employee> Employees { get; }
        IObjectSet<TimeCard> TimeCards { get; }
        void Commit();
    }
}

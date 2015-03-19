using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Linq.Custom
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IQueryable<Employee> FindManagers();
    }
}

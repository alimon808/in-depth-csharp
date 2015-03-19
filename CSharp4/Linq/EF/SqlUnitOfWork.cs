using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CSharp4.Linq.EF
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        readonly ObjectContext _context;
        //const string ConnectionStringName = "EmployeeDataModelContainer";

        public SqlUnitOfWork(string connectionString)
        {
            _context = new ObjectContext(connectionString);
            _context.ContextOptions.LazyLoadingEnabled = true;
        }

        public IObjectSet<Employee> Employees
        {
            get { return _context.CreateObjectSet<Employee>(); }
        }

        public IObjectSet<TimeCard> TimeCards
        {
            get { return _context.CreateObjectSet<TimeCard>(); }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

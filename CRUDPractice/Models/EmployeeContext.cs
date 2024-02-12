using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDPractice.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

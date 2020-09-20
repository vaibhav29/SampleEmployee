using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleEmployee.Model;

namespace SampleEmployee.Data
{
    public class SampleEmployeeContext : DbContext
    {
        public SampleEmployeeContext (DbContextOptions<SampleEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<SampleEmployee.Model.EmpMaster> EmpMaster { get; set; }
        public DbSet<EmpMasterDetails> EmpMasterDetails { get; set; }
    }
}

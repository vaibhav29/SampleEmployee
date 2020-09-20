using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.Model
{
    public class EmpMasterDetails // Models 
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public int EmployeeMasterId { get; set; }

    }
}

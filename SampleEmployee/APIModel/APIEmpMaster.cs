using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.APIModel
{
    public class APIEmpMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int MobileNumber { get; set; }
        public string Region { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
    }
}

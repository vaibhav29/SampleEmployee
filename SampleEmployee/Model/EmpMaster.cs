using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.Model
{
    public class EmpMaster : CommonFields
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int MobileNumber { get; set; }
        public string Region { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.Model
{
    public class CommonFields
    {
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isasctive { get; set; }
    }
}

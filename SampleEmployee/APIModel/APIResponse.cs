using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.APIModel
{
    public class APIResponse
    {
        public int StatusCode { get; set; }
        public Object ResponseObject { get; set; }
        public string Description { get; set; }
    }
}

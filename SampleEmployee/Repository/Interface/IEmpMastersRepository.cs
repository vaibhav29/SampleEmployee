using SampleEmployee.APIModel;
using SampleEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleEmployee.Repository.Interface
{
    public interface IEmpMastersRepository : IRepository<EmpMaster>
    {
        //Use of interface in which methods are declared and implemented in repository.
        //Use of OOPS Concept.
        Task<APIResponse>SaveData(APIEmpMaster empMaster);
        Task<List<APIEmpMaster>> GetAll(int page, int pagesize);
    }
}

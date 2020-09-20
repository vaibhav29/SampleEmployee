using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SampleEmployee.APIModel;
using SampleEmployee.Data;
using SampleEmployee.Model;
using SampleEmployee.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEmployee.Repository
{
    public class EmpMastersRepository : Repository<EmpMaster>,IEmpMastersRepository
    {
        private SampleEmployeeContext db;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        private IConfiguration _configuration;
        public EmpMastersRepository(SampleEmployeeContext employeeContext
        , IConfiguration configuration)
            : base(employeeContext)
        {
            db = employeeContext;
            _configuration = configuration;
    }

        public async Task<APIResponse> SaveData(APIEmpMaster empMaster)
        {
            APIResponse aPI = new APIResponse();
            EmpMaster emp = new EmpMaster();
            EmpMasterDetails empdetails = new EmpMasterDetails();
            if (empMaster.UserId != null)
            {
                emp.Name = empMaster.Name;
                emp.Region = empMaster.Region;
                emp.UserId = empMaster.UserId;
                emp.MobileNumber = empMaster.MobileNumber;
                emp.Isdeleted = false;
                emp.Isasctive = true;
                emp.Createdby = 1;
                emp.Modifiedby = 1;
                emp.CreatedDate = DateTime.Now;
                
                this.db.EmpMaster.Add(emp);
                await this.db.SaveChangesAsync();
                int id = 0;
                id = await this.db.EmpMaster.Where(r => r.UserId.Contains(empMaster.UserId)).Select(r => r.Id).FirstOrDefaultAsync();
                if (id != 0)
                {
                    empdetails.Address = empMaster.Address;
                    empdetails.City = empMaster.City;
                    empdetails.Designation = empMaster.Designation;
                    empdetails.EmailId = empMaster.EmailId;
                    empdetails.EmployeeMasterId = id;

                    this.db.EmpMasterDetails.Add(empdetails);
                    await this.db.SaveChangesAsync();

                }
                else
                {
                    aPI.StatusCode = 400;
                    aPI.Description = "Invalid";
                }
                aPI.StatusCode = 200;
                aPI.Description = empMaster.Name;
                
            }
            else 
            {
                aPI.StatusCode = 400;
                aPI.Description = "Invalid Data";

            }
            return aPI;
        }
        public async Task<List<APIEmpMaster>> GetAll(int page, int pagesize)
        {
            //Use of IQueyable with inner join
            IQueryable<APIEmpMaster> aPISave = (from emp in db.EmpMaster
                                                           join empdetails in db.EmpMasterDetails on emp.Id equals empdetails.EmployeeMasterId
                                                          where (emp.Isdeleted == false )
                                                           select new APIEmpMaster
                                                           {
                                                               Id = emp.Id,
                                                               Name = emp.Name,
                                                               EmailId = empdetails.EmailId,
                                                               UserId = emp.UserId,
                                                               MobileNumber = emp.MobileNumber,
                                                               Region= emp.Region,
                                                               City = empdetails.City,
                                                               Address= empdetails.Address,
                                                               Designation = empdetails.Designation
                                                           });
            //code for pagination.
            if (page != -1)
                aPISave = aPISave.Skip((Convert.ToInt32(page) - 1) * Convert.ToInt32(pagesize));
            if (pagesize != -1)
                aPISave = aPISave.Take(Convert.ToInt32(pagesize));
            return await aPISave.ToListAsync();
        }
    }
}

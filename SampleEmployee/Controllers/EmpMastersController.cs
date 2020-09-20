using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SampleEmployee.APIModel;
using SampleEmployee.Data;
using SampleEmployee.Model;
using SampleEmployee.Repository;
using SampleEmployee.Repository.Interface;

namespace SampleEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpMastersController : ControllerBase
    {
        private readonly SampleEmployeeContext _context;
        private IEmpMastersRepository _empmastersrespository;
        private IConfiguration _configuration;
      //  private IHttpContextAccessor _httpContextAccessor;

        public EmpMastersController(SampleEmployeeContext context, IEmpMastersRepository empmastersrespository,IConfiguration configuration
           )
        {
            _context = context;
            _empmastersrespository = empmastersrespository;
            _configuration = configuration;
            //_httpContextAccessor = httpContextAccessor;
        }

       
        // GET: api/EmpMasters/1/10
        [HttpGet("{page}/{pagesize}")]
        public async Task<ActionResult> GetEmpMaster(int page,int pagesize)
        {
           // return Ok();
            return Ok(await _empmastersrespository.GetAll(page,pagesize));
        }

        // POST: api/EmpMasters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for

        [HttpPost]
        public async Task<ActionResult> PostEmpMaster([FromBody]APIEmpMaster empMaster)
        {
            //Api used for adding entries in table
            return Ok(await _empmastersrespository.SaveData(empMaster));
           
        }
       
    }
}

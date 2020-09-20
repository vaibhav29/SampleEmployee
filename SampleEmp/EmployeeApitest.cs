using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SampleEmp
{
    public class EmployeeApitest
    {
        [Fact]
        public async Task Test_GetAll()
        {
            var Client = new TestClientProgram().Client;
            var response = await Client.GetAsync("/api/EmpMasters/1/10");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

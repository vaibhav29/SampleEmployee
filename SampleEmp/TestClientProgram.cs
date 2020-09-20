using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MySql.Data.MySqlClient.Memcached;
using SampleEmployee;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SampleEmp
{
    public class TestClientProgram
    {
        public HttpClient Client { get; set; }
        public TestClientProgram()
            {
                var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
            }
    }
}

using GC.WebApi.Tests.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GC.WebApi.Tests.Helpers
{
    public class ApiClient
    {
        public static async Task<EmployeeResponse> Create(Employee employee)
        {
            var httpClient = CreateHttpClient();
            var httpResponseMessage = await httpClient.PostAsync("create", new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8));
            var json = await httpResponseMessage.Content.ReadAsStringAsync();
            var employeeResponse = JsonConvert.DeserializeObject<EmployeeResponse>(json);

            return employeeResponse;
        }
        private static HttpClient CreateHttpClient()
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(@"http://dummy.restapiexample.com/api/v1/")
            };
        }
    }
}

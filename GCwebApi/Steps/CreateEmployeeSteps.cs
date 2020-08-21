using GC.WebApi.Tests.Entities;
using GC.WebApi.Tests.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GC.WebApi.Tests.Steps
{
    [Binding]
    public class CreateEmployeeSteps
    {
        private EmployeeResponse _response;

        [When(@"I create a new employee \((.*),(.*),(.*)\)")]
        public async void WhenICreateANewEmployee(string name, decimal salary, int age)
        {
            var employeeToCreate = new Employee()
            {
                Name = name,
                Salary = salary,
                Age = age
            };

            _response = await ApiClient.Create(employeeToCreate);
        }

        [Then(@"the system should return a valid object with (.*)")]
        public void ThenTheSystemShouldReturnAValidObjectWithStatus(string status)
        {
            Assert.IsNotNull(_response);
            Assert.AreEqual(status, _response.Status);
        }

        [Then(@"response should contain valid (.*)")]
        public void ThenResponseShouldContainValidName(string name)
        {
            Assert.IsNotNull(_response);
            Assert.AreEqual(name, _response.Employee.Name);
        }

    }
}

using System;
using TechTalk.SpecFlow;

namespace GC.WebApi.Tests.Steps
{
    [Binding]
    public class DisplayEmployeesDetailsSteps
    {
        [When(@"I use Get all employee data API")]
        public void WhenIUseGetAllEmployeeDataApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"response should contain records in specific first and last employee from the list with a valid \((.*),(.*),(.*)\)")]
        public void ThenResponseShouldContainRecordsInSpecificFirstAndLastEmployeeFromTheListWithAValidTigerNixon(decimal p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }


}

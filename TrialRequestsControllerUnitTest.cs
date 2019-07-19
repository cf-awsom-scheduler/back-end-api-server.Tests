using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using awsomAPI.Controllers;
using awsomAPI.Models;
using Xunit;
using Newtonsoft.Json;

namespace awsomAPI.Tests
{
    public class TrialRequestsControllerUnitTest
    {
        [Fact]
        public async Task TestAddNewTrialRequest()
        {
            // Arrange.
            var dbContext = DbContextMocker.GetAwsomApiContext(nameof(TestAddNewTrialRequest));
            var controller = new TrialRequestController(dbContext);
            var testRequest = new TrialRequest
            {
                Id = 4,
                ParentName = "Tammy Nguyen",
                StudentName = "Tammy",
                StudentBirthDate = "2004-01-18",
                Email = "testy@hotmail.com",
                Phone = "5192061234",
                Address = "2 N 120th Place SW",
                City = "Kirkland",
                ZipCode = "98034",
                Region = "WA",
                Instrument = "piano",
                HasInstrument = null,
                Availability = "{\"day\":\"monday\",\"fromTime\":\"10\",\"toTime\":\"12\"}",
                Experience = "no",
                Notes = "no"
            };

            // Act.
            var response = await controller.AddNewTrialRequest(testRequest);
            var insertedTrialRequest = response.Value;
            Console.Write(response);

            dbContext.Dispose();

            // Assert.

            Assert.Equal(testRequest, insertedTrialRequest);

        }

        [Fact]
        public async Task TestGetAllTrialRequests()
        {
            // Arrange.
            
            // Act.
            // Assert.
        }
        
    };
}

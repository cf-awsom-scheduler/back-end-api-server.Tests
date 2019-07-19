using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using awsomAPI.Models;

namespace awsomAPI.Tests.Controllers
{
  public class TrialRequestTests : IClassFixture<CustomWebAppFactory<Startup>>
  {
    private readonly HttpClient _client;

    public TrialRequestTests(CustomWebAppFactory<Startup> factory)
    {
      _client = factory.CreateClient();
    }

    [Fact]
    public async Task CanNotGetWhenUnauthorized()
    {
      HttpResponseMessage httpResponse = await _client.GetAsync("/trialRequests");
      HttpStatusCode status = httpResponse.StatusCode;
      Assert.Equal(HttpStatusCode.Forbidden, status);
    }

  //   [Fact]
  //   public async Task CanAddNewTrialRequest()
  //   {
  //     TrialRequest testRequest = new TrialRequest
  //       {
  //           Id = 4,
  //           ParentName = "Tammy Nguyen",
  //           StudentName = "Tammy",
  //           StudentBirthDate = "2004-01-18",
  //           Email = "testy@hotmail.com",
  //           Phone = "5192061234",
  //           Address = "2 N 120th Place SW",
  //           City = "Kirkland",
  //           ZipCode = "98034",
  //           Region = "WA",
  //           Instrument = "piano",
  //           HasInstrument = null,
  //           Availability = "{\"day\":\"monday\",\"fromTime\":\"10\",\"toTime\":\"12\"}",
  //           Experience = "no",
  //           Notes = "no"
  //       };

  //     string test = JsonConvert.SerializeObject(testRequest);
  //     var httpResponse = await _client.PostAsync("/trialRequests", test);
  //   }
  // }
  }
}
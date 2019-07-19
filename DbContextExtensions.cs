using System;
using System.Collections.Generic;
using System.Text;
using awsomAPI.Models;

namespace awsomAPI.Tests
{
    public static class DbContextExtensions
    {
        public static void Seed(this AwsomApiContext dbContext)
        {
            dbContext.TrialRequests.Add(new TrialRequest
            {
                Id = 1,
                ParentName = "Joe",
                StudentName = "Zeus",
                StudentBirthDate = null,
                Email = "test@domain.com",
                Phone = "123-456-7890",
                Address = "123 Test Ln",
                City = "Seattle",
                ZipCode = "98103",
                Region = "Seattle",
                Instrument = "Voice",
                HasInstrument = "true",
                Availability = null,
                Experience = null,
                Notes = null
            });
            dbContext.TrialRequests.Add(new TrialRequest
            {
                Id = 2,
                ParentName = "Bonnie Wang",
                StudentName = "bonnie",
                StudentBirthDate = "1994-05-18",
                Email = "testy@hotmail.com",
                Phone = "5192061234",
                Address = "2 N 120th Place SW",
                City = "Kirkland",
                ZipCode = "98034",
                Region = "WA",
                Instrument = "piano",
                HasInstrument = null,
                Availability = "{\"day\":\"monday\",\"fromTime\":\"10\",\"toTime\":\"11\"}",
                Experience = "no",
                Notes = "no"
            });
            dbContext.TrialRequests.Add(new TrialRequest
            {
                Id = 3,
                ParentName = "Nicholas Carignan",
                StudentName = "Ginger",
                StudentBirthDate = "2004-01-18",
                Email = "testy@hotmail.com",
                Phone = "5192061234",
                Address = "2 N 120th Place SW",
                City = "Kirkland",
                ZipCode = "98034",
                Region = "WA",
                Instrument = "voice",
                HasInstrument = null,
                Availability = "{\"day\":\"monday\",\"fromTime\":\"10\",\"toTime\":\"13\"}",
                Experience = "no",
                Notes = "no"
            });

            dbContext.SaveChanges();
        }
    }
}

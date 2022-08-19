using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using System;
using System.Linq;

namespace PropertySurveyService.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PropertySurveyServiceContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{Name="Craig Griffiths",Add1="56 Sunny Road",Add2="Bolton",Add3="Lancashire",Postcode="BL14NN",Phone1="07376559088",Phone2="",Phone3=""},
            };
            foreach (Customer c in customers)
            {
                context.Add(c);
            }

            var surveyors = new Surveyor[]
            {
                new Surveyor{Name="James Dean", SurveyorCode="H1"},
            };
            foreach (Surveyor s in surveyors)
            {
                context.Add(s);
            }

            context.SaveChanges();


        }
    }
}

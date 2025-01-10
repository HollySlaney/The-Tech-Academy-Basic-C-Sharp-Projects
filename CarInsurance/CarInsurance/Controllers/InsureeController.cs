using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private decimal CalculateQuote(Insuree insuree)
        {
            //Base rate
            insuree.Quote = 50.0m;

            //Pricing based on age
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (DateTime.Now.Date < insuree.DateOfBirth.AddYears(age))
            {
                age--;
            }
            if (age <= 18)
            {
                insuree.Quote += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                insuree.Quote += 50m;
            }
            else if (age >= 26)
            {
                insuree.Quote += 25m;
            }

            //Pricing based on year of car
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }

            //Pricing based on make and model of car
            if (insuree.CarMake.ToLower() == "porsche")
            {
                insuree.Quote += 25;

                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25;
                }
            }

            //Speeding tickets
            insuree.Quote += insuree.SpeedingTickets * 10;

            //DUI?
            if (insuree.DUI)
            {
                insuree.Quote *= 1.25m;
            }

            //Full coverage?
            if (insuree.CoverageType.ToString().ToLower() == "full")
            {
                return insuree.Quote;
            }
            insuree.Quote *= 1.50m;

            return insuree.Quote;
        }
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress from Insurees";
            List<Insuree> insurees = new List<Insuree>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var insuree = new Insuree();
                    insuree.Id = Convert.ToInt32(reader["Id"]);
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insurees.Add(insuree);
                }
            }
            return View(insurees);
        }
    }
}

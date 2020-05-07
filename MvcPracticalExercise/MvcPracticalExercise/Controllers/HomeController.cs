using MvcPracticalExercise.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPracticalExercise.Controllers
{
    public class HomeController : Controller
    {

        private readonly string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Quotes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, string DUI, int Tickets, string CoverageType)
        {

            if (!(DUI == "yes" || DUI == "Yes" || DUI == "no" || DUI == "No"))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            if (!(CoverageType != "Full" || CoverageType != "full" || CoverageType != "Liability" || CoverageType != "liability"))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                int userAge = DateTime.Now.Year - DateOfBirth.Year;

                double PriceQuote = 50;
                if (userAge < 25)
                {
                    PriceQuote += 25;
                }
                if (userAge < 18)
                {
                    PriceQuote += 75;
                }
                if (userAge > 100)
                {
                    PriceQuote += 100;
                }
                if (CarYear < 2000)
                {
                    PriceQuote += 25;
                }
                if (CarYear > 2015)
                {
                    PriceQuote += 50;
                }
                if (CarMake == "Porsche" || CarMake == "porsche")
                {
                    PriceQuote += 25;
                }
                if (CarMake == "Porsche" && CarModel == "Carrera" || CarMake == "porsche" && CarModel == "carrera")
                {
                    PriceQuote += 25;
                }
                if (Tickets > 0)
                {
                    Double TicketPrice = Tickets * 10;
                    PriceQuote += TicketPrice;
                }
                if (DUI == "Yes" || DUI == "yes")
                {
                    PriceQuote *= 1.25;
                }
                if (CoverageType == "Full" || CoverageType == "full")
                {
                    PriceQuote *= 1.5;
                }

                
                string queryString = @"INSERT INTO InsuranceQuote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Tickets, CoverageType, PriceQuote) 
                                    VALUES (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @Tickets, @CoverageType, @PriceQuote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@CoverageType", SqlDbType.VarChar);
                    command.Parameters.Add("@PriceQuote", SqlDbType.Int);



                    command.Parameters["@FirstName"].Value = FirstName.ToLower();
                    command.Parameters["@LastName"].Value = LastName.ToLower();
                    command.Parameters["@EmailAddress"].Value = EmailAddress.ToLower();
                    command.Parameters["@DateOfBirth"].Value = DateOfBirth;
                    command.Parameters["@CarYear"].Value = CarYear;
                    command.Parameters["@CarMake"].Value = CarMake.ToLower();
                    command.Parameters["@CarModel"].Value = CarModel.ToLower();
                    command.Parameters["@DUI"].Value = DUI.ToLower();
                    command.Parameters["@Tickets"].Value = Tickets;
                    command.Parameters["@CoverageType"].Value = CoverageType.ToLower();
                    command.Parameters["@PriceQuote"].Value = PriceQuote;

                    connection.Open();
                    try {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    connection.Close();

                }
                return RedirectToAction("QuotePage");
            }
        }


        public ActionResult QuotePage()
        {
            return View();
        }

        public ActionResult Admin()
        {

            string queryString = @"SELECT FirstName, LastName, EmailAddress, PriceQuote from InsuranceQuote";
            List<Quote> quotes = new List<Quote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new Quote
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        PriceQuote = Convert.ToInt32(reader["PriceQuote"]),
                    };
                    quotes.Add(quote);
                }
                connection.Close();
            }
            return View(quotes);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplying.Models;
using JobApplying.Models.Validators;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace JobApplying
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            /**var applier = new Applier()
            {
                City = "Tahta",
                Email = "engamaeaegmail.com",
                Position = new Position()
                {
                    Pos = "Manager"
                },
                Phone = "01011051728",
                BirthDate = new DateTime(1995,11,22),
                EnglishGrade = 73,
                ExpectedSalary = 4750.200,
                GraduatingYear = 2010,
                Name = "ali Ali Ham",
            };
            var r1 = new ValidateName().Valid(applier);
            var r2 = new ValidateEmail().Valid(applier);
            var r3 = new ValidateDates().Valid(applier);
            var r4 = new ValidatePhone().Valid(applier);
            var rr=new ValidateApplier(new List<IValidate<Applier>>
            {
                new ValidateDates(),
                new ValidateEmail(),
                new ValidateName(),
                new ValidatePhone()
            },applier ).Validate();
            var x = 13;
            **/
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
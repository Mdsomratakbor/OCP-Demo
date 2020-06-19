using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel> {
             new PersonModel { FirstName = "Moazzam", LastName = "Hossain" },
             new PersonModel { FirstName = "Md Somrat", LastName = "Akbor" },
             new PersonModel { FirstName = "Md Raihan", LastName = "Bhuian" },
             new PersonModel { FirstName = "Md Delwar", LastName = "Bhuian" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();
            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            foreach(var employee in employees)
            {
                Console.WriteLine($"FirstName :{employee.FirstName}, LastName :{employee.LastName}, EmailAddress :{employee.EmailAddress} {Environment.NewLine}");
            }
            Console.ReadLine();

        }
    }
}

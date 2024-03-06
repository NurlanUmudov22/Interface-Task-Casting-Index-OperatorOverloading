using Interface_Practise.Helpers.Constants;
using Interface_Practise.Models;
using Interface_Practise.Services;
using Interface_Practise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practise.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

            public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }


        public void GetAll()
        {
            var employees = _employeeService.GetAll();

            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                    $" {employee.Age} {employee.Email} {employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }           
        }



        public void GetById()
        {
            //int id = 3;
            //int? id = null;
            int id = 100;

            var response = _employeeService.GetById(_employeeService.GetAll(), id);

            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address}" +
                $" {response.Employee.Age} {response.Employee.Email} {response.Employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }


        public void Search()
        {
            Console.WriteLine("Add search text:");
            string searchText= Console.ReadLine();

            var response = _employeeService.Search(_employeeService.GetAll(), searchText);


            if(response.Length == 0)
            {
                Console.WriteLine(EmployeeResponseMessages.Notfound); 
                return;
            }
            else 
            {

                foreach (var employee in response)
                {
                    string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                        $" {employee.Age} {employee.Email} {employee.Birthday.ToString("MM-dd-yyyy")}";
                    Console.WriteLine(result);
                }


            }

        }







    }
}

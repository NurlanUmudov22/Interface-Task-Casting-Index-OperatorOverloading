using Interface_Practise.Helpers.Responses;
using Interface_Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practise.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();


        EmployeeResponse GetById(Employee[] employees, int? id);


        Employee[] Search(Employee[] employees, string searchText);
    }
}

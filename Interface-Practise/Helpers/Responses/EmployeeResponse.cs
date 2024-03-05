using Interface_Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practise.Helpers.Responses
{
    public class EmployeeResponse
    {
        public Employee Employee { get; set; }

        public string ErrorMessage { get; set; } 
    }
}

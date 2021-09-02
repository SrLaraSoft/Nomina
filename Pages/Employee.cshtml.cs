using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nomina.Pages
{
    public class EmployeeModel : PageModel
    {
        public List<Employee> Employees { get; set; }

        public void OnGet()
        {
            this.Employees = new List<Employee>()
            {
                new Employee(){ nombre = "Juan", apellido = "Lopez", cargo = "Programador", sueldo = 50000},
                new Employee(){ nombre = "Luis", apellido = "Ruiz", cargo = "Desarrollador", sueldo = 60000},
                new Employee(){ nombre = "Manuel", apellido = "Garcia", cargo = "Diseñador", sueldo = 45000},
                new Employee(){ nombre = "Katerin", apellido = "Perez", cargo = "Administrador", sueldo = 80000},
                new Employee(){ nombre = "Rossy", apellido = "Lora", cargo = "Asistente", sueldo = 30000}
            };

        }
    }
}


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
                new Employee(){ nombre = "Juan", apellido = "Lopez", cargo = "Programador", sueldo = 13482},
                new Employee(){ nombre = "Luis", apellido = "Ruiz", cargo = "Desarrollador", sueldo = 0},
                new Employee(){ nombre = "Manuel", apellido = "Garcia Rodriguez", cargo = "Diseñador", sueldo = 20000},
                new Employee(){ nombre = "Katerin", apellido = "Perez", cargo = "Administrador", sueldo = 269640},
                new Employee(){ nombre = "Rossy", apellido = "Lora", cargo = "Asistente", sueldo = 1},
                new Employee(){ nombre = "Juan", apellido = "Lopez", cargo = "Programador", sueldo = 28500},
                new Employee(){ nombre = "Luis", apellido = "Ruiz", cargo = "Desarrollador", sueldo = 21000},
                new Employee(){ nombre = "Manuel", apellido = "Garcia", cargo = "Diseñador", sueldo = 55000},
                new Employee(){ nombre = "Katerin", apellido = "Perez", cargo = "Administrador", sueldo = 70000},
                new Employee(){ nombre = "Rossy", apellido = "Lora", cargo = "Asistente", sueldo = 60000},
                };

        }
    }
}


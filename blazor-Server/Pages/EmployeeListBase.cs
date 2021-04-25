using blazor_Server.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace blazor_Server.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public bool ShowFooter { get; set; } = true;

        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {

            Employees = (await EmployeeService.GetEmployees()).ToList();
        }


    }
}

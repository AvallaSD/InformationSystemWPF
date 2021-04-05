using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class InfoSystem
    {

        public InfoSystem()
        {
            Employees = new List<Employee>();
            Institutions = new List<Institution>();
        }

        public List<Employee> Employees { get; }

        private List<Institution> Institutions { get; set; }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddInstitution(Institution institution)
        {
            Institutions.Add(institution);
        }

    }
}
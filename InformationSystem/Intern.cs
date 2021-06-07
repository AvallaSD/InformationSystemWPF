using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Intern : Employee, IExplorable
    {
        public Intern(string firstName, string surname, string lastName, DateTime birthDate )
            : this(firstName, surname, lastName, birthDate, GenerateSalary(10, 20))
        {
        }

        [JsonConstructor]
        public Intern(string firstName, string surname, string lastName, DateTime birthDate, int salary)
            : base(firstName, surname, lastName, birthDate, salary)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Chief : Employee
    {
        public Chief(string firstName, string surname, string lastName, DateTime birthDate, int workPlaceID)
            : this(firstName, surname, lastName, birthDate, workPlaceID, GenerateSalary(10, 20))
        {
        }

        public Chief(string firstName, string surname, string lastName, DateTime birthDate, int workPlaceID, int salary)
            : base(firstName, surname, lastName, birthDate, workPlaceID, salary)
        {
        }
    }
}
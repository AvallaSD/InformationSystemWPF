using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{

    public class Employee : IExplorable
    {
        /// <summary>
        /// Статический метод, генерирующий зарплаты
        /// </summary>
        static protected int GenerateSalary(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public Employee(string firstName, string surname, string lastName, DateTime birthDate)
            : this(firstName, surname, lastName, birthDate, GenerateSalary(100, 200))
        {
        }
        [JsonConstructor]
        public Employee(string firstName, string surname, string lastName, DateTime birthDate, int salary)
        {
            FirstName = firstName;
            Surname = surname;
            LastName = lastName;
            BirthDate = birthDate;
            AccessionDate = DateTime.Now;
            Salary = salary;
            FullName = Surname + " " + FirstName;         
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Дата вступления в должность
        /// </summary>
        public DateTime AccessionDate { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Место, где работает сотрудник
        /// </summary>
        
        public IExplorable WorkPlace { get; set; }

        /// <summary>
        /// Имя для показа в иерархии
        /// </summary>
        public string FullName { get; set; }

        public int WorkHours { get; set; }

        public string Present()
        {
            return $"First Name: {FirstName}\n" +
                $"Surname: {Surname}\n" +
                $"Last Name: {LastName}\n" +
                $"Birth Date: {BirthDate}\n" +
                $"Accession Date: {AccessionDate}\n" +
                $"Salary: {Salary}\n"+
                $"Work Place: {WorkPlace}";
        }
    }
}
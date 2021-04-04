using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Departament
    {
        /// <summary>
        /// Сортудники, работающие в данном департаменте
        /// </summary>
        public List<Employee> Employees { get; set; }

        /// <summary>
        /// Название департамента
        /// </summary>
        public int Name { get; set; }

        /// <summary>
        /// Глава департамента
        /// </summary>
        public Chief Superior { get; set; }

        /// <summary>
        /// Идентификатор департамента
        /// </summary>
        public int Id
        {
            get => default;
            set
            {
            }
        }

        public Institution Institution
        {
            get => default;
            set
            {
            }
        }
    }  
}
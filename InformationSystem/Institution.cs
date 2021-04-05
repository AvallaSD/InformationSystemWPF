using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    public class Institution
    {
        public Institution(Chief superior, string name)
        {
            Superior = superior;
            Name = name;
        }

        /// <summary>
        /// Департаменты, содержащиеся данным ведомством
        /// </summary>
        public List<Departament> Departaments
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Начальник ведомства
        /// </summary>
        public Chief Superior
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Ведомства, входящие в данное
        /// </summary>
        public List<Institution> LowerInstitutions
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Вышестоящее ведомство
        /// </summary>
        public Institution HigherInstitution
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int Id
        {
            get => default;
            set
            {
            }
        }
    }
}
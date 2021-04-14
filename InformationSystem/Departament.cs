using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InformationSystem
{
    public class Departament : IExplorable
    {
        /// <summary>
        /// Сортудники, работающие в данном департаменте
        /// </summary>
        public ObservableCollection<IExplorable> Children { get; set; }

        /// <summary>
        /// Название департамента
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Глава департамента
        /// </summary>
        public Chief Superior { get; set; }

        public Institution Parent
        {
            get => default;
            set
            {
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InformationSystem
{
    public class Departament : IExplorable
    {
        public Departament( Chief superior,string fullName)
        {
            FullName = fullName;
            Superior = superior;
            superior.WorkPlace = this;
            Children = new ObservableCollection<IExplorable>();
        }

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

        public Institution Parent { get; set; }

        public string Present()
        {
            return $"Departament Name: {FullName}\n\n" +
                $"Superior: {Superior.Present()}";
        }
    }
}
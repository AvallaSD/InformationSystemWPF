using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace InformationSystem
{
    public class Organisation
    {

        public Organisation()
        {

            ChiefsList = new ObservableCollection<Chief>();
            Children = new ObservableCollection<IExplorable>(); 
        }

        public ObservableCollection<IExplorable> Children { get; set; }

        public ObservableCollection<Chief> ChiefsList { get; set; }

        public void AddChief(Chief chief)
        {
            ChiefsList.Add(chief);
        }

        public void AddInstitution(Institution institution)
        {
            Children.Add(institution);
        }

        public void RecalculateSalaryes()
        {
            Children.ToList().ForEach(x => RecurseRecalculation(x as IWorkPlace));
        }

        private void RecurseRecalculation(IWorkPlace place)
        {
            var children = place.Children;
            var superior = place.Superior;

            if (place.Children.Any())
            {
                foreach (var child in children)
                {
                    if (child as IWorkPlace != null)
                    {
                        RecurseRecalculation(child as IWorkPlace);
                    }                   
                }
            }

            int superiorSalary = 0;

            if (place is Departament)
            {
                superiorSalary = (int)(children.Aggregate(0, (salarySum, x) => salarySum + (x as Employee).Salary) * 0.15);
            }

            if (place is Institution)
            {
                superiorSalary = children.Aggregate(0, (salarySum, x) => salarySum + (x as IWorkPlace).Superior.Salary);
            }
            superior.Salary = superiorSalary > 1300 ? superiorSalary : 1300;
        }

    }
}
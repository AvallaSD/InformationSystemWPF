using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InformationSystem
{
    public class Organisation
    {

        public Organisation()
        {
            Children = new ObservableCollection<IExplorable>();
            ChiefsList = new ObservableCollection<Chief>();
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

    }
}
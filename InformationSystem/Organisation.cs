using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;


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

        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InformationSystem
{
    /// <summary>
    /// Логика взаимодействия для InstitutionAdditionWindow.xaml
    /// </summary>
    public partial class InstitutionAdditionWindow : Window
    {
        List<Chief> chiefs;
        object selected;



        public InstitutionAdditionWindow(Organisation infoSystem, MainWindow main, object selected)
        {
            InitializeComponent();
            Organisatioin = infoSystem;
            Main = main;
            chiefs = infoSystem.ChiefsList.ToList();
            chiefComboBox.ItemsSource = chiefs.Where(x => x.WorkPlace == null).Select(x => $"{x.Surname} {x.FirstName}");
            this.selected = selected;
            
        }

        public MainWindow Main { get; set; }
        private Organisation Organisatioin { get; set; }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var newInstitution = new Institution(chiefs.ElementAt(chiefComboBox.SelectedIndex), name.Text);
            if (!(selected is Institution))
            {
                Organisatioin.AddInstitution(newInstitution);
            }
            else
            {
                ((Institution)selected).Children.Add(newInstitution);
            }
            
            
            Close();
            Main.Activate();
        }
    }
}

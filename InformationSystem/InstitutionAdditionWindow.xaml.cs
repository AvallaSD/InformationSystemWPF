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

        public InstitutionAdditionWindow(InfoSystem infoSystem)
        {
            InitializeComponent();
            InfoBase = infoSystem;
            chiefComboBox.ItemsSource = infoSystem.Employees.OfType<Chief>().Select(x=>$"{x.Surname} {x.FirstName}");
        }

        private InfoSystem InfoBase { get; set; }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            InfoBase.AddInstitution(new Institution((Chief)chiefComboBox.SelectedItem, name.Text);
        }
    }
}

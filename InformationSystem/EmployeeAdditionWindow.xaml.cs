using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EmployeeAdditionWindow.xaml
    /// </summary>
    public partial class EmployeeAdditionWindow : Window
    {
        
        public EmployeeAdditionWindow(InfoSystem infoBase)
        {
            InitializeComponent();
            InfoBase = infoBase;
            positionComboBox.ItemsSource = new List<string>() {"Начальник", "Интерн", "Сотрудник"};
        }

        public InfoSystem InfoBase { get; set; }

        public MainWindow Main { get; set; }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee recruit = null;
            try
            {
                switch (positionComboBox.SelectedIndex)
                {
                    case 0:
                        recruit = new Chief(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                        break;
                    case 1:
                        recruit = new Intern(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                        break;
                    case 2:
                        recruit = new Employee(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                        break;
                    default:
                        break;
                }
                InfoBase.AddEmployee(recruit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

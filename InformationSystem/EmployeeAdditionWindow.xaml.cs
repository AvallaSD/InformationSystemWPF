using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InformationSystem
{
    /// <summary>
    /// Логика взаимодействия для EmployeeAdditionWindow.xaml
    /// </summary>
    public partial class EmployeeAdditionWindow : Window
    {

        Organisation Organisation { get; set; }

        MainWindow Main { get; set; }

        IExplorable selected;

        public EmployeeAdditionWindow(Organisation infoBase, MainWindow main, IExplorable selected)
        {
            InitializeComponent();
            Organisation = infoBase;
            Main = main;
            this.selected = selected;
            positionComboBox.ItemsSource = new List<string>() {"Начальник", "Интерн", "Сотрудник"};
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!DateTime.TryParse(birthDateBox.Text,out DateTime date))
            {
                MessageBox.Show("Incorrext date format", "Error");
                Close();
                return;
            }
            Employee recruit;
            switch (positionComboBox.SelectedIndex)
            {
                case 0:
                    recruit = new Chief(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                    Organisation.AddChief(recruit as Chief);
                    break;
                case 1:
                    recruit = new Intern(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                    if (selected is Departament)
                    {
                        recruit.WorkPlace = selected;
                        (selected as Departament).Children.Add(recruit);                        
                    }
                    else
                    {
                        MessageBox.Show("Интерн может быть добавлен только в депаратамент", "Ошибка");
                    }
                    break;
                case 2:
                    recruit = new Employee(nameBox.Text, surnameBox.Text, lastNameBox.Text, DateTime.Parse(birthDateBox.Text));
                    if (selected is Departament)
                    {
                        recruit.WorkPlace = selected;
                        (selected as Departament).Children.Add(recruit);                       
                    }
                    else
                    {
                        MessageBox.Show("Соотрудник может быть добавлен только в депаратамент", "Ошибка");
                    }
                    break;
                default:
                    break;
            }      
            Close();
            Main.Activate();
        }
    }
}

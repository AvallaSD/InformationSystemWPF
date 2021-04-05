using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InfoSystem InfoBase { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InfoBase = new InfoSystem();
            employeesListBox.ItemsSource = InfoBase.Employees;

        }

        private void addEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAdditionWindow eaw = new EmployeeAdditionWindow(InfoBase);
            eaw.Show();
        }

        private void addInstitution_Click(object sender, RoutedEventArgs e)
        {
            InstitutionAdditionWindow iaw = new InstitutionAdditionWindow(InfoBase);
            iaw.Show();
        }
    }
}

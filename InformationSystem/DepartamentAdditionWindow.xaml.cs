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
    /// Логика взаимодействия для DepartamentAdditionWindow.xaml
    /// </summary>
    public partial class DepartamentAdditionWindow : Window
    {
        List<Chief> chiefs;
        object selected;

        public DepartamentAdditionWindow(Organisation infoSystem, MainWindow main, object selected)
        {
            InitializeComponent();
            Org = infoSystem;
            Main = main;
            chiefs = infoSystem.ChiefsList.ToList();
            chiefComboBox.ItemsSource = chiefs.Where(x => x.WorkPlace == null).Select(x => $"{x.Surname} {x.FirstName}");
            this.selected = selected;

        }

        public MainWindow Main { get; set; }
        private Organisation Org { get; set; }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var newDepartament = new Departament(chiefs.ElementAt(chiefComboBox.SelectedIndex), name.Text);
            if ((selected is Institution))
            {
                ((Institution)selected).Children.Add(newDepartament);
                Org.ChiefsList.Remove(chiefs.ElementAt(chiefComboBox.SelectedIndex));
            }
            else
            {
                MessageBox.Show("Департамент можно добавить только в ведомство");
            }

            

            Close();
            Main.Activate();
        }
    }
}

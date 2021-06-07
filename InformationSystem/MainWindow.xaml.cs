using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace InformationSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Organisation Organisation { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Organisation = new Organisation();
            treeView.ItemsSource = Organisation.Children;
        }

        private void addEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAdditionWindow eaw = new EmployeeAdditionWindow(Organisation, this, (IExplorable)treeView.SelectedItem);
            eaw.Show();

        }

        private void addInstitution_Click(object sender, RoutedEventArgs e)
        {
            InstitutionAdditionWindow iaw = new InstitutionAdditionWindow(Organisation, this, treeView.SelectedItem);
            iaw.Show();
        }

        private void addDepartament_Click(object sender, RoutedEventArgs e)
        {
            DepartamentAdditionWindow iaw = new DepartamentAdditionWindow(Organisation, this, treeView.SelectedItem);
            iaw.Show();
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            textBlock.Text = (e.NewValue as IExplorable).Present();
        }




        private void saveJson_Click(object sender, RoutedEventArgs e)
        {
            using (TextWriter stream = new StreamWriter("org.json"))
            {
                stream.Write(JsonConvert.SerializeObject(Organisation, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.All,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto
                }));
            }
        }

        private void loadJson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (TextReader stream = new StreamReader("org.json"))
                {
                    var stringOrg = stream.ReadToEnd().Trim();
                    Organisation = JsonConvert.DeserializeObject<Organisation>(stringOrg, new JsonSerializerSettings()
                    {
                        PreserveReferencesHandling = PreserveReferencesHandling.All,
                        TypeNameHandling = TypeNameHandling.Auto,
                        NullValueHandling = NullValueHandling.Include
                        
                    }) as Organisation;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
                throw ex;
            }
            treeView.ItemsSource = Organisation.Children;
        }
    }
}

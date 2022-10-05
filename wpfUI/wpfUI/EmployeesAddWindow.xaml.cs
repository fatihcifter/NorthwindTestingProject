using NorthWind.Controller;
using NorthWind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfUI
{
    /// <summary>
    /// Interaction logic for EmployeesAddWindow.xaml
    /// </summary>
    public partial class EmployeesAddWindow : Window
    {
        public EmployeesAddWindow()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employess employe = new Employess();
        
            employe.firstName = firstName.Text;
            employe.lastName = lastName.Text;
            employe.title = title.Text;
            employe.titleOfCourtesy = titleOfCourtesy.Text;
            employe.birthDate = birthDate.Text;

            employe.hireDate = hireDate.Text;
            employe.notes = notes.Text;
            employe.reportsTo = reportsTo.Text;

            employe.address = new Addresses();
            employe.address.street = street.Text;
            employe.address.city = city.Text;
            employe.address.region = region.Text;
            employe.address.postalCode = postalCode.Text;
            employe.address.country = country.Text;
            employe.address.phone = phone.Text;
            employe.territoryIds = new List<int>();

            employe.territoryIds.Add(int.Parse(territoryIds.Text));


            if (ButtonController.checker)
            {
                employe.id = int.Parse(id.Text);
                EmployessController.UpdateEmployess(employe);
            }
            else
            {
                EmployessController.PostEmployess(employe);
            }
        }
    }
}

using NorthWind.Controller;
using NorthWind.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindUI
{
    public partial class UpdateEmployess : Form
    {
        public UpdateEmployess()
        {
            InitializeComponent();
        }

        private void territoryAdd_Click(object sender, EventArgs e)
        {
          
            
            
            ListViewItem item = new ListViewItem(territoryId.Text);
            


            territoryView.Items.Add(item);

           
        }

        private void PostEmployess_Click(object sender, EventArgs e)
        {
            Employess employe = new Employess();
            employe.id = int.Parse(id.Text);
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




            foreach (ListViewItem eDetail in territoryView.Items)
            {

                employe.territoryIds.Add(int.Parse(eDetail.SubItems[0].Text));
            }
            EmployessController.UpdateEmployess(employe);
        }
    }
}

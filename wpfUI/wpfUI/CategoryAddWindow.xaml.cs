using NorthWind.Controller;
using NorthWind.Models;
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
using System.Windows.Shapes;

namespace wpfUI
{
    /// <summary>
    /// Interaction logic for CategoryAddWindow.xaml
    /// </summary>
    public partial class CategoryAddWindow : Window
    {
        public CategoryAddWindow()
        {
            InitializeComponent();
        }

        private async void addSupplier_Click(object sender, RoutedEventArgs e)
        {
            Categories category = new Categories();

            category.description = description.Text;
            category.name = name.Text;

            if (ButtonController.checker)
            {
                category.id = int.Parse(id.Text);
              await  CategoriesController.UpdateCategories(category);
            }
            else
            {
             await   CategoriesController.PostCategories(category);
            }

        
        }
    }
}

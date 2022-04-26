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

namespace FinaProjectAppFood
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Countries> allCountries;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DishData db = new DishData();

            var query = from d in db.CountriesDishes
                        orderby d.CountryName
                        select d;

            allCountries = query.ToList();

            lbxCountries.ItemsSource = allCountries;
        }

        private void lbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine  what was selected
            Countries selected = lbxCountries.SelectedItem as Countries;

            //check if it is not null
            if (selected != null)
            {
                //update display
                tblkDishDetails.Text = selected.GetDetails();
                imgDish.Source = new BitmapImage(new Uri(selected.DishImage, UriKind.Relative));
            }

            //update display
        }

        //filter method
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            string diettype = rb.Content.ToString();

            switch (diettype)
            {
                case "Vegetarian":
                    lbxCountries.ItemsSource = allCountries.Where(c => c.TraditionalDish.Contains("TE"));
                    break;
            }
        }
    }
}

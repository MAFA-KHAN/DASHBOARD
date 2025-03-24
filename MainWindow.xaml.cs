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

namespace PlaceHolderTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void PlaceHolderTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // You can handle the logic here for when the text changes
            // For example, you could print the new text to the console
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                System.Diagnostics.Debug.WriteLine("Text changed: " + textBox.Text);
            }
        }


        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ProfileMenu.Visibility = ProfileMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMenu.Visibility = EmployeeMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            CustomerMenu.Visibility = CustomerMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Supplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierMenu.Visibility = SupplierMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsMenu.Visibility = SettingsMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

    }
}
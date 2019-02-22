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
using System.IO;
using Microsoft.Win32;

namespace WPFCarRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User kc;
        public MainWindow()
        {
            InitializeComponent();
            kc = new User();

        }

        private void Selectimg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select an image";
            ofd.Filter = "All supported images |*.jpeg;*jpg;*.png";
            if (ofd.ShowDialog() == true)
            {
                imagebox.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            kc.Name = usernme.Text;
            kc.Address = addrtxt.Text;
            kc.hireDate = DateTime.Now.Year - datepicker.SelectedDate.Value.Year;
            
            kc.Gender = combo1.Text;
           
            kc.PicturePath = imagebox.Source.ToString();
            
            kc.PhoneNumber = numbertxt.Text;
            if (smallbtn.IsChecked == true)
            {
                kc.CarType[0] = "Small car";
            }
            if (mediumbtn.IsChecked == true)
            {
                kc.CarType[1] = "meduim car";

            }
            if (largebtn.IsChecked == true)
            {
                kc.CarType[2] = "large car";

            }
            if (onewk.IsChecked == true)
            {
                kc.Duration = "0-6";
            }
            if (twowks.IsChecked == true)
            {
                kc.Duration = "6-12";
            }
            if (onemonth.IsChecked == true)
            {
                kc.Duration = "13-18";
            }
            if (usernme.Text.Trim() == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Please enter something in the textbox");
                return;
            }
            kc.saveData();
            MessageBox.Show("thank you for submitting your request, we will be in touch shortly");
        }

        private void Usernme_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void smallbtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void mediumbtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void largebtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void onewk_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void twowks_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void onemonth_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}


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
            MessageBox.Show(datepicker.SelectedDate.Value.Year.ToString());
            kc.Gender = combo1.Text;
            MessageBox.Show(combo1.Text);
            kc.PicturePath = imagebox.Source.ToString();
            MessageBox.Show(imagebox.Source.ToString());
            kc.PhoneNumber = numbertxt.Text;
            if (smallbtn.IsChecked == true)
            {
                kc.carType[0] = "Small car";
            }
            if (mediumbtn.IsChecked == true)
            {
                kc.carType[1] = "meduim car";

            }
            if (largebtn.IsChecked == true)
            {
                kc.carType[2] = "large car";

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
            kc.saveData();
        }
    }
    }
}

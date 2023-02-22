using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp17
{
    public partial class MainWindow : Window
    {
        int n = 0;
        public MainWindow()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Book.ToList();
                foreach (Shop u in users)
                {
                    if(u.Id==1)
                    {
                        Name1.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price1.Content = $"{u.Price} uah";
                    }
                    if (u.Id == 2)
                    {
                        Name2.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price2.Content = $"{u.Price} uah";
                    }
                    if (u.Id == 3)
                    {
                        Name3.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price3.Content = $"{u.Price} uah";
                    }
                    if (u.Id == 4)
                    {
                        Name4.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price4.Content = $"{u.Price} uah";
                    }
                    if (u.Id == 5)
                    {
                        Name5.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price5.Content = $"{u.Price} uah";
                    }
                    if (u.Id == 6)
                    {
                        Name6.Content = $"\n{u.Name}\tРік: {u.Year}\nЖанр: {u.About}\tАвтор: {u.Author}";
                        Price6.Content = $"{u.Price} uah";
                    }

                }

            }

        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {

        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            n+=1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            n += 1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            n += 1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            n += 1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            n += 1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            n += 1;
            if (n > 0)
            {
                Num.Content = n;
            }
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}

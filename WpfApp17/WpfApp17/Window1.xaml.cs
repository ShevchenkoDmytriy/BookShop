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

namespace WpfApp17
{
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string log = Convert.ToString(Log1);
                string pas = Convert.ToString(Pas1);
                Use peop = new Use { Login = log, Password =pas };
                db.Users.Add(peop); 
                db.SaveChanges();
                this.Close();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string log = Convert.ToString(Log1);
                string pas = Convert.ToString(Pas1);
                var users = db.Users.ToList();
                foreach (Use u in users)
                {
                    if (u.Login == log & u.Password == pas)
                    {
                        this.Close();
                    }
                }

            }

        }
    }
}

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
            string log = Convert.ToString(Log1);
            string pas = Convert.ToString(Pas1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User peop=new User();
                var users = db.Users.ToList();
                foreach (User u in users)
                {


                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if()

                }

            }
            Close();
        }
    }
}

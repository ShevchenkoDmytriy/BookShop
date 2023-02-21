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
        public MainWindow()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                //Book book = new Book { Name = "qwqtqwt", Price = 12, About = "qwfqgqgqg", Num = 2, Coment = "qwfqgfwq" };
                //db.Add(book);
                //db.SaveChanges();
                var users = db.Books.ToList();
                foreach (Book u in users)
                {
                    Name1.Content = $"{u.Name}";
                }
            }
        }

        
    }
}

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
using System.Data.Entity;

namespace MyLastCoursWorkTry
{
    public partial class studentwindowauthoriz : Window
    {
        public static db.Model3 stlog = new db.Model3();
        Window2 stoc = new Window2();
        MainWindow mainmain = new MainWindow();
        public studentwindowauthoriz()
        {
            InitializeComponent();
        }

        private void StudentAuthorizButton(object sender, RoutedEventArgs e)
        {
            stlog.studentslogpass.Load();
            if (stlog.studentslogpass.Local.Where(x => x.Login == LoginBox.Text & x.Password == PasswordBox.Password).FirstOrDefault() != null)
            {
                stoc.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Неправильные логин или пароль");
                PasswordBox.Password = null;
            }

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainmain.Show();

        }

        
    }
}

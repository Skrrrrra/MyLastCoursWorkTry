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
using System.Data.Entity;

namespace MyLastCoursWorkTry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       TeacherOfMaths TOM = new TeacherOfMaths();
        public static db.Model2 user = new db.Model2(); 
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void AuthorizButton(object sender, RoutedEventArgs e)
        {
            user.userlogpass.Load();
            if (user.userlogpass.Local.Where(x => x.login == LoginBox.Text & x.password == PasswordBox.Password).FirstOrDefault() != null)
            {
                TOM.Show();
                this.Close();

            }

        }
    }
}

using MyLastCoursWorkTry.db;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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

namespace MyLastCoursWorkTry
{
    

    public partial class TeacherOfMaths : Window
    {
        AddWindow AW = new AddWindow();
        public static db.Model1 database = new db.Model1();

        
        public TeacherOfMaths()
        {
            InitializeComponent();
            database.StudentDB.Load();
            studentsgrid.ItemsSource = database.StudentDB.Local;

        }










        private void Button_DeleteSelectedRows_Click(object sender, RoutedEventArgs e)
        {
            StudentDB a = new StudentDB();
            a = (StudentDB)studentsgrid.SelectedItem;
            database.StudentDB.Load();
            database.StudentDB.Remove(a);
            database.SaveChanges();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AW.Show();
        }

        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


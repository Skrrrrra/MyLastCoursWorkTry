using MyLastCoursWorkTry.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
    
    public partial class AddWindow : Window
    {
        
        db.Model1 db = new db.Model1();
        public AddWindow()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, RoutedEventArgs e)
        {
            db.StudentDB.Load();
            
            
            StudentDB a = new StudentDB();
            a.FirstName = namebox.Text;
            a.SecondName = secondnamebox.Text;
            a.ThirdName = thirdnamebox.Text;
            a.Grade = gradebox.Text;

            if(mathbox.Text == "")
            {
                a.Math = null;
            }
            else a.Math = Convert.ToInt32(mathbox.Text);
            if (russianlangbox.Text == "")
            {
                a.RussianLanguage = null;
            }
            else a.RussianLanguage = Convert.ToInt32(russianlangbox.Text);
            if (englishlangbox.Text == "")
            {
                a.EnglishLanguage = null;
            }
            else a.EnglishLanguage = Convert.ToInt32(englishlangbox.Text);

            a.Date = Convert.ToDateTime(calendar1.SelectedDate);


            try
            {
                db.StudentDB.Add(a);
                db.SaveChanges(); 
                MessageBox.Show("Succesfull");
            }
            catch (DbEntityValidationException ex)
            {
                foreach(var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach(var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }













        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            TeacherOfMaths back = new TeacherOfMaths();
            Visibility = Visibility.Hidden;
            back.Show();
            

            try
            {
                back.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

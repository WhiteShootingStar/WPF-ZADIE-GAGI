using DeansOffice.Models;
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

namespace DeansOffice
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            var st3 = new Student { IdStudent = 4, FirstName = "Vitua", LastName = "krasnow", StudentId = 230, Status = "Expelled", Year = 2018, Semestr = "17/18", Specialization = "Dudka", Info = "kek ",  Date ="12/13/19"};
            PESEL.Text = "228332";
            SEX.Text = "Male";
            SEMEST.Text = st3.Semestr;
            SPECIALIZATION.Text = st3.Specialization;
            STUDENT_NUMBER.Text = st3.StudentId.ToString();
            YEAR.Text = st3.Year.ToString();
            Adress.Text = "ul.Pushkina Dom Kolotushkina";
            NAME.Text = st3.FirstName;
            DATE.Text = System.DateTime.Now.ToString();
            TEL.Text = "123456789";
            Random a = new Random();
            int debt = a.Next();
            if (a.NextDouble() > 0.5)
            {
               debt *= -1;
                DEBT.Background = Brushes.Red;
            }
            else
            {
                DEBT.Background = Brushes.Green;
            }
            DEBT.Text = debt.ToString();
            CITIZENSHIP.Text = "Ukranian";
            Subject.Text = "Programming";
            CITY.Text = "Kiev";
            WPISY.Items.Add(st3);
            Status.Items.Add(st3);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}

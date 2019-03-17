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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeansOffice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            TreeViewItem students = new TreeViewItem { Header = "Students" };
            TreeViewItem workers = new TreeViewItem { Header = "Workers" };
            TreeViewItem stationary = new TreeViewItem { Header = "Stationary" };
            TreeViewItem non_stationary = new TreeViewItem { Header = "Non-Stationary" };
            TreeViewItem internet = new TreeViewItem { Header = "Internet" };
            TreeViewItem info = new TreeViewItem { Header = "Informatics" };
            TreeViewItem graph = new TreeViewItem { Header = "Graphics" };
            TreeViewItem teachers = new TreeViewItem { Header = "Teachers" };
            TreeViewItem administration = new TreeViewItem { Header = "Administration" };
            stationary.Items.Add(info);
            stationary.Items.Add(graph);
            students.Items.Add(stationary);
            students.Items.Add(non_stationary);
            students.Items.Add(internet);
            workers.Items.Add(teachers);
            workers.Items.Add(administration);

            PersonTypeTreeView.Items.Add(students);
            PersonTypeTreeView.Items.Add(workers);
            var st = new Student { IdStudent = 1, FirstName = "Jan", LastName = "Kowalski", StudentId = 228, Status = "Student", Year = 2019, Semestr = "18/19", Specialization = "Databases", Info = " " };


            var st1 = new Student { IdStudent = 2, FirstName = "Mariusz", LastName = "Zalewski" };
            var st2 = new Student { IdStudent = 3, FirstName = "Puck", LastName = "Huuk", StudentId = 229, Status = "Student", Year = 2019, Semestr = "18/19", Specialization = "Games", Info = " " };
            var st3 = new Student { IdStudent = 4, FirstName = "Vitua", LastName = "krasnow", StudentId = 230, Status = "Expelled", Year = 2018, Semestr = "17/18", Specialization = "Dudka", Info = "kek " };
            var st4 = new Student { IdStudent = 5, FirstName = "Jozeph", LastName = "Joestar", StudentId = 231, Status = "Student", Year = 2019, Semestr = "18/19", Specialization = "Games", Info = " " };
            var st5 = new Student { IdStudent = 6, FirstName = "Dio", LastName = "Brando", StudentId = 232, Status = "Student", Year = 2019, Semestr = "18/19", Specialization = "Buisenss", Info = "$$$$$ " };
            var list = new List<Student>();
            list.Add(st);
            list.Add(st1);
            list.Add(st2);
            list.Add(st3);
            list.Add(st4);
            list.Add(st5);
            StudentsDataGrid.ItemsSource = list;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Wpf_Nande
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Student> students = new List<Student>();

        public MainWindow(List<Student> student)
        {
            students = student;
            InitializeComponent();
        }

        DataCapture11 datac = new DataCapture11();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = user.Text.ToString();
            string password = pass.Password.ToString();

            foreach (Student stud in students)
            {
                if (stud.Password.Equals(password) && stud.Username.Equals(username))
                {
                    LayoutExamples le = new LayoutExamples();
                    le.Show();
                    this.Close();
                }
            }



        }
        

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            //message pops up when someone clicks button
            MessageBox.Show("Button Click response");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //calls and directs you to register class
            DataCapture11 dc = new DataCapture11();
            dc.Show();
            this.Close();
        }
    }
}

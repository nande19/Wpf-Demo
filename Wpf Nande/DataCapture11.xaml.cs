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

namespace Wpf_Nande
{
    /// <summary>
    /// Interaction logic for DataCapture11.xaml
    /// </summary>
    public partial class DataCapture11 : Window
    {
        public DataCapture11()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private List<Student> students = new List<Student>();


        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string fullnam = fullname.Text;
            string Usernam = username.Text;
            string Address = address.Text;
            string password = password1.Password;

            if (password1.Password != confirmation1.Password)
            {
                MessageBox.Show("Password to match");
            }
            else
            {
                Student astudent = new Student( Usernam,  fullnam ,  password,  Address);
                students.Add(astudent);

                MessageBox.Show("Data saved");
                ClearData();
            }
        }
        private void ClearData()
        {
            fullname.Text = "";
            username.Text = "";
            password1.Password = "";
            address.Text = "";
            confirmation1.Password = "";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow MW = new MainWindow(students);
            MW.Show();
            this.Close();
        }
    }
}

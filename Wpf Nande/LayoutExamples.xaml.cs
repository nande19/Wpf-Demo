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
    /// Interaction logic for LayoutExamples.xaml
    /// </summary>
    public partial class LayoutExamples : Window
    {
        public LayoutExamples()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(RoutedEventArgs e)
        {

        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            // code to add names in the listbox
            if(!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            { 
            //adding items to the listbox
            lstNames.Items.Add(txtName.Text);
                //Clear the text box after adding the name 
                txtName.Clear();
            }
        }
    }
}

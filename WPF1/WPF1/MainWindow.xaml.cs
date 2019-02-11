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


namespace WPF1
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
        //ef : EntryForm
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, address;
            int zipCode;

            name = txtName.Text;
            //assigns the string to the textbox 
            //need .text for string
            address = txtAddress.Text;
            zipCode = Convert.ToInt32(txtZipCode.Text);
            //need to convert then se .text for integers
            //then add class for constructors
            bool isFormValid = true;
            if (name == "" || name ==string.Empty)
            {
                MessageBox.Show("Please input your name");
                txtName.Focus();
                //return; --dont need if void
                isFormValid = false;
            }
            if (address == "")
            {
                MessageBox.Show("Please input your address");
                isFormValid = false;
            }



            entryForm ef = new entryForm();
            ef.Name = name;
            ef.Address = address;
            ef.ZipCode = zipCode;
            //needs to be in order of text boxes
            //assigns the value of their input in the class

            string entryForm = $"{name} lives at {address} {zipCode}";
            _1stApplications.Items.Add(ef);

        }

    
    }
}

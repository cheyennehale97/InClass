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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string zipAsString = txtZipCode.Text;

            Form idk = new Form();
            idk.ZipCode = Convert.ToInt32(zipAsString);
            idk.Name = txtName.Text;
            idk.Address = txtAddress.Text;

            lstListBoxOutput.Items.Add(idk).ToString();
            /*lstListBoxOutput.Items.Add(idk.Name);
            lstListBoxOutput.Items.Add(idk.Address);*/
            
                

        }

        private void lstListBoxOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
        }
    }
    }


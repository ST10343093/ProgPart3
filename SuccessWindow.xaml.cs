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

namespace ProgPart3
{
    /// <summary>
    /// Interaction logic for SuccessWindow.xaml
    /// </summary>
    public partial class SuccessWindow : Window
    {//SuccessWindow Begin
        //constructor that passing the string parameter containing the message that the successWindow label will display when this window is call/opened
        public SuccessWindow(string message)
        {//SuccessWindow constructor begin
            InitializeComponent();
            //display the messagewith a label
            SuccessMessagelbl.Content = message;
        }//SuccessWindow constructor end

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {//Closebtn begin
            this.Close();
        }//Closebtn end
    }//SuccessWindow End
}//namespace ST10251759_PROG6221_POE end
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
    /// 


    /*  Code attribution
        *  The follwing code was taken from StackOverFlow:
        *  Link : https://stackoverflow.com/questions/2552501/switch-statement-in-c-sharp
        *  switch (x)
        {
        case 1:
        //do something
        break;
        case 2..8:
        //do something else
        break;
        default:
        break;
        }


        The follwing code was taken from StackOverFlow:
        *  Link : https://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice
        *  try
        {
        //do something
        }
        catch
        {
        //Do nothing
        } 
        *  
        *  The follwing code was taken from StackOverFlow:
        *  Link : The follwing code was taken from StackOverFlow: 
        *  https://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice
        * 
        *   for (i=0 ; i<=10; i++)
        {
        ..
        ..
        }

        i=0;
        while(i<=10)
        {
        ..
        ..
        i++;
        }
        END
        */

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
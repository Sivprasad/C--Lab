using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathsOperators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
                else
                {
                    throw new InvalidOperationException("No operation is selected");
                }
            }
            catch (FormatException fEx)
            {
                // result.Text = fEx.Message;
                MessageDialog msg = new MessageDialog(fEx.Message);
                msg.ShowAsync();
            }
            catch (OverflowException oEx)
            {
                MessageDialog msg = new MessageDialog(oEx.Message);
                msg.ShowAsync();
            }
            catch (InvalidOperationException iEx)
            {
                MessageDialog message = new MessageDialog(iEx.Message);
                message.ShowAsync();
                //result.Text = iEx.Message;
            }
            catch (DivideByZeroException dEx)
            {
                result.Text = dEx.Message;
            }

            //catch (Exception ex)
            //{
            //    MessageDialog msg = new MessageDialog(ex.Message);
            //    msg.ShowAsync();
            //}
        }

        private void addValues()
        {
           // try
            //{
                int lhs = int.Parse(lhsOperand.Text);
                int rhs = int.Parse(rhsOperand.Text);
                int outcome = 0;
                outcome = lhs + rhs;
                expression.Text = $"{lhs} + {rhs}";
                result.Text = outcome.ToString();
            //}
            //catch
            //{

            //    // MessageDialog msg = new MessageDialog("You should enter numeric values");
            //    //msg.ShowAsync();
            //    result.Text = "You should enter numeric values";
            //}
           
        }

        private void subtractValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = lhs - rhs;
            expression.Text = $"{lhs} - {rhs}";
            result.Text = outcome.ToString();
        }

        private void multiplyValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = checked(lhs * rhs);
            expression.Text = $"{lhs} * {rhs}";
            result.Text = outcome.ToString();
        }

        private void divideValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = lhs / rhs;
            expression.Text = $"{lhs} / {rhs}";
            result.Text = outcome.ToString();
        }

        private void remainderValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = lhs % rhs;
            expression.Text = $"{lhs} % {rhs}";
            result.Text = outcome.ToString();
        }
    }
}

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

namespace primer_ejemplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private TextBox objTextBox = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtCalcula_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double val;



                //si escribio en la caja de texto de txCentigrados
                if (objTextBox == txCentigrados)
                {
                    MessageBox.Show("escribiste primero en centigrados");
                    val = Convert.ToDouble(txCentigrados.Text) * 9 / 5 + 32;
                    txFarenheit.Text = String.Format("{0:F12}", val);
                }//if


                //si escribio en la caja de texto de txFarenheit
                else
                if (objTextBox == txFarenheit)
                {
                    MessageBox.Show("escribiste primero en farenheit");
                    val = (Convert.ToDouble(txFarenheit.Text)-32) * 5 / 9;
                    txCentigrados.Text = String.Format("{0:F12}", val);
                }//if
                else
                    MessageBox.Show("Por favor inserte datos");
            }//try
            catch (FormatException)
            {
                txCentigrados.Text = "0.0";
                txFarenheit.Text = "0.0";
            }//catch
        }//method

        private void TxCentigrados_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }//method

        private void TxFarenheit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;

        }//method
    }
}

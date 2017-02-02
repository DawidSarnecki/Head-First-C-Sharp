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

namespace DebuggerUsing_ch1
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            textBlock.Text += "\n Hello! app is running! ";

            double number = 15;
            int count = 0;
            int length = 10;
            bool yesno = false;
            double d = Math.PI;
            string answer = "";

            textBlock.Text += "\n The loop finished at: " + DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                number += 100 * d; //added breakpoint
                yesno = !yesno;
                count ++;
                answer += "\n step no:"+count +"; "+ number+"; "+ yesno;

                MessageBox.Show("\n" + answer);
            }
            textBlock.Text += "\n The Loop finished at: " + DateTime.Now;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int value = 10;
            string name = "Jack Strong";
            if ((value == 10) && name.Equals("Jack Strong"))
            {
                textBlock.Text = "value = 10 and the person is Jack Strong";
            }
            textBlock.Text += "\n this row is executed without conditions";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
            // Loop 1.
            int counter = 0;
            int count = 5;
            while (count > 0)
            {
                count *= 3;
                count *= -1;
                counter ++;
            }
            textBlock.Text = "\n Loop1: n = " + counter;
            


            /*  Endless loop
            // Loop 3.
            int counter = 0;
            int j = 2;
            for (int i = 0; i < 100; i *= 2)
            {
                j -= 1;
                while (j < 25)
                {
                    j += 5;
                }
                counter++;
            }
            textBlock.Text += "\n Loop3: n = " + counter;
            */


            // Loop 4.
            counter = 0;
            int j = 10;
            while (j == 100)
            {
                j += 10;
                counter++;
            }
            j += 10;
            textBlock.Text += "\n Loop4: n = " + counter;
            

            // Loop 5.
           
            counter = 0;
            int p = 2;
            for (int q = 2; q < 32; q *= 2)
            {
                while (p < q)
                {
                    p *= 2;
                }
                q = p - q;
                counter++;
            }
            textBlock.Text += "\n Loop5: n = " + counter;
           
        }
    }
}

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

namespace _02GuessNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lives = 10;
        private int random = new Random().Next(0, 100);
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void txbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (lives == 0)
            {
                lblFrom.Content = "You";
                lblTo.Content = "Lose!!";
                lblWarning.Content = "Remaining Lives: " + lives;
                return;
            }
            if (e.Key == Key.Enter) 
                    {
                int guessedNumber = Int32.Parse(txbNumber.Text);
                if(guessedNumber == random)
                {
                    lblFrom.Content = "You";
                    lblTo.Content = "Win!!";
                    return;
                }
                if(guessedNumber < random)
                {
                    lblFrom.Content = guessedNumber;
                }
                else
                {
                    lblTo.Content = guessedNumber;
                }
                lblWarning.Content = "Remaining Lives: " + lives;
                lblResult.Content = random;
                if (lives <= 3)
                {
                    lblWarning.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
                lives--;
            }
        }
    }
}

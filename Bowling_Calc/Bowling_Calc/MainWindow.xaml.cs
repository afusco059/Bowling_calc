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

namespace Bowling_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double score_1 = 0;
        double score_2 = 0;
        double score_3 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_btn_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Score1.Text, out score_1);
            Double.TryParse(Score2.Text, out score_2);
            Double.TryParse(Score3.Text, out score_3);
            double answer = score_1 + score_2 + score_3;

            Answer.Text = answer.ToString();

            double average = answer / 3;
            Average.Text = average.ToString();

        
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void female_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

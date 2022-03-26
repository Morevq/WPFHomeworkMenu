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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            menu.Background = new SolidColorBrush(Colors.LightGray);
        }

        int firstTenRequests = 0;

        string[] mas = new string[] {"fdgbd fgbf oarf", "egrgrgd s gfg",
            "hdge eirer r", "fjbvhf kiw ewqo", "vuihvu jheo qpeo",
            "fhej b eofi fewj", "fejv ekjrfnopq fq", "eiufh qhgo povj", 
            "fgjs fopeqw ity", "fvnkzap tn rwv wv", "evghjwk wwvbw qwn vdi",
            "hfuef ivhefv ejwoife eofje", "efvhe vopwjv wv",
            "vei vewjpt tpt g", "nvkfwot yoibm  sm", "rgvbrk wenv msn vf"};

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(firstTenRequests < 10)
            {
                menuItem.Items[firstTenRequests] = textBox.Text;
                firstTenRequests++;
            }
            /*else
            {
                MenuItem newMenuItemnew = new MenuItem();
                newMenuItemnew.Header = textBox.Text;
                menuItem.Items[firstTenRequests] = newMenuItemnew;
                firstTenRequests++; //крашиться на 13 нажатии
            }*/
            answerTaxtBox.Text = "";
            Random rand = new Random();
            int indexOfmas;
            for (int i = 0; i < mas.Length; i++)
            {
                indexOfmas = rand.Next(mas.Length);
                answerTaxtBox.Text += mas[indexOfmas] + "\n";
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            grid.Background = new SolidColorBrush(Colors.Red);
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            grid.Background = new SolidColorBrush(Colors.Blue);
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            grid.Background = new SolidColorBrush(Colors.White);
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.Green);
        }
    }
}

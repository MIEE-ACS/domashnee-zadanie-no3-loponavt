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

namespace Homework3
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

        private void btn_count_Click(object sender, RoutedEventArgs e)
        {
            string text = tb_text.Text;
            int number = 1;
            bool flag = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    flag = false;
                }
            }
            if (text.Length == 0 || flag)
            {
                number = 0;
            }
            if (!flag)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i > 0)
                    {
                        if (((text[i] != ' ') && (text[i - 1] == ' ')) ||
                            ((text[i] != ' ') && (text[i - 1] == '.')) ||
                            ((text[i] != ' ') && (text[i - 1] == ',')) ||
                            ((text[i] != ' ') && (text[i - 1] == '!')) ||
                            ((text[i] != ' ') && (text[i - 1] == '?'))) number++;
                    }
                    else
                    {
                        if (text[i] == ' ') number--;
                    }

                }
            }
            tb_number.Text = number.ToString();
        }
    }
}

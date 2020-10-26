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
        private void tb_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tb_text.Text + ' ';
            int number = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((Char.IsLetterOrDigit(text[i]) && Char.IsWhiteSpace(text[i + 1]))
                    || (Char.IsLetterOrDigit(text[i]) && Char.IsPunctuation(text[i + 1]))) number++;
            }
            tb_number.Text = number.ToString();
        }
    }
}

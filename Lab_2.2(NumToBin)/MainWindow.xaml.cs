using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_2._2_NumToBin_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            int a;
            if (!int.TryParse(inputTextBox.Text, out a))
            {
                MessageBox.Show("TextBox does not contain an integer");
            }
            else
                if (a < 0)
                {
                    MessageBox.Show("Please enter a positive number or 0");
                }
                else
                {
                    if (a != 0)
                    {
                        int remainder = 0;
                        StringBuilder binary = new StringBuilder();
                        while (a > 0)
                        {
                            remainder = a % 2;
                            a = a / 2;
                            binary.Insert(0, remainder);
                        }
                        binaryLabel.Content = binary.ToString();
                    }
                    else binaryLabel.Content = 0;
                }
        }
    }
}

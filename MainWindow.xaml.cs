using System;
using System.Collections.Generic;
using System.Windows;

namespace Урок_соритровки
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            But1.Click += But1_Click;
        }
        // создание рамдомайзера
        Random _random = new Random();

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            // создаю список лист
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(_random.Next());
                Blok1.Text += list[i] + "\n";
            }

            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                    {
                        int val = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = val;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Blok2.Text += list[i] + "\n";
            }
        }
    }
}


﻿using System;
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

namespace WPF1
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

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void PopUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = textBox.Text;
            label.Content = text;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox.ToString();
        }
    }
}
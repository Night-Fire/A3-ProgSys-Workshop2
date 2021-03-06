﻿using ClassLibrary;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = new ViewModel();
        }

        private void ToUppercase_Click(object sender, RoutedEventArgs e)
        {
            viewModel.model.Message = textSource.Text;
            viewModel.ToUpperCase();
            textDest.Text = viewModel.model.Message;
        }
    }
}

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
using System.Windows.Shapes;

namespace Ghost
{
    /// <summary>
    /// Логика взаимодействия для WelcomeForm.xaml
    /// </summary>
    public partial class WelcomeForm : Window
    {
        public WelcomeForm(string username)
        {
            InitializeComponent();
            Welcome_label.Content = $"Welcome to Ghost App, {username}!";
        }
    }
}

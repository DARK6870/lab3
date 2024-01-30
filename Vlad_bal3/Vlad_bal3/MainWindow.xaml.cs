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

namespace Vlad_bal3
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

        private void openRegForm_Click(object sender, RoutedEventArgs e)
        {
            Registration window = new Registration();
            window.Show();
            this.Close();
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            username_tb.Text = string.Empty;
            password_tb.Password = string.Empty;
        }
    }
}

using Ghost.Database;
using Ghost.Entity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
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

namespace Ghost
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

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppDBContext context = new AppDBContext())
                {
                    string username = username_tb.Text;
                    string password = password_tb.Password;

                    User? userData = context.Users.FirstOrDefault(p => p.Name == username);

                    if (userData != null)
                    {
                        string storedHash = userData.PasswordHash;

                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                            string enteredHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                            if (storedHash == enteredHash)
                            {
                                MessageBox.Show("Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                    }
                    else
                    {
                        message.Content = "User not found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
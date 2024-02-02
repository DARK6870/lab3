using Ghost.Database;
using Ghost.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
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
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void openLoginForm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windows = new MainWindow();
            windows.Show();
            this.Close();
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            Registration window = new Registration();
            window.Show();
            this.Close();
        }

        private string GetOtherLanguages()
        {
            List<string> selectedLanguages = new List<string>();

            foreach (var item in languageListBox.Items)
            {
                if (item is CheckBox checkBox && checkBox.IsChecked == true)
                {
                    selectedLanguages.Add(checkBox.Content.ToString());
                }
            }

            return string.Join(", ", selectedLanguages);

        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User? regUser = new User();
                regUser.Name = username_tb.Text;
                regUser.Email = email_tb.Text;
                regUser.FullName = fullName_tb.Text;
                regUser.SecondLanguages = GetOtherLanguages();
                regUser.MainLanguage = lang_cb.Text;

                try
                {
                    regUser.DateBrth = Convert.ToDateTime(date_bth.Text);
                }
                catch
                {

                }

                string password = password_tb.Password;
                regUser.PasswordHash = password;
                    
                if (male.IsChecked == true)
                {
                    regUser.Gender = "M";
                }
                else
                {
                    regUser.Gender = "F";
                }

                
                var validationContext = new ValidationContext(regUser, null, null);
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                if (Validator.TryValidateObject(regUser, validationContext, validationResults, true))
                {
                    using (AppDBContext context = new AppDBContext())
                    {
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                            regUser.PasswordHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                        }

                        User? checkUserName = context.Users.FirstOrDefault(p => p.Name == regUser.Name);
                        if (checkUserName == null)
                        {
                            context.Users.Add(regUser);
                            int res = context.SaveChanges();
                            if (res > 0)
                            {
                                MainWindow window = new MainWindow();
                                window.FillData(regUser.Name, password);
                                window.Show();
                                this.Close();
                            }
                            else
                            {
                                msg.Content = "Oooops, somthing went wrong, SERVER ERROR :(";
                            }
                        }
                        else
                        {
                            msg.Content = "User with this username is already exist.";
                        }
                    }
                }
                else
                {
                    string validationErrors = string.Join(Environment.NewLine, validationResults.Select(result => result.ErrorMessage));
                    msg.Content = $"{validationErrors}";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

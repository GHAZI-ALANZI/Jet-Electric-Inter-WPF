using Jet_Electric_DataAccessLayer.AppDbContext;
using Jet_Electric_Inter.Logic;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Jet_Electric_Inter.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        ViewModels.LoginViewModel _vm;
        public Login()
        {
            InitializeComponent();

            _vm = new ViewModels.LoginViewModel();
            this.DataContext = _vm;

            NameTextBox.Text = "ghaa";
            PasswordBox.Password = "12345";

            NameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            #region validation 
            if ((String.IsNullOrEmpty(NameTextBox.Text)) || (String.IsNullOrEmpty(PasswordBox.Password)))
            {
                var sMessageDialog = new MessageDialog
                {
                    Message = { Text =
                    "ERROR: Fill required fields!" }
                };

                DialogHost.Show(sMessageDialog, "RootDialog");
                return;
            }
            #endregion

            using (var db = new JetDbContext())
            {
                var obj = db.Logins.Where(m => m.Username == NameTextBox.Text).FirstOrDefault();
                if (obj == null)
                {
                    var sMessageDialog = new MessageDialog
                    {
                        Message = { Text = "Incorrect Username!" }
                    };

                    DialogHost.Show(sMessageDialog, "RootDialog");
                    Clear();
                    NameTextBox.Focus();
                    return;
                }
                //else if (!Hashing.ValidatePassword(PasswordBox.Password, obj.Password))
                //{
                //    var sMessageDialog = new MessageDialog
                //    {
                //        Message = { Text = "Incorrect Password!" }
                //    };

                //    DialogHost.Show(sMessageDialog, "RootDialog");
                //    Clear();
                //    NameTextBox.Focus();
                //    return;
                //}

                this.Hide();
                LoggedInUser.Instance.Info = db.Logins.Where(u => u.ID == obj.ID).FirstOrDefault();
                MainWindow x = new MainWindow();
                x.Show();
                this.Close();
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                LoginButton_Click(null, null);
        }

        private void Clear()
        {
            this.NameTextBox.Clear();
            this.PasswordBox.Clear();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

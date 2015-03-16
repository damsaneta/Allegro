using Allegro.Logic.Managers;
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
using System.Windows.Shapes;

namespace Allegro.Gui.LogIn
{
    /// <summary>
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        private readonly ISecurityManager securityManager=new FakeSacurityManager();

        public LogInView()
        {
            InitializeComponent();
        }

        private void btnCancelClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnSubmitClick(object sender, RoutedEventArgs e)
        {
            this.errUsername.Visibility = System.Windows.Visibility.Hidden;
            this.errPassword.Visibility = System.Windows.Visibility.Hidden;
            if (this.securityManager.CheckIfUserExist(this.txtUsername.Text) == false)
            {
                this.errUsername.Visibility = System.Windows.Visibility.Visible;
                return;
            }

            if (this.securityManager.SignIn(this.txtUsername.Text, this.txtPassword.Password))
            {
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                this.errPassword.Visibility = System.Windows.Visibility.Visible;
            }

        }
    }
}

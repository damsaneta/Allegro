using Allegro.Gui.LogIn;
using Allegro.Gui.UserManagement;
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

namespace Allegro.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            var loginView = new LogInView();
            bool? result = loginView.ShowDialog();
            if (result.HasValue == false || result.Value == false)
            {
                this.Close();
            }
        }

        private void BtnUsersManagement_Click(object sender, RoutedEventArgs e)
        {
            var view = new UsersListView();
           
            view.Show();
        }
    }
}

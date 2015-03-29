using Allegro.Logic.Domain;
using Allegro.Logic.Repositories;
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

namespace Allegro.Gui.UserManagement
{
    /// <summary>
    /// Interaction logic for UsersListView.xaml
    /// </summary>
    public partial class UsersListView : Window
    {
        private readonly IUserRepository userRepository= new InMemoryUserRepository();
        public UsersListView()
        {
            InitializeComponent();
            var list = this.userRepository.GetAll();
            this.dataGrid.ItemsSource = list;
           
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            var view = new AddUserView();
            view.ShowDialog();
            this.dataGrid.Items.Refresh();
        }
    }
}

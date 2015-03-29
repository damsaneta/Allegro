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
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Window
    {
        private readonly IUserRepository userRepository = new InMemoryUserRepository();
        public AddUserView()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            // TODO walidacja pol
           User user = userRepository.GetByLogin(txtLogin.Text);
            if(user!=null)
            {
                //TODO wyswietl komunikat
            }
            else
            {
                user = new User(txtLogin.Text, txtFirstName.Text, txtLastName.Text);
                this.userRepository.Add(user);
                
            }
            this.Close();
        }
    }
}

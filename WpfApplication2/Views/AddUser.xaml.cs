using System.Windows;
using WpfApplication2.ViewModels;

namespace WpfApplication2.Views
{
	
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }
    }
}
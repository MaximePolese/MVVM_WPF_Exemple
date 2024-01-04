using System.Windows.Input;
using WpfApplication2.Commands;
using WpfApplication2.Models;

namespace WpfApplication2.ViewModels
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User() { UserName = Name, UserEmail = Email });
        }
    }
}
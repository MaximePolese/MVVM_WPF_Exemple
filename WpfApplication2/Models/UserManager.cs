using System.Collections.ObjectModel;

namespace WpfApplication2.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User() { UserEmail = "quam@aol.couk", UserName = "Erich Fry" },
            new User { UserEmail = "in@yahoo.com", UserName = "Virginia Salas" },
            new User { UserEmail = "luctus@google.com", UserName = "Alvin Velasquez" },
            new User { UserEmail = "etiam.bibendum@hotmail.edu", UserName = "Zia Hutchinson" },
            new User { UserEmail = "augue.porttitor@protonmail.org", UserName = "Justin Burch" }
        };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
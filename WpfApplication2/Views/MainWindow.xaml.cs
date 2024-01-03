using System.Windows;
using System.Windows.Controls;
using WpfApplication2.Models;
using WpfApplication2.ViewModels;

namespace WpfApplication2.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyViewModel myViewModel = new MyViewModel();
            this.DataContext = myViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;
            // StringComparison ordICCmp = StringComparison.OrdinalIgnoreCase;
            return user.Name.Contains(FilterTextBox.Text);
            // StringComparison.OrdinalIgnoreCase
        }
    }
}
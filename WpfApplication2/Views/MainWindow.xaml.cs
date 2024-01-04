using System.Windows;
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
    }
}
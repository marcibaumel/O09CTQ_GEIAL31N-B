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

namespace NextFilm.WPF.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        //TODO: function 
        public Login()
        {
            InitializeComponent();  
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            FilmList filmListPage = new FilmList();

            //Go to the film list page
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(filmListPage);
        }

        private void BtnClickRegistration(object sender, RoutedEventArgs e)
        {
            Registration registrationPage = new Registration();
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(registrationPage);
        }

        
    }
}

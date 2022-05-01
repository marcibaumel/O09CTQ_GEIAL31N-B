using NextFilm.DataAccess;
using NextFilm.Services.UserService;
using NextFilm.WPF.DTO;
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
    public partial class Login : Page
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        private IUserService userService = new UserService(unitOfWork);

        public Login()
        {
            InitializeComponent();
            emailInput.Text = "bela@email.com";
            passwordInput.Password = "bela";
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            string email = emailInput.Text;
            string password = passwordInput.Password.ToString();
            

            //Go to the film list page
            if (checkUser(email, password))
            {
                string userName = userService.GetUserByEmail(email).Name;
                MessageBox.Show("Welcome "+userName, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);

                User user = new User(email, password);

                FilmList filmListPage = new FilmList(user);
                MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
                objMainWindows.Main.Navigate(filmListPage);
            }
            
        }

        private void BtnClickRegistration(object sender, RoutedEventArgs e)
        {
            Registration registrationPage = new Registration();
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(registrationPage);
        }

        private bool checkUser(string email, string password)
        {
            NextFilm.DataAccess.Models.User user = userService.GetUserByEmail(email);
            try
            {
                if (user == null || !user.Password.Equals(password))
                {
                    MessageBox.Show("Something wrong with your data", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            return true;

            
        }

        
    }
}

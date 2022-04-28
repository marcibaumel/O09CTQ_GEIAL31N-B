using NextFilm.DataAccess;
using NextFilm.Services.UserService;
using NextFilm.WPF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Registration : Page
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        private IUserService userService = new UserService(unitOfWork);

        public Registration()
        {
            InitializeComponent();
        }

        private void btnClickRegistration(object sender, RoutedEventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string password = passwordInput.Password.ToString();

            if(checkInputs(name, email, password))
            {
                User user = new User(name, email, password);
                userService.Create(user.convertUserDtoToUser());
                MessageBox.Show(name+" added successfully", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);

                FilmList filmListPage = new FilmList(user);
                MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
                objMainWindows.Main.Navigate(filmListPage);
            } 
        }

        private bool checkInputs(string name, string email, string password)
        {
            bool result = false;
            if (userService.GetUserByEmail(email) == null && characterCheck(name, email, password) && emailFormatCheck(email)) {
                result = true;
            }
            if (result.Equals(false))
            {
                MessageBox.Show("Something wrong (Minimum length 2 character, Check email format)", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return result;
        }
        
        private bool characterCheck(string name, string email, string password)
        {
            if(name.Length > 2 && email.Length > 2 && password.Length > 2)
            {
                return true;
            }
            return false;
        }

        private bool emailFormatCheck(string email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            Login loginPage = new Login();
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(loginPage);
        }
    }
}

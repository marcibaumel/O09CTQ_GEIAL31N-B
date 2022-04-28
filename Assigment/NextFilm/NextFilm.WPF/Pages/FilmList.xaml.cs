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
    public partial class FilmList : Page
    {
        private User workingUser = null;
        static UnitOfWork unitOfWork = new UnitOfWork();
        private IUserService userService = new UserService(unitOfWork);

        public FilmList(User user)
        {
            workingUser = user;
            InitializeComponent();
        }

        private void BtnClickLogout(object sender, RoutedEventArgs e)
        {
            Login loginPage = new Login();
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(loginPage);
        }

        private void BtnClickShowAddFilm(object sender, RoutedEventArgs e)
        {
            if(addFilmPanel.Visibility == Visibility.Visible)
            {
                addFilmPanel.Visibility = Visibility.Hidden;
                showAddFilmBtn.Content = "Add Film";
            }
            else
            {
                addFilmPanel.Visibility = Visibility.Visible;
                showAddFilmBtn.Content = "Close Add Film";
            }
        }

        private void BtnAddFilm(object sender, RoutedEventArgs e)
        {
            int userId = userService.GetUserByEmail(workingUser.Email).Id;

            try
            {

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}

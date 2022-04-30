using NextFilm.DataAccess;
using NextFilm.Services.FilmService;
using NextFilm.Services.OmdbService;
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
    public partial class FilmList : Page
    {
        private User workingUser = null;

        static UnitOfWork unitOfWork = new UnitOfWork();

        private IUserService userService = new UserService(unitOfWork);
        private IFilmService filmService = new FilmService(unitOfWork);
        private IOmdbService omdbService = new OmdbService();
        

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

        private async void BtnAddFilm(object sender, RoutedEventArgs e)
        {
            int userId = userService.GetUserByEmail(workingUser.Email).Id;
            
            try
            {
                if (addFilmPanel.Visibility == Visibility.Visible && checkInputs())
                {
                    Film searchedFilm = new Film(await omdbService.Load(filmTitleInput.Text, filmYearInput.Text));
                    if(searchedFilm.Poster == null)
                    {
                        if(MessageBox.Show("Your inputs look okay but I couldn't find data from the internet, do you still want to add to your list?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                        {
                            MessageBox.Show("No film added to your list", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                            clearInputs();
                        }
                        else
                        {

                        }
                        
                    }
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong with the API", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.WriteLine(ex); 
            }
        }

        private bool checkInputs()
        {
            int actualYear = 0;

            if (filmTitleInput.Text.Length > 0 || filmYearInput.Text.Length > 0)
            {
                try 
                {
                    DateTime moment = new DateTime();
                    actualYear = moment.Year;
                    int year = Int32.Parse(filmYearInput.Text);
                } 
                catch (FormatException) 
                {
                    MessageBox.Show("Something wrong with the given year please chek it again (Valid year is between 1888 + "+actualYear+")", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                    filmYearInput.Text = "";
                    return false;
                }

                return true;
                
            }
            return false;
        }

        private void clearInputs()
        {
            filmTitleInput.Text = "";
            filmYearInput.Text = "";
        }
    }
}

using NextFilm.DataAccess;
using NextFilm.Services.FilmService;
using NextFilm.Services.OmdbService;
using NextFilm.Services.UserService;
using NextFilm.WPF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<NextFilm.DataAccess.Models.Film> Films { 
            get 
            {
                return getAllFilmFromUser();
            }
        }

        public FilmList(User user)
        {
            workingUser = user;

            InitializeComponent();

            WelcomeLabel.Content = "Welcome, " + userService.GetUserByEmail(workingUser.Email).Name;
            FilmBinding.ItemsSource = Films;
            FilmHistoryBinding.ItemsSource = filmService.GetAllFilmsByUserIsWatched(userService.GetUserByEmail(workingUser.Email));
            historyList.Visibility = Visibility.Hidden;
        }

        public List<NextFilm.DataAccess.Models.Film> getAllFilmFromUser()
        {

            NextFilm.DataAccess.Models.User user = userService.GetUserByEmail(workingUser.Email);
            return filmService.GetAllFilmsByUser(user);
        }

        private void BtnClickLogout(object sender, RoutedEventArgs e)
        {
            string username = userService.GetUserByEmail(workingUser.Email).Name;
            MessageBox.Show("Goodbye " + username, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            Login loginPage = new Login();
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Navigate(loginPage);
        }

        private void BtnClickShowHistory(object sender, RoutedEventArgs e)
        {
            if(showHistory.Content.Equals("History"))
            {
                WelcomeLabel.Content = "Back to the future, " + userService.GetUserByEmail(workingUser.Email).Name;
                filmList.Visibility = Visibility.Hidden;
                showAddFilmBtn.Visibility = Visibility.Hidden;
                FilmHistoryBinding.ItemsSource = filmService.GetAllFilmsByUserIsWatched(userService.GetUserByEmail(workingUser.Email));
                historyList.Visibility = Visibility.Visible;

                showHistory.Content = "Back to watchlist";
            }
            else
            {
                WelcomeLabel.Content = "Happy filming, " + userService.GetUserByEmail(workingUser.Email).Name;
                filmList.Visibility = Visibility.Visible;
                showAddFilmBtn.Visibility = Visibility.Visible;
                FilmBinding.ItemsSource = Films;
                historyList.Visibility = Visibility.Hidden;

                showHistory.Content = "History";
            }
        }
        

        private void BtnFilmUnwatched(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(FilmBinding.SelectedItem);

            NextFilm.DataAccess.Models.Film film = (NextFilm.DataAccess.Models.Film)FilmHistoryBinding.SelectedItem;
            film.IsWatched = false;
            filmService.Update(film.Id, film);
            FilmHistoryBinding.ItemsSource = filmService.GetAllFilmsByUserIsWatched(userService.GetUserByEmail(workingUser.Email));
        }

        private void BtnFilmWatched(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(FilmBinding.SelectedItem);

            NextFilm.DataAccess.Models.Film film = (NextFilm.DataAccess.Models.Film)FilmBinding.SelectedItem;
            film.IsWatched = true;
            filmService.Update(film.Id, film);
            FilmBinding.ItemsSource = getAllFilmFromUser();
        }

        private void BtnDeleteFilm(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(FilmBinding.SelectedItem);
            NextFilm.DataAccess.Models.Film film = (NextFilm.DataAccess.Models.Film)FilmBinding.SelectedItem;
            filmService.Delete(film.Id);
            FilmBinding.ItemsSource = getAllFilmFromUser();
            FilmHistoryBinding.ItemsSource = filmService.GetAllFilmsByUserIsWatched(userService.GetUserByEmail(workingUser.Email));
        }

        private void BtnHistoryDeleteFilm(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(FilmBinding.SelectedItem);
            NextFilm.DataAccess.Models.Film film = (NextFilm.DataAccess.Models.Film)FilmHistoryBinding.SelectedItem;
            filmService.Delete(film.Id);
            FilmBinding.ItemsSource = getAllFilmFromUser();
            FilmHistoryBinding.ItemsSource = filmService.GetAllFilmsByUserIsWatched(userService.GetUserByEmail(workingUser.Email));
        }

        private void BtnClickShowAddFilm(object sender, RoutedEventArgs e)
        {
            if(addFilmPanel.Visibility == Visibility.Visible)
            {
                addFilmPanel.Visibility = Visibility.Hidden;
                showHistory.Visibility = Visibility.Visible;
                filmList.Visibility = Visibility.Visible;
                FilmBinding.ItemsSource = getAllFilmFromUser();
                showAddFilmBtn.Content = "Add Film";
            }
            else
            {
                filmList.Visibility = Visibility.Hidden;
                showHistory.Visibility = Visibility.Hidden;
                addFilmPanel.Visibility = Visibility.Visible;
                showAddFilmBtn.Content = "Close Add Film";
            }
        }

        private async void BtnAddFilm(object sender, RoutedEventArgs e)
        {
            showAddFilmBtn.IsEnabled = false;
            BtnClcikAddFilm.IsEnabled = false;
            btnLogut.IsEnabled = false;


            try
            {
                if (addFilmPanel.Visibility == Visibility.Visible && checkInputs())
                {
                    Film searchedFilm = null;
                    try 
                    {
                        searchedFilm = new Film(await omdbService.Load(filmTitleInput.Text, filmYearInput.Text));
                        BtnClcikAddFilm.Content = "Working....";
                        showAddFilmBtn.Content = "Working....";
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something wrong with the API", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                        searchedFilm = new Film();
                        searchedFilm.Poster = null;
                        Console.WriteLine(ex);
                    }

                    try
                    {
                        if (searchedFilm.Poster == null || searchedFilm.Title.Length != filmTitleInput.Text.Length)
                        {
                            if (MessageBox.Show("Your inputs look okay but I couldn't find data from the internet, do you still want to add to your list?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                            {
                                MessageBox.Show("No film added to your list", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                                clearInputs();
                            }
                            else
                            {
                                NextFilm.DataAccess.Models.Film film = searchedFilm.converDtoToFilm();
                                film.Title = filmTitleInput.Text;
                                film.ReleaseYear = Convert.ToDateTime(filmYearInput.Text + "-01-01");
                                film.Poster = @"C:\REPOS\O09CTQ_GEIAL31N-B\Assigment\NextFilm\NextFilm.WPF\Resources\image.png";
                                film.ReleaseYear = searchedFilm.ReleasedDate;
                                film.User = userService.GetUserByEmail(workingUser.Email);
                                film.ReleaseYear = Convert.ToDateTime(filmYearInput.Text + "-01-01");
                                film.AddedDate = DateTime.Now;

                                Console.WriteLine(film);
                                filmService.Create(film);
                                clearInputs();
                                MessageBox.Show(film.Title + " added to your list", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else
                        {
                            NextFilm.DataAccess.Models.Film film = searchedFilm.converDtoToFilm();

                            film.User = userService.GetUserByEmail(workingUser.Email);
                            film.ReleaseYear = searchedFilm.ReleasedDate;
                            film.AddedDate = DateTime.Now;

                            Console.WriteLine(film);
                            filmService.Create(film);
                            clearInputs();
                            MessageBox.Show(film.Title + " added to your list", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something wrong with the API", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                        Console.WriteLine(ex);
                    }
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong with the given data", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.WriteLine(ex);
            }
            BtnClcikAddFilm.Content = "Add film";
            showAddFilmBtn.Content = "Close Add Film";
            showAddFilmBtn.IsEnabled = true;
            BtnClcikAddFilm.IsEnabled = true;
            btnLogut.IsEnabled = true;
        }

        private bool checkInputs()
        {
            int actualYear = 0;
            
            if (filmTitleInput.Text.Length > 0 || filmTitleInput.Text.Length < 51 || filmYearInput.Text.Length > 0 || filmYearInput.Text.Length < 5)
            {
                try 
                {
                    DateTime moment =  DateTime.Now;
                    actualYear = moment.Year;

                    int year = Int32.Parse(filmYearInput.Text);
                    if(year < 1888 || year > actualYear || String.IsNullOrWhiteSpace(filmTitleInput.Text.ToString()))
                    {
                        MessageBox.Show("Something wrong with the given year please chek it again (Valid year is between 1888 + " + actualYear + ") or the title more than 50 character", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                        clearInputs();
                        return false;
                    }
                } 
                catch (FormatException) 
                {
                    MessageBox.Show("Something wrong with the given year please chek it again (Valid year is between 1888 + "+actualYear+") or the title more than 50 character", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                    clearInputs();
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

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
using System.Windows.Shapes;

namespace CinemaPoster
{
    /// <summary>
    /// Логика взаимодействия для MovieDetail.xaml
    /// </summary>
    public partial class MovieDetail : Window
    {
        public MovieDetail()
        {
            InitializeComponent();
        }

        public void SetMovieDetails(Movie movie)
        {
            // Получаем путь к постеру
            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, movie.PosterUrl);
            MoviePoster.Source = new BitmapImage(new Uri(imagePath, UriKind.Absolute));

            MovieTitle.Text = movie.Title;
            MovieGenre.Text = movie.Genre;
            MovieDescription.Text = movie.Description;
            MovieDirector.Text = $"Режиссер: {movie.Director}";
            MovieActors.Text = $"Актеры: {string.Join(", ", movie.Actors)}";

            ShowtimesItemsControl.ItemsSource = movie.Showtimes;
        }

        public string GetMovieTitle()
        {
            return MovieTitle.Text;
        }

        public string GetMovieGenre()
        {
            return MovieGenre.Text;
        }

        public string GetMovieDescription()
        {
            return MovieDescription.Text;
        }

        public string GetMovieDirector()
        {
            return MovieDirector.Text;
        }

        public string GetMovieActors()
        {
            return MovieActors.Text;
        }


    }
}

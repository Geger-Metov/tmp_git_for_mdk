using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using CinemaPoster;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public MainWindow _mainWindow;

        [TestInitialize]
        public void Setup()
        {
            _mainWindow = new MainWindow();
        }

        [TestMethod]
        public void LoadMovies_ShouldLoadCorrectNumberOfMovies()
        {
            _mainWindow.LoadMovies();

            Assert.AreEqual(6, _mainWindow.GetMoviesCount());
        }

        [TestMethod]
        public void SearchButton_Click_ShouldFilterMoviesByTitle()
        {
            _mainWindow.LoadMovies();
            var searchTextBox = _mainWindow.GetSearchTextBox();
            searchTextBox.Text = "Матрица";

            _mainWindow.SearchButton_Click(null, null);

            var moviesItemsControl = _mainWindow.GetMoviesItemsControl();
            Assert.AreEqual(1, moviesItemsControl.Items.Count);
            Assert.AreEqual("Матрица", ((Movie)moviesItemsControl.Items[0]).Title);
        }

        [TestMethod]
        public void SetMovieDetails_ShouldSetMoviePropertiesCorrectly()
        {
            var movieDetail = new MovieDetail();
            var movie = new Movie
            {
                Title = "Матрица",
                Genre = "Фантастика, Боевик",
                Description = "Описание",
                Director = "Режиссер",
                Actors = new List<string> { "Актер 1", "Актер 2" },
                Showtimes = new List<string> { "10:00", "12:00" },
                PosterUrl = @"..\..\..\..\CinemaPoster\Images\Matrix.png"
            };

            movieDetail.SetMovieDetails(movie);

            Assert.AreEqual("Матрица", movieDetail.GetMovieTitle());
            Assert.AreEqual("Фантастика, Боевик", movieDetail.GetMovieGenre());
            Assert.AreEqual("Описание", movieDetail.GetMovieDescription());
            Assert.AreEqual("Режиссер: Режиссер", movieDetail.GetMovieDirector());
            Assert.AreEqual("Актеры: Актер 1, Актер 2", movieDetail.GetMovieActors());
        }

    }
}

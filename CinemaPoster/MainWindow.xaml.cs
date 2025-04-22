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

namespace CinemaPoster
{
    public partial class MainWindow : Window
    {
        private List<Movie> _movies;
        public MainWindow()
        {
            InitializeComponent();
            LoadMovies();
        }

        public void LoadMovies()
        {
            _movies = new List<Movie>
            {
                new Movie {
                    Title = "Учитель на замену", 
                    Genre = "Драма", 
                    Description = "Генри Барт — учитель на замену, который получает очередное временное назначение. На этот раз он должен преподавать английский язык и литературу в «неблагополучной» школе, где в порядке вещей нецензурная брань и оскорбления в отношении учителей.", 
                    PosterUrl = @"..\..\Images\Detachment.png",
                    Director = "Тони Кэй",
                    Actors = new List<string> { "Эдриан Броуди", "Сами Гэйл" },
                    Showtimes = new List<string> { "12:00", "15:00", "18:00" }
                },
                new Movie {
                    Title = "Она",
                    Genre = "Мелодрама, Фантастика", 
                    Description = "Теодор - одинокий писатель, покупает новую техническую разработку - операционную систему, призванную исполнять любое желание пользователя. К удивлению Теодора, вскоре между ним и операционной системой возникает роман.", 
                    PosterUrl = @"..\..\Images\Her1.png",
                    Director = "Спайк Джонс",
                    Actors = new List<string> {"Хоакин Феникс", "Скарлетт Йоханссон", "Эми Адамс"},
                    Showtimes = new List<string> {"10:00", "17:00", "21:00"}
                },
                new Movie {
                    Title = "Матрица",
                    Genre = "Фантастика, Боевик",
                    Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности",
                    PosterUrl = @"..\..\Images\Matrix.png",
                    Director = "Лоуренс Вачовски, Эндрю Пол Вачовски",
                    Actors = new List<string> {"Киану Ривз", "Лоренс Фишбёрн", "Кэрри-Энн Мосс"},
                    Showtimes = new List<string> {"10:00", "12:30", "15:00", "17:30", "20:00", "22:30"}
                },
                new Movie {
                    Title = "Первый день моей жизни", 
                    Genre = "Фэнтези, Драма", 
                    Description = "Дождливой ночью четверо незнакомых друг с другом самоубийц после ухода из жизни встречают загадочного незнакомца. Он отвозит их в пустующий отель, где им предстоит провести 7 дней, переосмысливая свою прежнюю жизнь и наблюдая за миром, в котором их уже нет.", 
                    PosterUrl = @"..\..\Images\FDOML.jpg",
                    Director = "Паоло Дженовезе",
                    Actors = new List<string> {"Тони Сервилло", "Валерио Мастандреа", "Сара Серрайокко"},
                    Showtimes = new List<string> {"8:30", "12:30", "15:30", "19:30"}
                },
                new Movie {
                    Title = "Ларс и настоящая девушка", 
                    Genre = "Драма, Мелодрама", 
                    Description = "Любовь нечаянно нагрянет… Как у Ларса - очень стеснительного молодого человека, проживающего в маленьком городке на севере Америки, который думает, что обрел любовь всей своей жизни. Но есть одна проблема - это не настоящая девушка, а секс-кукла, которую Ларс заказал в интернете, и он, кажется, вполне этим доволен.", 
                    PosterUrl = @"..\..\Images\LATRW.png",
                    Director = "Крэйг Гиллеспи",
                    Actors = new List<string> {"Райан Гослинг", "Эмили Мортимер" , "Пол Шнайдер"},
                    Showtimes = new List<string> {"15:00", "17:00", "19:00", "21:00"}
                },
                new Movie {
                    Title = "Стрингер", 
                    Genre = "Триллер, Драма", 
                    Description = "Луи Блум пытается найти работу. После того как он видит, как любительская съемочная группа снимает автомобильную аварию, он меняет ворованный велосипед на камеру и снимает последствия угона автомобиля, чтобы продать местной телевизионной компании. Директор новостей Нина покупает запись и убеждает его продолжить работу. Вскоре становится ясно, что ради по-настоящему стоящего материала Луи не остановится ни перед чем...", 
                    PosterUrl = @"..\..\Images\Nightcrawler.jpg",
                    Director = "Дэн Гилрой",
                    Actors = new List<string> {"Джейл Джилленхол", "Рене Руссо", "Риз Ахмед"},
                    Showtimes = new List<string> {"17:00", "19:15", "21:30", "23:45"}
                }
            };

            MoviesItemsControl.ItemsSource = _movies;
        }

        public void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();
            var filteredMovies = _movies.Where(movie => movie.Title.ToLower().Contains(searchText)).ToList();
            MoviesItemsControl.ItemsSource = filteredMovies;
        }

        private void MoviesItemsControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Получаем элемент, на который было выполнено двойное нажатие
            var clickedItem = e.OriginalSource as FrameworkElement;

            // Поднимаемся по дереву визуальных элементов, чтобы найти элемент данных
            while (clickedItem != null && !(clickedItem is ItemsControl))
            {
                if (clickedItem.DataContext is Movie selectedMovie)
                {
                    // Создаем экземпляр нового окна для деталей фильма
                    MovieDetail detailsWindow = new MovieDetail();

                    // Передаем выбранный фильм в новое окно
                    detailsWindow.SetMovieDetails(selectedMovie);

                    // Открываем окно как модальное
                    detailsWindow.ShowDialog();
                    break; // Выходим из цикла, так как фильм найден
                }
                clickedItem = VisualTreeHelper.GetParent(clickedItem) as FrameworkElement;
            }
        }

        public int GetMoviesCount()
        {
            return MoviesItemsControl.Items.Count;
        }

        public ItemsControl GetMoviesItemsControl()
        {
            return MoviesItemsControl;
        }

        public TextBox GetSearchTextBox()
        {
            return SearchTextBox;
        }


    }
}

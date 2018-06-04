using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.IO;
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

namespace Hong_Kong_Movie_DataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Set up object for watchlist window.
        Watchlist watchlistWindow;

        // Bool to make sure duplicate films aren't added to the watchlist.
        bool alreadyAdded = false;      

        // Set up observable collection of films to display.
        public ObservableCollection<Film> filmographyToDisplay = new ObservableCollection<Film>();      

        // Set up observable collection of films added to watchlist.
        public ObservableCollection<Film> watchlistFilms = new ObservableCollection<Film>();        

        // Set up database.
        // NOTE: MDF and LDF database files required for database functionality can be found in the zipped folder uploaded to Moodle. Within "temp > data".
        // Add this "temp" folder to the C Drive so the program can find the database.
        HKMoviesContainer db = new HKMoviesContainer();

        // Set up string array for actor bios.
        string[] actorBios = new string[] { "Lee Jun-fan (李振藩; November 27, 1940 – July 20, 1973), known professionally as Bruce Lee (Chinese: 李小龍), was a Hong Kong and American actor, film director, martial artist, martial arts instructor, philosopher, and founder of the martial art Jeet Kune Do, one of the wushu or kungfu styles. Lee was the son of Cantonese opera star Lee Hoi-chuen. He is widely considered by commentators, critics, media, and other martial artists to be one of the most influential martial artists of all time, and a pop culture icon of the 20th century. He is often credited with helping to change the way Asians were presented in American films.",
        "Donnie Yen Chi-tan (甄子丹; born 27 July 1963) is a Hong Kong actor, martial artist, film director, producer, action choreographer, and multiple-time world wushu tournament champion. Yen is one of Hong Kong's top action stars.[3] He is widely credited for bringing mixed martial arts (MMA) into the mainstream of Chinese culture by choreographing MMA in many of his films.",
        "Chan Kong-sang, (陳港生; born 7 April 1954), known professionally as Jackie Chan, is a Hong Kong martial artist, actor, film director, producer, stuntman, and singer. He is known for his acrobatic fighting style, comic timing, use of improvised weapons, and innovative stunts, which he typically performs himself, in the cinematic world. He has trained in wushu or kungfu and hapkido, and has been acting since the 1960s, appearing in over 150 films.",
        "Li Lianjie (born 26 April 1963),[1] better known by his stage name Jet Li, is a Chinese film actor, film producer, martial artist, and retired Wushu champion born in Beijing. After three years of training with Wu Bin, Li won his first national championship for the Beijing Wushu Team. After retiring from Wushu at age 19, he went on to win great acclaim in China as an actor making his debut with the film Shaolin Temple (1982). He went on to star in many critically acclaimed martial arts epic films, most notably as the lead in director Zhang Yimou's 2002 Hero, Fist of Legend which is the best acclaimed Li movie by Rotten Tomatoes, and the Once Upon a Time in China series, in which he portrayed folk hero Wong Fei-hung.",
        "Michelle Yeoh Choo-Kheng (born 6 August 1962) is a Malaysian actress who achieved fame in the early 1990s after starring in a series of popular Hong Kong action films in which she performed her own stunts. Born in Ipoh, Malaysia, she is known for her roles in the 1997 James Bond film Tomorrow Never Dies, playing Wai Lin, and the Chinese-language martial arts film Crouching Tiger, Hidden Dragon, for which she was nominated for the BAFTA Award for Best Actress in 2000. In 2008, the film critic website Rotten Tomatoes ranked her the greatest action heroine of all time."
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set up watchlist window.
            watchlistWindow = new Watchlist();

            // Set the owner of this window.
            watchlistWindow.Owner = this;

            // Set up the watchlist.
            watchlistWindow.watchlistFilms = new ObservableCollection<Film>();     
        }

        private void btnActor_Click(object sender, RoutedEventArgs e)
        {
            // Get button clicked.
            Button clickedButton = sender as Button;

            // Get selected actor string.
            string actor = clickedButton.Content.ToString();

            // Display actor image.
            imgActor.Source = new BitmapImage(new Uri("Actor Images/" + clickedButton.Content.ToString() + ".png", UriKind.Relative));

            // Display the appropriate actor bio in textblock.
            for(int i=0; i<actorBios.Length; i++)
            {
                // Detect which bio is about the selected actor.
                if(actorBios[i].Contains(actor))
                {
                    txtBlkDescription.Text = actorBios[i];
                    break;
                }
            }

            // Clear labels.
            lblName.Content = "";
            lblYear.Content = "";
            lblDirector.Content = "";
            lblRunningTime.Content = "";

            // Clear film image.
            imgMoviePoster.Source = null;

            #region DB Info test.
            // Display rough list of films.
            try
            {          
            var query = from f in db.Films
                        where f.Actor == actor
                        orderby f.ReleaseDate
                        select f;

            lbxFilmography.ItemsSource = query.ToList();
            }
            catch (EntityException eE)
            {
                MessageBox.Show("Something went wrong - The filmography database could not be loaded correctly.");
            }
            #endregion
        }        

        private void lbxFilmography_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //// Get selected film.
            Film selectedFilm = lbxFilmography.SelectedItem as Film;

            if (selectedFilm != null)
            {
                // Display film info.
                lblName.Content = selectedFilm.Title;
                lblYear.Content = selectedFilm.ReleaseDate;
                lblDirector.Content = selectedFilm.Director;
                lblActor.Content = selectedFilm.Actor;
                lblRunningTime.Content = selectedFilm.RunningTime;

                // Display film image.
                imgMoviePoster.Source = new BitmapImage(new Uri(selectedFilm.PosterImage));
            }
        }        

        private void btnAddFilm_Click(object sender, RoutedEventArgs e)
        {
            // Get selected film.
            Film selectedFilm = lbxFilmography.SelectedItem as Film;

            if(selectedFilm != null)
            {
                foreach(Film f in watchlistWindow.watchlistFilms)
                {
                    if(f.Title == selectedFilm.Title)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (alreadyAdded == false)
                {
                    watchlistWindow.watchlistFilms.Add(selectedFilm);
                }                            
            }
        }

        private void btnViewWatchlist_Click(object sender, RoutedEventArgs e)
        {        
            // Display the watchlist window.
            watchlistWindow.ShowDialog();
        }
    }
}

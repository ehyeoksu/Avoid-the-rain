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
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace _Prj__WPF__Game___Save_the_Human2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer rainTimer = new DispatcherTimer();
        DispatcherTimer userTimer = new DispatcherTimer();

        bool team1Selected = false;
        bool team2Selected = false;
        bool team1wetted = false;
        bool team2wetted = false;


        public MainWindow()
        {
            InitializeComponent();

            rainTimer.Tick += RainTimer_Tick;
            rainTimer.Interval = TimeSpan.FromSeconds(0.01);

            userTimer.Tick += UserTimer_Tick;
            userTimer.Interval = TimeSpan.FromSeconds(1);
        }

        private void endTheGame()
        {
            rainTimer.Stop();
            userTimer.Stop();
            team1Selected = false;
            team2Selected = false;
            team1wetted = false;
            team2wetted = false;
        }

        private void RainTimer_Tick(object sender, EventArgs e)
        {
            addRain();
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value >= progressBar.Maximum)
                endTheGame();
        }

        private void addRain()
        {

        }


       


        // Create Team1&2
        private void showTeam1(string fileName)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(fileName, UriKind.Relative);
            bi.EndInit();
            team1.Stretch = Stretch.Fill;
            team1.Source = bi; 
        }
        private void showTeam2(string fileName)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(fileName, UriKind.Relative);
            bi.EndInit();
            team2.Stretch = Stretch.Fill;
            team2.Source = bi;
        }

        // Select Team1
        private void team1Pikachu_Click(object sender, RoutedEventArgs e)
        {
            if(!team1Selected)
               showTeam1("Pikachu.jpg");
        }
        private void team1Squirtle_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected)
                showTeam1("Squirtle.jpg");
        }
        private void team1Charmander_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected)
                showTeam1("Charmander.jpg");
        }
        private void team1Chikorita_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected)
                showTeam1("Chikorita.jpg");
        }
        private void team1Bulbasaur_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected)
                showTeam1("Bulbasaur.jpg");
        }
        
        // Select Team2
        private void team2Pikachu_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                showTeam2("Pikachu.jpg");
        }
        private void team2Squirtle_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                showTeam2("Squirtle.jpg");
        }
        private void team2Charmander_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                showTeam2("Charmander.jpg");
        }
        private void team2Bulbasaur_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                showTeam2("Bulbasaur.jpg");
        }
        private void team2Chikorita_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                showTeam2("Chikorita.jpg");
        }

        // Ready Team1&2
        private void team1Ready_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected)
                team1Selected = true;
        }
        private void team2Ready_Click(object sender, RoutedEventArgs e)
        {
            if (!team2Selected)
                team2Selected = true;
        }
       
        // Move Team1&2

        
         
        // Start Game
        private void startGame()
        {

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (!team1Selected && !team2Selected)
                startGame();
        }
    }
}

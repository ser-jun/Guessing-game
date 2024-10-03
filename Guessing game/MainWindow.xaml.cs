using System.Windows;

namespace Guessing_game
{
    public partial class MainWindow : Window
    {
        private int lowerBound = 1;
        private int upperBound = 1000;
        private int guess;

        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("Задумайте число от 1 до 1000!", "Угадайка");
            GuessingNumber();
        }

        private void GuessingNumber()
        {
            guess = (lowerBound + upperBound) / 2;

            MessageBoxResult result = MessageBox.Show($"Ваше число — это {guess}?", "Угадайка", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes) { MessageBox.Show("Я угадал!", "Угадайка"); Close(); }

            else
            {

                MessageBoxResult moreLess = MessageBox.Show($"Ваше число больше {guess}?", "Угадайка", MessageBoxButton.YesNo);

                if (moreLess == MessageBoxResult.Yes) { lowerBound = guess + 1; }

                else { upperBound = guess - 1; }


                GuessingNumber();
            }
        }
    }
}

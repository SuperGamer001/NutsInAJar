namespace NutsInAJar
{
    internal class Game
    {
        int numberOfNuts;
        string difficulty;
        int attempts;

        public Game() { }

        public void Start(int numberOfNuts, string difficulty = "easy")
        {
            Random random = new Random();
            this.numberOfNuts = random.Next(0, numberOfNuts + 1);  
            this.difficulty = difficulty;
            this.attempts = 0;
        }

        public bool Guess(string guess)
        {
            this.attempts++;
            int guessNumber;
            if (int.TryParse(guess, out guessNumber))
            {
                if (guessNumber == this.numberOfNuts)
                {
                    MessageBox.Show("Correct! You guessed the right number of nuts.");
                    return true;
                }
                else
                {
                    if (difficulty == "easy")
                    {
                        if (guessNumber < this.numberOfNuts)
                        {
                            MessageBox.Show("Too low! Try again.");
                        }
                        else
                        {
                            MessageBox.Show("Too high! Try again.");
                        }
                    }
                    else if (difficulty == "normal")
                    {
                        if (attempts < 8)
                        {
                            if (guessNumber < this.numberOfNuts)
                            {
                                MessageBox.Show("Too low! Try again.");
                            }
                            else
                            {
                                MessageBox.Show("Too high! Try again.");
                            }
                        }
                        else
                        {
                            if (attempts == 9)
                            {
                                MessageBox.Show("Nope! You have now used up all your hints. Try again.");
                            }
                            else
                            {
                                MessageBox.Show("Nope! Try again.");
                            }
                        }
                    }
                    else if (difficulty == "hard")
                    {
                        if (attempts > 20)
                        {
                            MessageBox.Show("Nope! Hard, isn't it?");
                        }
                        else
                        {
                            MessageBox.Show("Nope! Try again.");
                        }
                    }
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                attempts--;
                return false;
            }
        }
    }
}
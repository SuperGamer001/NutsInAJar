namespace NutsInAJar
{
    internal class Game
    {
        int numberOfNuts;
        string difficulty;
        int attempts;
        int[] AIGuesses = new int[50];

        public Game()
        {
            // No Initialization needed
        }

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
                    if (attempts == 1)
                    {
                        if (difficulty == "Hard")
                        {
                            MessageBox.Show("HOW DID YOU GET THAT ON YOUR FIRST TRY?! You must be the luckiest person in the world.");
                        }
                        else
                        {
                            MessageBox.Show("Wow! You got that on your first try!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correct! You guessed the right number of nuts in " + this.attempts + " tries.");
                    }

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
                            if (attempts == 8)
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

        public int GetAIGuess()
        {
            Random random = new Random();
            int guess = random.Next(0, 51);
            if (attempts != 50)
            {
                while (Array.Exists(AIGuesses, element => element == guess))
                {
                    guess = random.Next(0, 51);
                }
                AIGuesses[attempts] = guess;
                attempts++;

                return guess;
            }
            else
            {
                return -1;
            }
        }

        public int GetAttempts()
        {
            return attempts;
        }
    }
}
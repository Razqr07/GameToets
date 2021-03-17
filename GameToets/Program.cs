using System;

namespace GameToets
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
           

            void Menu()
            {
                string MenuInput;

                Console.WriteLine("Read rules [R]  Start game [S] Close game [C] ");

                MenuInput = Console.ReadLine();

                if (MenuInput.ToUpper() == "R")
                {
                    Console.WriteLine("Every player throws 2 dice. The player with the lowest score loses a life. Player with the highest score gains a life. ");
                    Menu();
                }
                else if (MenuInput.ToUpper() == "S")
                {
                    PlayerCheck();
                }
                else if (MenuInput.ToUpper() == "C")
                {
                    //Close game 
                }
                else
                {
                    Menu();
                }
            }
                void PlayerCheck()
                {
                    Start();
                }
                void Start()
                {
                    Random rnd = new Random();

                    bool play = true;

                int lives = 3,
                    playerOneLife = lives,
                    playerOneRoll1,
                    playerOneRoll2,
                    playerOneTotal,
                    playerTwoLife = lives,
                    playerTwoRoll1,
                    playerTwoRoll2,
                    playerTwoTotal,
                    playerThreeLife = lives;



                while (play == true)
                    {
                        do
                        {
                            Console.WriteLine("-=+=-");
                            Console.WriteLine("YOUR ROLLS");
                            RollDice();
                            LifeUpdater();
                            LifeDisplayer();
                            Console.WriteLine("-=+=-");
                            Stopper();
                        }
                        while(playerOneLife > 0 && playerTwoLife > 0); 
                        {
                            Console.WriteLine("-=+=-");
                            Console.WriteLine("Your game has ended!");
                            Console.WriteLine("This is your final score!");
                            LifeDisplayer();
                            FinalScore();
                            Console.WriteLine("-=+=-");

                            playAgain();
                        }
                    }

                    void RollDice()
                    {
                        playerOneRoll1 = rnd.Next(1, 4);
                        playerOneRoll2 = rnd.Next(1, 4);
                        playerOneTotal = playerOneRoll1 + playerOneRoll2;
                        Console.WriteLine($"Player 1 rolled {playerOneRoll1} and {playerOneRoll2}. Making a total of {playerOneTotal}.");

                        playerTwoRoll1 = rnd.Next(1, 4);
                        playerTwoRoll2 = rnd.Next(1, 4);
                        playerTwoTotal = playerTwoRoll1 + playerTwoRoll2;
                        Console.WriteLine($"Player 2 rolled {playerTwoRoll1} and {playerTwoRoll2}. Making a total of {playerTwoTotal}.");

                    }

                    void LifeDisplayer()
                    {
                        Console.WriteLine($"Player 1 has {playerOneLife} lives left!");
                        if (playerOneLife < 0)
                        {
                            Console.WriteLine("Player 1 has no lives left :(");
                        }
                    
                    Console.WriteLine($"Player 2 has {playerTwoLife} lives left!");
                        if (playerTwoLife < 0)
                        {
                            Console.WriteLine("Player 2 has no lives left :(");
                        }
                    
                    }

                void Stopper()
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                void LifeUpdater()
                    {
                        if (playerOneTotal > playerTwoTotal)
                        {
                            Console.WriteLine("Player 1 won this round!");
                            Console.WriteLine("Player 2 lost one life and player 1 gained one life!");
                            playerTwoLife--;
                            playerOneLife++;
                        }
                        else if (playerOneTotal < playerTwoTotal)
                        {
                            Console.WriteLine("Player 2 won this round!");
                            Console.WriteLine("Player 1 lost one life and player 2 gained one life!");
                            playerOneLife--;
                            playerTwoLife++;
                        }
                        else
                        {
                            Console.WriteLine("You had the same score!");
                            Console.WriteLine("No one lost one life!");
                        }
                    }
                    void FinalScore()
                    {
                            if (playerOneLife > playerTwoLife)
                            {
                                Console.WriteLine("Player 1 won!");
                                Console.WriteLine("-=+=-");
                                Console.WriteLine("Play again? [Y/N]");
                                playAgain();
                    }
                            else if (playerOneLife < playerTwoLife)
                            {
                                Console.WriteLine("Player 2 won!");
                                Console.WriteLine("-=+=-");
                                Console.WriteLine("Play again? [Y/N]");
                                playAgain();
                    }
                            else
                            {
                                Console.WriteLine("No one won, It's a tie!");
                                Console.WriteLine("-=+=-");
                                Console.WriteLine("Play again? [Y/N]");
                                playAgain();

                            }
                    }
                        void playAgain()
                        {
                        string playAgainInput;
                            playAgainInput = Console.ReadLine();

                            if (playAgainInput.ToUpper() == "Y")
                            {
                                play = true;
                                Console.Clear();
                                Menu();
                            }
                            else if (playAgainInput.ToUpper() == "N")
                            {
                                play = false;
                                Menu();
                            }
                            else
                            {
                                playAgain();
                            }
                        }


                        }
                    }
                }


   }

            
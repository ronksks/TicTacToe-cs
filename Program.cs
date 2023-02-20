using System;
using System.Diagnostics;

namespace TicTacToe
    {
    class Program
        {

        static char[,] playField =
            {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
            };



        static void Main(string[] args)
            {

            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;


            do
                {
                if (player == 2)
                    {
                    player = 1;
                    EnterXorO(player, input);

                    }
                else if (player == 1)
                    {
                    player = 2;
                    EnterXorO(player, input);

                    }

                SetField();
                #region
                // Check winnig condition
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                    {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))

                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))

                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                        )
                        {
                        if (playerChar == 'X')
                            {
                            Console.WriteLine($"\n{playerChar} is the winner!");
                            }
                        else
                            {
                            Console.WriteLine($"\n{playerChar} is the winner!");
                            }
                        break;
                        }
                    ///////// continue ////////////////////
                    }


                #endregion

                #region
                // Test if fiesld is already taken
                do
                    {
                    Console.WriteLine($"\nPlayer {player}: Choose your field");
                    try
                        {

                        input = Convert.ToInt32(Console.ReadLine());
                        }
                    catch (Exception ex)
                        {
                        Console.WriteLine("Please enter a number!");
                        }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                        {
                        Console.WriteLine("\n Incorrect Input! Please enter a correct field!");
                        inputCorrect = false;
                        }


                    } while (!inputCorrect);
                #endregion

                } while (true);

            }

        public static void SetField()
            {
            Console.Clear();
            Console.WriteLine("   |   |    ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |    ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |    ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            }

        public static void EnterXorO(int player, int input)
            {
            char PlayerSign = ' ';
            if (player == 1)
                PlayerSign = 'X';
            else if (player == 2)
                PlayerSign = 'O';

            switch (input)
                {
                case 1: playField[0, 0] = PlayerSign; break;
                case 2: playField[0, 1] = PlayerSign; break;
                case 3: playField[0, 2] = PlayerSign; break;
                case 4: playField[1, 0] = PlayerSign; break;
                case 5: playField[1, 1] = PlayerSign; break;
                case 6: playField[1, 2] = PlayerSign; break;
                case 7: playField[2, 0] = PlayerSign; break;
                case 8: playField[2, 1] = PlayerSign; break;
                case 9: playField[2, 2] = PlayerSign; break;
                }
            }
        }
    }
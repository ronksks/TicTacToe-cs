Tic Tac Toe Game in C#
This program implements the Tic Tac Toe game using C#. The game involves two players, who take turns placing their mark (X or O) in a 3x3 grid until a player wins or the game ends in a draw.

The playfield is represented by a two-dimensional character array named playField, with each element containing a number from 1 to 9 representing the available spaces on the board.

The program uses the console to get input from the players and display the game board. If a player enters an incorrect input, the program will prompt the player to enter a correct field.

The game also checks after each turn if a player has won or if the game has ended in a draw. If either of these conditions is met, the game will prompt the players to reset the game and start again.

How to Play
Run the program and follow the prompts to play.

Player 1 will start the game and choose a field by entering a number between 1 and 9.

Player 2 will then take their turn and choose a field.

The game will continue until a player wins or the game ends in a draw.

If a player wins or the game ends in a draw, the program will prompt the players to reset the game and start again.

Implementation Details
The program contains a ResetField function that resets the playField array to its initial state, and a SetField function that displays the current state of the playField array on the console.

The playField array is initialized with the numbers 1 to 9 representing the available spaces on the board.

The program checks for winning conditions by comparing the elements of the playField array to the possible winning combinations. If a winning combination is found, the program will display the winner and prompt the players to reset the game.

The program also checks for a draw by keeping track of the number of turns taken. If 10 turns are taken and no winning combination is found, the program will display a draw message and prompt the players to reset the game.

   |   |
 1 | 2 | 3
___|___|___
   |   |
 4 | 5 | 6
___|___|___
   |   |
 7 | 8 | 9
   |   |

Player 1: Choose your field
1

   |   |
 X |   |
___|___|___
   |   |
   |   |
___|___|___
   |   |
   |   |
   |   |

Player 2: Choose your field
5

   |   |
 X |   |
___|___|___
   |   |
 O |   |
___|___|___
   |   |
   |   |
   |   |

...

Player 2 is the winner!

Please press any key to reset the game

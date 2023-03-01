# Tic Tac Toe Game in C#
## This program implements the Tic Tac Toe game using C#.<br />
The game involves two players, who take turns placing their mark (X or O) in a 3x3 grid until a player wins or the game ends in a draw.<br />

The playfield is represented by a two-dimensional character array named playField, with each element containing a number from 1 to 9 representing the available spaces on the board.<br />

The program uses the console to get input from the players and display the game board.<br />
If a player enters an incorrect input, the program will prompt the player to enter a correct field.<br />

The game also checks after each turn if a player has won or if the game has ended in a draw. <br />
If either of these conditions is met, the game will prompt the players to reset the game and start again.<br />

## How to Play
Run the program and follow the prompts to play.<br />

Player 1 will start the game and choose a field by entering a number between 1 and 9.<br />

Player 2 will then take their turn and choose a field.<br />

The game will continue until a player wins or the game ends in a draw.<br />

If a player wins or the game ends in a draw, the program will prompt the players to reset the game and start again.<br />

## Implementation Details
The program contains a ResetField function that resets the playField array to its initial state, <br />
and a SetField function that displays the current state of the playField array on the console.<br />

The playField array is initialized with the numbers 1 to 9 representing the available spaces on the board.<br />

The program checks for winning conditions by comparing the elements of the playField array to the possible winning combinations.<br />
If a winning combination is found, the program will display the winner and prompt the players to reset the game.<br />

The program also checks for a draw by keeping track of the number of turns taken.<br />
If 10 turns are taken and no winning combination is found, the program will display a draw message and prompt the players to reset the game.<br />


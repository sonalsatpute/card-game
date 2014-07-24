Card Game - Are you Lucky ?
==========================

�
I want to develop a multiplayer card game, where 5 cards will be distributed to each player, the game has 5 rounds, in each round each player will draw a card. A player with higher card will win the round and the player who will win maximum rounds will win the game.
�
Higher card rule - 
1. 	Card will be compared with the suite first, below is the order of suite
	Diamonds > Hearts > Clubs > Spades (Diamonds card are higher than Hearts are higher than Clubs are higher that Spades.

2. 	For same suite cards the they are compared based on the face value where 
	Ace = 1, Jack = 11, Queen 		= 12 and King = 13
�
keywords --> D = Diamonds, H = Hearts, C = Clubs, S = Spades

�
Story 1 - 	As a player, I want to shuffle a deck of cards (52 cards) 
				so that cards will be distributed randomly.
�
Input - 
			D Ace, D 2, D 3, D 4, D 5, D 6, D 7, D 8, D 9, D 10, D Jack, D Queen, D King
			H Ace, H 2, H 3, H 4, H 5, H 6, H 7, H 8, H 9, H 10, H Jack, H Queen, H King
			C Ace, C 2, C 3, C 4, C 5, C 6, C 7, C 8, C 9, C 10, C Jack, C Queen, C King
			S Ace, S 2, S 3, S 4, S 5, S 6, S 7, S 8, S 9, S 10, S Jack, S Queen, S King
	�
Output - 1. Not in the same order as above, 2. No more than 3 consecutive cards of the same suite


�
Story 2 - 	As a player, I want to distribute one card to each team player 
			(total 4 players including me) so that game is ready to play.
�
Input 	- 	All 52 cards in random order
Output 	- 	each player gets one cards, all four cards are unique

�
Story 3 - 	As a player, I want to start playing a game, each player draws their card 
			so that winner is decided based on the higher card (See the rule to decide higher card)
�
Scenario 1
Input -
		Player 1 --> C 5
		Player 2 --> S 10
		Player 3 --> C Queen
		Player 4 --> D 2
�
Output - Winner is Player 4
�
Scenario 2
Input -
		Player 1 --> S 10
		Player 2 --> S 9
		Player 3 --> C 10
		Player 4 --> C 9
�
Output - Winner is Player 3

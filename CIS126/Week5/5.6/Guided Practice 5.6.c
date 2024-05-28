/*
Guided Practice 5.6 - GAME
Ruben T
CIS126 | T. Sullivan
1.17.2023
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void intro();

void lake();

void mountain();

void youDie();

void magicBoat();

int main()
{
	intro();
	
	return 0;
}

void intro()
{
	char choice;
	
	printf("You have crash landed on the planet Zondar!\nYou exit the spaceship...\nTo your left you see moutains\nTo your right you see a large lake of water...\nDo you want to go to the left or right? (L or R)...\n");
	scanf("%c", &choice);
	
	while(choice != 'L' && choice != 'R' && choice != 'l' &&  choice != 'r')	
	{
		printf("That is not a legal choice\nPlease enter L or R...");
		scanf(" %c", &choice);
	}
	
	if(choice == 'L' || choice == 'l')
	{
		mountain(); //Takes player to the moutains | Calls the moutains fucntion			
	}
	else
	{
		lake();
	}
	
}// End of intro funciton

void mountain()
{
	char choice;
	printf("You have chosen to enter the moutains...\n\nIn the moutains you see a cave!\nOutside of the cave is a GIANT MONSTER\nDo you want to fight the monster or run away? (F OR R)");
	scanf(" %c", &choice);
	
	if(choice == 'R')
	{
		intro();
	}
	else 
	{
		youDie();
	}	
}// End of moutains function

void lake()
{
	int die = 0;
	char choice;
	
	printf("You chose to go to the lake....\n\nAt the lake shore you see a crystal table...\nOn the crystal table is a single GLOWING DIE\nA sign on the table says that if you can roll a six...\nDo you want to roll the die? (Y or N)\n\n");
	scanf(" %c", &choice);
	
	if(choice == 'Y')
	{
		srand(time(NULL));
		die = rand() % 6 + 1;
		
		switch(die)
		{
			case 1:
				youDie();
				break;
			case 2:
				youDie();
				break;
			case 3:
				youDie();
				break;
			case 4:
				youDie();
				break;
			case 5:
				youDie();
				break;
			case 6:
				magicBoat();
				break;
		}
	}
} // End of lake function

void youDie()
{
	printf("Y  O  U    D  I  E D");
}

void magicBoat()
{
	printf("The magic boat appears...\nYou get in the boat and it takes you to...\nA wonderful land with rivers of Red Bull and nachos...\nAnd Wu Tang Clan playing.\n\n");
}
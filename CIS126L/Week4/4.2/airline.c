#include <stdio.h>

#define NUM_SEATS 11 //

int isSeatAvailable(int seatNumber, int seats[]) { // return 1 if its available otherwise 0 for unavailable
	int available;
	int index = seatNumber - 1;
	
	if (seats[index] == 0) { // checks if seat is available
		seats[index] = 1; // "Reserve" the seat (Re-assign its posistioned value to 1)
		available = 1;
	} else {
		available = 0;
	}
	
	return available;
}

void printBoardingPass(int cls, int seatNum) { // Helper to avoid printing rep
	if (cls == 1) { 
		printf("\tBoarding Pass\nSeat#: %d | Class: First", seatNum);
	}
	else {
		printf("\tBoarding Pass\nSeat#: %d | Class: Economy", seatNum);
	}
}

int checkFlightFull(int seats[]) { // Check if flight is full be summing the items in the array and comparing to its length
	int tot = 0;
	int i;
	
	for (i = 0; i < 11; i++) {
		tot += seats[i];
	}
	if (tot == 10) {
		return 1; // all seats are taken
	} else {
		return 0;
	}
}

void main() {
	int seats[NUM_SEATS] = {0};  //Puts 0s in all the cells
	int seatsSold = 0,seatChoice, seatNumber;
	char sentinel = 'Y';
	
	while(sentinel == 'Y') {
		if(checkFlightFull(seats) == 1) {
			printf("Flight is full. Exiting...");
			break;
		}
		
		printf("Enter a seating class (1. First | 2. Economy): ");
		scanf("%d", &seatChoice);
		
		if( seatChoice == 1 ) { // First Class Seats
		    for(seatNumber = 1; seatNumber < 6; seatNumber++) {
				if (isSeatAvailable(seatNumber, seats) == 1) {
					printBoardingPass(seatChoice, seatNumber);
					break;
				}
			}
			if (seatNumber >= 6) { 
				char choice;
				printf("First Class is full. Would you like to try economy: (Y/N): ");
				scanf(" %c", &choice);
				
				if (choice == 'Y') {
					if (isSeatAvailable(seatNumber, seats)) {
						printBoardingPass(2, seatNumber);
					}
				} else {
					printf("\nNext flight is leaving in 3 hours...");
				}
				
			}
		
		} 
		else { // Economy
			for(seatNumber = 6; seatNumber < 11; seatNumber++) {
				if (isSeatAvailable(seatNumber, seats) == 1) {
					printBoardingPass(seatChoice, seatNumber);
					break;
				}
			}
			if (seatNumber >= 11) { 
				printf("Seat is full... Switch boarding class!");
			}
		}
		printf("\n\nWould you like to book another seat: (Y/N): ");
		scanf(" %c", &sentinel);	
	}
}

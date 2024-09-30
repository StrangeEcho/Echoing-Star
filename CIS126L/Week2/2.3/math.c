/*
Project 2.3 - Math Practice Week 2
Ruben T
CIS126L | John Bowerman
12.21.2023
*/

#include <stdio.h>
#include <time.h>

int displayOptions() { // Helper function to display options and collect what type of operation they want to do
    int desiredOp;
    printf("\n1. Addition\n"
    "2. Subtraction\n"
    "3. Division\n"
    "4. Multiplication\n\n"
    "Enter a number corresponding to the desired operation: ");
    scanf("%d", &desiredOp);
    return desiredOp;
}

void displayTime() { // Helper function to get the current time
    time_t currentTime;
    char* timeString;

    currentTime = time(NULL);
    timeString = ctime(&currentTime);
    printf("Current time is %s", timeString);

}
void main() { 
    displayTime();

    short sentinel = 1; // Single declartion for sentinel value

    while (sentinel != -1) { 
        short op = displayOptions(); // Collect user choice
        switch (op) { // Propogate a problem session depending on what op is <1-4>
            int answer; 
            case 1:
                printf("4 + 4 = ");
                scanf("%d", &answer);
                if (answer == 8) {
                    printf("You are correct");
                }
                else {
                    printf("You're wrong");
                }
                break;
            case 2:
                printf("10 - 5 = ");
                scanf("%d", &answer);
                if (answer == 5) {
                    printf("You are correct");
                }
                else {
                    printf("You're wrong");
                }
                break;
            case 3:
                printf("100 / 20 = ");
                scanf("%d", &answer);
                if (answer == 5) {
                    printf("You are correct");
                }
                else {
                    printf("You're wrong");
                }
                break;
            case 4:
                printf("10 * 5 = ");
                scanf("%d", &answer);
                if (answer == 50) {
                    printf("You are correct");
                }
                else {
                    printf("You're wrong");
                }
                break;
        }
        printf("\nEnter 1 to try again and -1 to exit: "); // Collect sentinel
        scanf("%hd", &sentinel);
    }

}
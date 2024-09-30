/*
3.3 Project - Math Practice Week 3
Ruben T
CIS126L | John Bowerman
12.26.2023
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int attempts = 0;
int correctAttempts = 0;

int* generateNumbers() { // Used for operations like subtraction and division
    int num1, num2;
    static int numArray[2];
    while (1) { 
        num1=rand() % 100 + 1; 
        num2=rand() % 100 + 1; 
        if (num1 > num2) { 
            numArray[0] = num1;
            numArray[1] = num2;
            break;
        }
    }
    return numArray;
}

void addition() {
    int num1, num2, answer, input; 

    num1=rand() % 100 + 1; 
    num2=rand() % 100 + 1; 
    answer = num1 + num2;

    printf("%d + %d = ", num1, num2);
    scanf("%d", &input);

    if (input == answer) {
        correctAttempts += 1;
        printf("You are correct!");
    }
    else {
        printf("You are incorrect...");
    }
}

void subtraction() { 
    int num1, num2, input, answer;

    int* array = generateNumbers();
    num1 = array[0];
    num2 = array[1];
    answer = num1 - num2;


    printf("%d - %d = ", num1, num2);
    scanf("%d", &input);

    if (input == answer) {
        correctAttempts += 1;
        printf("You are correct!");
    }
    else {
        printf("You are incorrect...");
    }
}

void multiply() { 
    int num1, num2, answer, input; 

    num1=rand() % 100 + 1; 
    num2=rand() % 100 + 1; 
    answer = num1 * num2;

    printf("%d * %d = ", num1, num2);
    scanf("%d", &input);

    if (input == answer) {
        correctAttempts += 1;
        printf("You are correct!");
    }
    else {
        printf("You are incorrect...");
    }
}

void division() { 
    int num1, num2, input, answer;

    int* array = generateNumbers();
    num1 = array[0];
    num2 = array[1];
    answer = num1 / num2;


    printf("%d / %d = ", num1, num2);
    scanf("%f", &input);

    if (input == answer) {
        correctAttempts += 1;
        printf("You are correct!");
    }
    else {
        printf("You are incorrect...");
    }
}

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
    printf("Welcome to Ruben's Math Program!\n");
    srand(time(NULL)); 
    displayTime();

    short sentinel = 1; // Single declartion for sentinel value

    while (sentinel != -1) {
        attempts += 1; // increment
        short op = displayOptions(); // Collect user choice
        switch (op) { // Propogate a problem session depending on what op is <1-4>
            int answer; 
            case 1:
                addition();
                break;
            case 2:
                subtraction();
                break;
            case 3:
                division();
                break;
            case 4:
                multiply();
                break;
        }
        printf("\nEnter 1 to try again and -1 to exit: "); // Collect sentinel
        scanf("%hd", &sentinel);
    }
    printf("You finished the math program. %d correct attempts out of %d total attempts", correctAttempts, attempts);
}
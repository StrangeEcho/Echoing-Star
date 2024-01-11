/*
Project 1.5 - Math Practice Week 1
Ruben T
CIS126L | John Bowerman
12.14.2023
*/

#include <stdio.h>

void main() {
    int answer = 10, userinput; // Define correct answer and user input variables
    printf("5 + 5 = ");
    scanf("%d", &userinput); // Get user input as the answer

    if (userinput != answer) { // Logic to check if the answer the user put in is correct or incorrect
        printf("You guessed %d, you are incorrect!", userinput);
    }
    else { // Fallback else denoting the answer is correct
        printf("You are correct");
    }
}
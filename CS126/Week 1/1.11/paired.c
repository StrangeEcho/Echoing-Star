/*
Guided Practice 1.11 - Paired Programming
Ruben T, Devin A, Jaylin P
CIS126 | T. Sullivan
12.14.2023
*/

#include <stdio.h>

void main() 
{
    int num1, num2, num3;
    char initials[3]; // Declare a 3 element max char array
    
    printf("Enter your first number: ");
    scanf("%d", &num1);
    printf("Enter your second number: ");
    scanf("%d", &num2);
    printf("Enter your third number: ");
    scanf("%d", &num3);
    
    if (num1 > num2) {
        printf("First is greater");
    }
    else {
        printf("Second is greater");
    }
    
    int average = (num1 + num2 + num3) / 3;

    printf("\n\nThe average is %d", average);

    if (average > 10) {
        printf(" -  which is greater than 10\n"); // Stack onto line before if the avg > 10 
    }
    printf("\nEnter your initials: ");
    scanf(" %s", initials);

    printf("\nThank you %s for using this program: ", initials);
}
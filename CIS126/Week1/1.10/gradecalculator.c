/*
Guided Practice 1.10
Ruben T
CIS126 | Thomas Sullivan
12.13.2023
*/

#include <stdio.h>

int main(void) 
{
    int grade;

    printf("Enter your grade: ");
    scanf("%d", &grade);

    if (grade >= 90){
        printf("Your grade is an A \n");
    }
    else if (grade >= 80){
        printf("Your grade is a B \n");
    }
    else if (grade >= 70){
        printf("Your grade is a C \n");
    } 
    else if (grade >= 60){
        printf("Your grade is an D");
    }
    else{
        printf("Your grade is an F \n");
    }

    char letterGrade; 

    printf("Please enter your final letter grade: ");
    scanf(" %c", &letterGrade);

    if(letterGrade == 'A' || letterGrade == 'a'){
        printf("You did great! \n");
    }
    else if(letterGrade == 'B' || letterGrade == 'b'){
        printf("You did well! \n");
    }
    else if(letterGrade == 'C' || letterGrade == 'c'){
        printf("You did okay \n");
    }
    else if(letterGrade == 'D' || letterGrade == 'd'){
        printf("You did bad \n");
    }
    else{
        printf("You FAILED \n");
    }
}
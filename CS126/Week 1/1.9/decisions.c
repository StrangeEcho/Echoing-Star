/*
Performance Assessment 1.9 - Decision
Ruben T
CIS126 | Thomas Sullivan
12.14.2023
*/

#include <stdio.h>

void main() {
    int grade1, grade2, grade3, average;
    grade1 = 84;
    grade2 = 98;
    grade3 = 73;

    average = (grade1 + grade2 + grade3) / 3;
    printf("Grade Average %d\n", average);
    if (average > 65) {
        printf("You passed");
    }

}
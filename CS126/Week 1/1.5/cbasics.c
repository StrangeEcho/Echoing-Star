/*
Guided Practice 1.5
Ruben T
CIS126 | Thomas Sullivan
12.11.2023
*/

#include <stdio.h>

void main() {
    int num1, num2, multiply, add, sub;

    printf("Enter the first number: ");
    scanf("%d", &num1);
    printf("Enter the second number: ");
    scanf("%d", &num2);

    multiply = num1 * num2;
    sub = num1 - num2;
    add = num1 + num2;

    printf("The product of both numbers is: %d\n", multiply);
    printf("The sum of both numbers is: %d\n", add);
    printf("The difference of both numbers is: %d\n", sub);
}
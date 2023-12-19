/*
2.3 Guided Practice - Using Else...If Statements to make Multiple Decision 
Ruben T
CIS126 | Thomas Sullivan
12.18.2023
*/

#include <stdio.h>

void main() { 
    int num1, num2; 

    printf("Enter the first number");
    scanf("%d", &num1);
    printf("Enter the second number");
    scanf("%d", &num2);

    if (num1 > num2) {
        printf("The first number is greater than the second number");
    }
    else if (num1 < num2) { 
        printf("The first number is less than the second number ");
    }
    else {
        printf("Both of the numbers you entered are equal");
    }
}
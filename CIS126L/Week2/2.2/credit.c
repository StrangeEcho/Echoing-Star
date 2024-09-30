/*
Performance Assessment 2.2 - Credit Limit Lab
Ruben T
CIS126L | John Bowerman
12.21.2023
*/

#include <stdio.h>

void main() { 
    short sentinel = 1; // variable declarations
    int accountNumber, beginningBalance, totalCharges, totalCredits, allowedCredit, newBalance;

    while (sentinel != -1) { // Collect user input
        printf("Enter your account number: ");
        scanf("%d", &accountNumber);
        printf("Enter your beginning balance: ");
        scanf("%d", &beginningBalance);
        printf("Enter your total charges: ");
        scanf("%d", &totalCharges);
        printf("Enter your total credits: ");
        scanf("%d", &totalCredits);
        printf("Enter your allowed credit: ");
        scanf("%d", &allowedCredit);

        newBalance = beginningBalance + totalCharges - totalCredits; // balance calculation
        if (newBalance > allowedCredit) { // display when credit limit is exceesed
            printf("\nAccount Number %d\n"
            "Credit Limit: %d\n"
            "Balance: %d\n"
            "Credit Limit Exceeded\n\n\b", accountNumber, allowedCredit, newBalance);
        }
        printf("\nEnter -1 if you want to exit or enter 1 to continue: "); // Enter sentinel and re-loop if desired
        scanf("%hi", &sentinel);
    }
}
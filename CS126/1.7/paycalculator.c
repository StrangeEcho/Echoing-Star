// Mr. Sullivan
// 12/13/2023
// Guided Practice 1.7

#include <stdio.h>

void main() {
    float annualPay; // Initial variable declaration

    printf("What is your annual pay: "); // Collect annual pay input
    scanf("%f", &annualPay);

    float weekly = annualPay / 52; // calculate weekly pay by diving annual by 52 weeks
    if (weekly > 1000) { // Check if there weekly is over 1000
        printf("You're making a lot of money. Dont spend too much now");
    }
    else {
        printf("You're broke");
    }
}
/*
Final Exam 5.5 - Hansens Discount SuperMarket
Ruben T
CIS126 | T. Sullivan
1.18.2024
*/

#include <stdio.h>

void main() {
    int itemCount, i;
    float price; 

    printf("Welcome to Hansen's discount super-market!\n\n");
    printf("How many items would you to purchase: ");
    scanf("%d", &itemCount);

    printf("The scanner is currently broken. Enter your item prices manually ( <= $10 )\n\n");

    float total = 0;
    for (i = 0; i < itemCount;) {
        printf("Enter price for item %d: ", i+1);
        scanf("%f", &price);
        if (price <= 10.0) {
            total += price;
            i++;
        }
        else {
            printf("Price is too high\n");
            i=i;
        }
    }

    float tax = total * 0.06;
    printf("Item Count: %d\nSubtotal: $%.2f\nTax(6%%): $%.2f\nGrand Total: $%.2f", itemCount, total, tax, total+tax);

}
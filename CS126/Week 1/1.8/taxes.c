/*
Performance Assessment 1.8 - C Code
Ruben T
CIS126 | Thomas Sullivan
12.13.2023
*/

#include <stdio.h>

void main() {
    float taxRate, salesAmount, salesTax;
    taxRate = 0.08;
    
    printf("Enter your sales amount(before tax): ");
    scanf("%f", &salesAmount);

    salesTax = salesAmount * taxRate;
    float totalSalesAmount = salesAmount + salesTax;

    printf("\n\nSales Tax: %.2f\nTotal Sales Amount: %.2f", salesTax, totalSalesAmount);
}
/*
Guided Practice 2.10 - Paired Programming
Ruben T, Jaylin P, Devin A
CIS126 | Thomas Sullivan
12.18.2023
*/

#include <stdio.h>

void main() { 
    float num, total;  
    int count = 0; 

    total = 0;
    while (1) {
        printf("Enter a number(-1 to stop): ");
        scanf("%f", &num);

        if (num == -1) {
            break; 
        }
        total += num;
        count++;
    }
    float avg = total / count;
    printf("\nTotal: %.2f  Average: %.2f\n", total, avg);
    printf("Group: Jaylin P, Ruben T, Devin A");
}
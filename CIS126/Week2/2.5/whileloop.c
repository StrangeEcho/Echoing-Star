#include <stdio.h>

void main() { 
    int count;
    float temp, total, avg; 
    count = 1;
    total = 0; 
    while (count <= 5) {
        printf("Enter the daily temperature: ");
        scanf("%f", &temp);
        total += temp;
        count++;
    }
    avg = total / (count - 1);
    printf("Average: %.2f", avg);
}
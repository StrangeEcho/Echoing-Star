#include <stdio.h>

char *calcChart = "BMI Values:\n\n"
"Underweight: less than 18.5\n"
"Normal: between 18.5 and 24.9\n"
"Overweight: between 25 and 29.0\n"
"Obese: 30 or greater";

void main() {
    int height, weight, calculatedBMI;

    printf("Enter your weight(in pounds): ");
    scanf("%d", &weight);
    printf("Enter your height(in inches): ");
    scanf("%d", &height);

    calculatedBMI = (weight * 703) / (height * height);
    printf("Your calculated Body Mass Index (BMI) is: %d\n\n", calculatedBMI);
    printf(calcChart);
}
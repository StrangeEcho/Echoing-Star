#include <stdio.h>



void main() {
    int height, weight, calculatedBMI; // Declartions for userinput and the calculated input off of that

   printf("BMI Values:\n\n" // Display calculation chart
"Underweight: less than 18.5\n"
"Normal: between 18.5 and 24.9\n"
"Overweight: between 25 and 29.0\n"
"Obese: 30 or greater\n\n");

    printf("Enter your weight(in pounds): "); // Get user input for height and weight
    scanf("%d", &weight);
    printf("Enter your height(in inches): ");
    scanf("%d", &height);

    calculatedBMI = (weight * 703) / (height * height); // BMI calculation
    printf("Your calculated Body Mass Index (BMI) is: %d\n\n", calculatedBMI);
}
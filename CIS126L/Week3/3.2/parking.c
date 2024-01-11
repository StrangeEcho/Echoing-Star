/*
3.2 Performance Assessment - Parking Garage Lab
Ruben T
CIS126L | John Bowerman
12.26.2023
*/

#include <stdio.h>

float calculateCharges(float hours) {
    if (hours < 3) { // If hours is less than three then they only have to pay 20 dollars (base charge)
        return 20.0;
    }
    float totalCharge = 20 + ((hours - 3) * 5); // Calculate the diff of the hours and the default hours and multiply by 5 and plus base charge
    return totalCharge;
}

void main() {
    float hours1, hours2, hours3, charge1, charge2, charge3; // Declare hours and charge vars

    printf("Enter the hours parked for Car 1: "); // Collect hourly for every car
    scanf("%f", &hours1);
    printf("\nEnter the hours parked for Car 2: ");
    scanf("%f", &hours2);
    printf("\nEnter the hours parked for Car 3: ");
    scanf("%f", &hours3);

    charge1 = calculateCharges(hours1); // Calculate parking charge for each car
    charge2 = calculateCharges(hours2);
    charge3 = calculateCharges(hours3);

    printf("Car\tHours\tCharge\n"); 
    printf("1\t%.2f\t$%.2f\n", hours1, charge1);
    printf("2\t%.2f\t$%.2f\n", hours2, charge2);
    printf("3\t%.2f\t$%.2f", hours3, charge3);
}
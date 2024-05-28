/*
3.2 Performance Assessment - Parking Garage Lab
Ruben T
CIS126L | John Bowerman
12.26.2023
*/

#include <stdio.h>

float calculateCharges(float hours); // prototype

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

float calculateCharges(float hours) {
    float charge; 

    if (hours > 0 && hours <=24) { // checks if the passed hours is greater than 0 and less than 24
        if (hours <= 3) {
            charge = 20.0; // return base charge if parked hours is less than or equal to three
        } else {
            charge = (20 + 5 * (hours - 3)); // "additional $5.00 per hour for each hour or part thereof in excess of three hours."
            if (charge < 50) {
                return charge; // return hours if less than max charge
            } else {
                return 50; // return max charge if charge is equal or greater than max charge
            }
        }
    }
}

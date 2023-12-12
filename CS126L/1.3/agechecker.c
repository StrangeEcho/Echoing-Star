#include <stdio.h>

void main() {
    int age; // Age input declartion
    printf("Enter what your age is: "); // Get age input
    scanf("%d", &age);
    
    if (age < 18) { // Logic checking if age < 18 | age <=65 | fallback else
        printf("You are a minor");
    }
    else if (age <= 65) {
        printf("You are of working age");
    }
    else { // If both if statements then they are older than 65 and retired
        printf("You are retired");
    }
}
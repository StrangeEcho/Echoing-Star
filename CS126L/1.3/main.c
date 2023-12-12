#include <stdio.h>

void main() {
    int age;
    printf("Enter what your age is: ");
    scanf("%d", &age);
    if (age < 18) {
        printf("You are a minor");
        return;
    }
    if (age >= 18 && age <= 65) {
        printf("You are of working age");
        return;
    }
    else {
        printf("You are retired");
    }
}
#include <stdio.h>

void main() {
    int age;
    printf("Enter what your age is: ");
    scanf("%d", &age);
    if (age < 18) {
        printf("You are a minor");
    }
    else if (age <= 65) {
        printf("You are of working age");
    }
    else {
        printf("You are retired");
    }
}
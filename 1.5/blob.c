#include <stdio.h>

int main() {
    int num1; // declartions
    int num2;
    int multiply;
    int sub;
    int add; 

    printf("Enter a number: ");
    scanf("%d", &num1);

    printf("Enter another number: ");
    scanf("%d", &num2);

    multiply = num1 * num2;
    sub = num1 - num2;
    add = num1 - num2;

    printf("The product of both numbers is: %d\n", multiply);
    printf("The sum of both numbers is: %d\n", add);
    printf("The difference of both numbers is: %d\n", sub);
    return 0;
}
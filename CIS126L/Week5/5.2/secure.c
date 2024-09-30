#include <stdio.h> 
#include <string.h>

#define MAX_SIZE 10 // max array size

void main() { 
    char data[MAX_SIZE];
    
    puts("Enter your string: ");
    int result = scanf_s("%s", data, MAX_SIZE);
    if (result == 1) { 
        puts(data);
    } else {
        printf("The string you entered is too large");
    }
}
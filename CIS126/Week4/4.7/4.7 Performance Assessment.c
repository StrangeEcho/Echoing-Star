/*
4.7 Performance Assessment
Ruben T
CIS126 | T.Sullivan
1.10.2024
*/

#include <stdio.h>
#include <string.h>

void main() { 
    char ecpi[] = "ECPI";
    char uni[] = "University";

    printf("%s %s\n\n", ecpi, uni);
    printf("Length 1: %d\nLength 2: %d", strlen(ecpi), strlen(uni));
}
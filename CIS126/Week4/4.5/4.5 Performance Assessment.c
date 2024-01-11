#include <stdio.h>

int main() {
    char welcomeMsg[] = "My Friends Ages Program";
    int ages[4];
    int i;

    ages[0] = 25;
    ages[1] = 27;
    ages[2] = 24;
    ages[3] = 26;

    for (i=0; i < 4; i++) {
        printf("Age: %d\n", ages[i]);
    }
    return 0;
}
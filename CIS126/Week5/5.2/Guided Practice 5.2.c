/*
Guided Practice 5.2 - Secure C Programming
Ruben T
CIS126 | T. Sullivan
1.17.2024
*/

#include <stdio.h>
#include <string.h>

int main(void){
	char buff[8];
	int pass = 0;
	
	printf("Enter the password: \n");
	gets(buff);
	
	if(strcmp(buff, "password")){
		printf("\n Wrong password");
	}
	else{
		printf("\n Correct password");
		pass = 1;
	}
	
	if(pass){
		printf("\n Root Privileges given to the user");
	}
}
from random import randint

print("rubtho6330")
num = randint(1, 9)
user_guess = 0
guess_counter = 0

while user_guess != num:
    guess_counter += 1
    user_guess = int(input("Enter a guess from 1 to 9: "))
    if user_guess < num:
        print("Guess is too low")
    elif user_guess > num:
        print("Guess is too high")
    else:
        print(f"You guessed it in {guess_counter} guesses")
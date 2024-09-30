import datetime

def goodbye_world():
    print("Goodbye world")

def check_range():
    number = int(input("Enter a number: "))
    message = f"Your number is {number}. Your number is greater than or equal to 100"
    if number < 100:
        message = f"Your number is {number}. Your number is less than 100"
    
    print(message)

def days_until_graduation():
    grad_date = input("Enter your graduation date (MM/DD/YYYY): ")
    now = datetime.datetime.now()
    month, day, year = grad_date.split("/")
    grad_time_actual = datetime.datetime(int(year), int(month), int(day))
    print(f"Current time: {grad_time_actual  - now}")


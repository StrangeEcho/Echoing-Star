def HelloWorld():
    print("Hello world, my name is Ruben Thomas")
    print("I am a student at ECPI University")
    print("I have never programmed a computer before")
    print("This is great")
    
def CheckEven():
    num = int(input("Enter a number: "))
    
    if num % 2:
        print("Number is odd")
    else:
        print("Number is even")

def Birthday():
    import datetime
    
    birthdate = input("What is your birthday (MM/DD/YYYY): ")
    
    month, day, year = birthdate.split("/")
    bdate = datetime.datetime(int(year), int(month), int(day))
    todays_date = datetime.datetime.now()
    age = todays_date - bdate
    
    print(f"You are {age.days / 365.25} years old")
    
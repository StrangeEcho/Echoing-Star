import datetime

# Task 2
print("rubtho6330")
birthday = input("what is your birthdate (MM/DD/YYYY): ")

month, date, year = birthday.split("/")

bday = datetime.datetime(int(year), int(month), int(date))
todays_date = datetime.datetime.now()
age = todays_date - bday

print(f"You are {age.days/365.25} years old")
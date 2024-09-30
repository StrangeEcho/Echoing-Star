import random 
list = []
index = 0

print("rubtho6330")

def Numbersort(list):
    return sorted(list)

while index < 1000:
    list.append(random.randint(1,100))
    index += 1

print("Here are the numbers in order")
for num in Numbersort(list):
    print(num)
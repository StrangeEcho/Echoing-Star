import random

list = []

for i in range(1000):
    list.append(random.randint(1, 1000))

print(list)

print(sorted(list))


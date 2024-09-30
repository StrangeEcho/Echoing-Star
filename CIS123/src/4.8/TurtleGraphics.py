import turtle

def studentid(id): 
    turtle.write(id)

def square(size):
    for _ in range(4):
        turtle.forward(size)
        turtle.right(90)

def circle(size):
    turtle.circle(size)

def rectangle(sideA, sideB):
    for _ in range(2):
        turtle.forward(sideA)
        turtle.right(90)
        turtle.forward(sideB)
        turtle.right(90)

studentid("rubtho6330")
square(100)
circle(120)
rectangle(130, 90)

turtle.done()
import turtle

def square(size):
    for _ in range(4):
        turtle.forward(size)
        turtle.right(90)

def circle(size):
    turtle.circle(size)

def rectangle(sideA,sideB):
    for _ in range(2):
        turtle.forward(sideA)
        turtle.right(90)
        turtle.forward(sideB)
        turtle.right(90)
        
def anyshape(sides, direction):
    angle = int(360/sides)
    size = int(900/sides)
    for _ in range(sides):
        turtle.forward(size)
        if direction == "r":
            turtle.right(angle)
        else:
            turtle.left(angle)        

anyshape(6, "r")

turtle.done()


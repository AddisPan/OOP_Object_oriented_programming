
##### Methods #####
import turtle
turtle.speed(500)
def A108222040_drawPolygon(color,angle,numLine,startX,startY,length):
    turtle.penup()
    turtle.goto(startX,startY)
    turtle.setheading(0)
    turtle.pendown()
    turtle.pencolor(color)
    for x in range(numLine):
        turtle.forward(length)
        turtle.right(angle)

def A108222040_drawCircle(color,NUM_CIRCLES,RADIUS,ANGLE,startX,startY):       
    turtle.penup()
    turtle.goto(startX,startY)
    turtle.setheading(0)
    turtle.pendown()
    turtle.pencolor(color)
    for x in range(NUM_CIRCLES):
        turtle.circle(RADIUS)
        turtle.left(ANGLE)

def A108222040_drawStar(color,NUM_LINES,LINE_LENGTH,ANGLE,startX,startY):
    turtle.penup()
    turtle.goto(startX,startY)
    turtle.setheading(0)
    turtle.pendown()
    turtle.pencolor(color)
    for x in range(NUM_LINES):
        turtle.forward(LINE_LENGTH)
        turtle.left(ANGLE)

##### Main Entrace #####        

A108222040_drawCircle(color = 'blue',NUM_CIRCLES = 18,RADIUS = 100,ANGLE = 20,startX = 0,startY = 0)

A108222040_drawCircle(color = 'red',NUM_CIRCLES = 36,RADIUS = 50,ANGLE = 10,startX = 200,startY = -200)

A108222040_drawCircle(color = 'green',NUM_CIRCLES = 72,RADIUS = 50,ANGLE = 5,startX = -200,startY = 200)

A108222040_drawPolygon(color = 'black',angle = 90,numLine = 4,startX = 60,startY = -60,length = 100)

A108222040_drawPolygon(color = 'black',angle = 120,numLine = 3,startX = -60,startY = 100,length = 100)

A108222040_drawPolygon(color = 'gold',angle = 45,numLine = 8,startX = 0,startY = 0,length = 100)

turtle.penup()
turtle.goto(200,200)
turtle.pendown()
turtle.write("A108222040_潘凌徵")

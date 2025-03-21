import turtle
import time
import random

delay = 0.1

#herni okno
wn = turtle.Screen()
wn.title("Moje ošklivá hra")
wn.bgcolor(0, 1, 0.4)#toto nefunguje proč??? -> není takto definovaná funkce při prokliku

#wn.setup(800, 600)
wn.setup(width=800, height=600)
wn.tracer(0)#netusim proc, ale musi to tam byt???


#objekt zelva - objekt se spoustou vlastnosti jako napr. pohyb, tvar atd
snakeHead = turtle.Turtle()
snakeHead.shape("square")
snakeHead.goto(0,0)
snakeHead.penup()
snakeHead.color("black")
snakeHead.speed(0)
snakeHead.direction = "right" #stop, up, down, left, right



food_x = random.randint((int)(-wn.window_width() / 2), (int) (wn.window_width() / 2)) #
food_y = random.randint((int)(-wn.window_height() / 2), (int) (wn.window_height() / 2))
#objekt pro jídlo (jablko?)
food = turtle.Turtle()
food.shape("circle")
food.penup()
food.goto(food_x,food_y)
food.color("red")
food.speed(0)

#snakeHead.direction = "stop"

def move():
    if snakeHead.direction == "up": #když je směr nastavneý na up
        y = snakeHead.ycor() #zjistí se y souřadnice
        snakeHead.sety(y + 20) #změní se na stejnou hodnotu + 20 (20 proto, že je to defaultní velikost shape, tzn. posouváme celý shape)
    if snakeHead.direction == "down":
        y = snakeHead.ycor()
        snakeHead.sety(y - 20)
    if snakeHead.direction == "right":
        x = snakeHead.xcor()
        snakeHead.setx(x + 20)
    if snakeHead.direction == "left":
        x = snakeHead.xcor()
        snakeHead.setx(x - 20)

def up():
    snakeHead.direction = "up"

def down():
    snakeHead.direction = "down"

def right():
    snakeHead.direction = "right"

def left():
    snakeHead.direction = "left"

wn.listen()
wn.onkeypress(up, "w") 
wn.onkeypress(down, "s") 
wn.onkeypress(left, "a") 
wn.onkeypress(right, "d") 


#hlavni smycka, kterou nakonec nevyuzijeme, ale nyni ji potrebujeme, aby se nam okno nezavrelo
#wn.mainloop()
while True:
    move()
    wn.update() #prekresleni pixelu obrazovky
    time.sleep(delay) #zpomalím

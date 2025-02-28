import turtle

def bg(r: float, g: float, b: float):
    print(r, g, b)


#herni okno
wn = turtle.Screen()
wn.title("Moje ošklivá hra")
bg(r = 26, b = 80, g = 2)
#wn.bgcolor(r=0.1, g=0.2, b=1.0)toto nefunguje proč??? -> není takto definovaná funkce při prokliku

#wn.setup(800, 600)
wn.setup(width=900, height=600)
#wn.tracer(0)#netusim proc, ale musi to tam byt???


#objekt zelva - objekt se spoustou vlastnosti jako napr. pohyb, tvar atd
snakeHead = turtle.Turtle()
snakeHead.shape("turtle")
snakeHead.goto(0,0)
snakeHead.shapesize(5,5,0)

#snakeHead.color("black")
#snakeHead.direction = "stop"
#snakeHead.speed(0)

#prekresleni pixelu obrazovky
wn.update()

#hlavni smycka, kterou nakonec nevyuzijeme, ale nyni ji potrebujeme, aby se nam okno nezavrelo
wn.mainloop()






#wn = turtle.Screen()
#wn.title("Snake Game")
#wn.bgcolor("green")
#wn.setup(width=600, height=600)
#wn.tracer(0) # Turns off the screen updates


'''head = turtle.Turtle()
head.speed(0)
head.shape("square")
head.color("black")
head.penup()
head.goto(0,0)
head.direction = "stop"'''
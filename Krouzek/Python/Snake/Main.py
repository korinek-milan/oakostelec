import turtle
import time
import random
import sys

delay = 0.1
running = True

segments = [] #vytvoříme tzv. pole, do kterého budeme přidávat nové segmenty, těmto segmentům pak budeme měnit pozici při každém pohybu

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

def moveSegments():
    for index in range(len(segments) - 1, 0, -1): #např. pro pro počet semgnetů 10 se vytvoří cyklus v rozsahu od 9 do 1, pro nultý index se nevykoná, proto musíme posunout nutlý segment na pozici hlavy po skončení cyklu
        new_x = segments[index-1].xcor() #zjistíme pozici segmentu, který je před aktuální segmentem (o 1 menší)
        new_y = segments[index-1].ycor()
        
        segments[index].goto(new_x, new_y) #nastaví pozici aktuální segmentu na získanou pozici segmentu předchozího


    if(len(segments) > 0):
        head_x = snakeHead.xcor()
        head_y = snakeHead.ycor()
        segments[0].goto(head_x, head_y) #posunutí prvního segmentu (na 0. indexu) na pozici hlavy




def up():
    snakeHead.direction = "up"

def down():
    snakeHead.direction = "down"

def right():
    snakeHead.direction = "right"

def left():
    snakeHead.direction = "left"

def onEscPressed():
    global running  #říkám metodě, že chci použít proměnnou s názvem running z globálního prostoru
    running = False #pracuji s globální proměnnou, mohu ji nastavit

#pokud je jídlo detekováno hlavou, jídlo přesuň na novou náhodnou pozici
def detectFood():
    #pokud je x souřadnice hlavy shodná se souřadnicí x jídla a zároveň to stejné pro y, pak vygeneruj náhodné hodnoty a jídlo na tyto souřadnice přesuň
    #pozor na to, toto nebude fungovat, protože se ptáme přesně na konkrétní jeden pixel x,y...ale naše hlava a jídlo je větší, takže vizulně to vypadá, že se dotkli, ale ne přesně
    if snakeHead.distance(food) < 20:
        food_x = random.randint((int)(-wn.window_width() / 2) + 50, (int) (wn.window_width() / 2) - 50) #pomocí -50 a + 50 zmenším hranice, tudíž nebude z půlky za hranicí
        food_y = random.randint((int)(-wn.window_height() / 2) + 50, (int) (wn.window_height() / 2) - 50) #pomocí -50 a + 50 zmenším hranice, tudíž nebude z půlky za hranicí
        
        i = 0
        while (i < (len(segments))-1):
            if(segments[i].distance(food_x, food_y) < 20):
                food_x = random.randint((int)(-wn.window_width() / 2) + 50, (int) (wn.window_width() / 2) - 50) #pomocí -50 a + 50 zmenším hranice, tudíž nebude z půlky za hranicí
                food_y = random.randint((int)(-wn.window_height() / 2) + 50, (int) (wn.window_height() / 2) - 50) #pomocí -50 a + 50 zmenším hranice, tudíž nebude z půlky za hranicí
                print("Position regenerated...")
                i = 0
            i = i +1
            

        food.goto(food_x,food_y)

        segment = turtle.Turtle()
        segment.shape("square")
        segment.goto(0,0)
        segment.penup()
        segment.color("gray")
        segment.speed(0)

        segments.append(segment)




wn.listen()
wn.onkeypress(up, "w") 
wn.onkeypress(down, "s") 
wn.onkeypress(left, "a") 
wn.onkeypress(right, "d") 
wn.onkeypress(onEscPressed, "Escape")


#hlavni smycka, kterou nakonec nevyuzijeme, ale nyni ji potrebujeme, aby se nam okno nezavrelo
#wn.mainloop()
#abych mohl klávesou esc ukončit program, přepsal jsem while True na While running

while running:
    moveSegments()
    move()
    detectFood()#potřebuji po každém pohybu zavolat metodu, která kontroluje detekci jídla
    


    wn.update() #prekresleni pixelu obrazovky
    time.sleep(delay) #zpomalím


quit()
# ukončit na escape
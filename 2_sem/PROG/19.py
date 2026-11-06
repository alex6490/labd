import turtle
import random
import math

# ---------------- ХОЛСТ ----------------
window = turtle.Screen()
window.title("ТРИГОНОМЕТРИЯ")
window.bgcolor("white")
window.setup(900, 600)

# ---------------- КНОПКА ----------------
button = turtle.Turtle()
button.hideturtle()
button.pensize(3)

# Рисование кнопки
button.penup()
button.goto(-60, 220)
button.pendown()

button.fillcolor("lightblue")
button.begin_fill()

for i in range(2):
    button.forward(120)
    button.right(90)
    button.forward(40)
    button.right(90)

button.end_fill()

button.penup()
button.goto(-25, 195)

button.write(
    "НАЖМИ",
    font=("Arial", 14, "bold")
)

# ---------------- ЧЕРЕПАХА ДЛЯ РИСОВАНИЯ ----------------
t = turtle.Turtle()
t.speed(0)
t.pensize(3)

# ---------------- ЧЕРЕПАХА ДЛЯ ТЕКСТА ----------------
text = turtle.Turtle()
text.hideturtle()
text.penup()

# ---------------- ФУНКЦИЯ ОБРАБОТКИ ----------------
def button_click(x, y):

    # Проверка попадания по кнопке
    if -60 < x < 60 and 180 < y < 220:

        # Очистка старого рисунка
        t.clear()
        text.clear()

        # Случайные катеты
        a = random.randint(10, 100)
        b = random.randint(10, 100)

        # Гипотенуза
        c = math.sqrt(a**2 + b**2)

        # Тригонометрия
        sin_a = a / c
        cos_a = b / c
        tan_a = a / b
        cot_a = b / a

        # Масштаб
        scale = 3

        # Координаты начала
        start_x = -300
        start_y = -150

        # ---------------- РИСОВАНИЕ ТРЕУГОЛЬНИКА ----------------
        t.penup()
        t.goto(start_x, start_y)
        t.pendown()

        # Нижний катет
        t.forward(b * scale)

        # Гипотенуза
        t.goto(start_x, start_y + a * scale)

        # Вертикальный катет
        t.goto(start_x, start_y)

        # ---------------- ПОДПИСИ ----------------
        text.goto(100, 100)

        text.write(
            f"Катет a = {a}\n"
            f"Катет b = {b}\n\n"
            f"sin α = {sin_a:.3f}\n"
            f"cos α = {cos_a:.3f}\n"
            f"tg α = {tan_a:.3f}\n"
            f"ctg α = {cot_a:.3f}",
            font=("Arial", 16, "normal")
        )

# ---------------- ОБРАБОТКА СОБЫТИЯ ----------------
turtle.listen()
turtle.onscreenclick(button_click, 1)

# ---------------- ЗАПУСК ----------------
turtle.done()
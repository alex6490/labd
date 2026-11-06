# Вариант 2:
# Пользователь сам выбирает область кликом мыши.
# В месте клика рисуется прямоугольный треугольник
# со случайными катетами.

import turtle
import random
import math

# ---------------- ХОЛСТ ----------------
window = turtle.Screen()
window.title("ТРИГОНОМЕТРИЯ - КЛИК ПО ОБЛАСТИ")
window.bgcolor("white")
window.setup(1000, 700)

# ---------------- ЧЕРЕПАХА ДЛЯ РИСОВАНИЯ ----------------
t = turtle.Turtle()
t.speed(0)
t.pensize(3)

# ---------------- ЧЕРЕПАХА ДЛЯ ТЕКСТА ----------------
text = turtle.Turtle()
text.hideturtle()
text.penup()

# ---------------- ИНСТРУКЦИЯ ----------------
info = turtle.Turtle()
info.hideturtle()
info.penup()

info.goto(-250, 300)

info.write(
    "Кликните мышью в любое место окна",
    font=("Arial", 18, "bold")
)

# ---------------- ФУНКЦИЯ ОБРАБОТКИ ----------------
def draw_triangle(x, y):

    # Очистка прошлого рисунка
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
    scale = 2

    # ---------------- РИСОВАНИЕ ----------------
    t.penup()
    t.goto(x, y)
    t.pendown()

    # Нижний катет
    t.goto(x + b * scale, y)

    # Гипотенуза
    t.goto(x, y + a * scale)

    # Вертикальный катет
    t.goto(x, y)

    # ---------------- ВЫВОД ТЕКСТА ----------------
    text.goto(-450, 200)

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
turtle.onscreenclick(draw_triangle, 1)

# ---------------- ЗАПУСК ----------------
turtle.done()
#Программа lab6_3
#Лабораторная работа по теме табулирование функций с использованием цикла for
#Вычисление значений функции
#Программист: Фомин А.С.
#Проверил:
#Дата написания: 18.11.2025 г.
#Переменные:
        #x - вводимые данные
        #y - вычисляемые значения функции
from math import trunc

x0 = float(input('Enter x0: '))
hx = float(input('Enter hx: '))
xn = float(input('Enter xn: '))
Nx = trunc(((xn - x0)/hx) + 1e-6) + 1
#echo-print
print('x0=', x0)
print('hx=', hx)
print('xn=', xn)
print('Nx = ', Nx)
x = x0
S = 0
P = 1
for i in range(Nx):
    x = x0+hx*i
    if x <= -2:
        f = 8/x
    elif -2<x<=0:
        f = (x**3)+4
    else :
        f = 4/((x**2)+1)
    S+=f
    P*=f
    print(f'f({x})=', f)
print(f'S = {S}')
print(f'P = {P}')

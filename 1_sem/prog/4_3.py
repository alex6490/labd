#Программа lab4_1
#Лабораторная работа по теме ветвление
#Попадание точки
#Программист: Фомин А.С.
#Проверил:
#Дата написания: 20.10.2025 г.
#Переменные:
            #x,y - вводимые данные
x = float(input('Enter x: '))
y = float(input('Enter y: '))
#echo-print
print('x = ', x)
print('y = ', y)
f1 = x*x-3
f2 = -x*x+5
if y >= f1 and y <= f2:
    print('Точка попадает')
else:
    print('Invalid value')
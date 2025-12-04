#Программа lab7_2
#Лабораторная работа по теме циклы с предусловием
#Вывод первых 15 членов последовательности
#Программист: Фомин А.С.
#Проверил:
#Дата написания: 8.11.2025 г.
#Переменные:
x0 = float(input('Enter x0: '))
hx = float(input('Enter hx: '))
xn = float(input('Enter xn: '))
#echo-print
print('x0=', x0)
print('hx=', hx)
print('xn=', xn)
pos = 0
neg = 0
x = x0
while x <= xn + hx/4:
    f = 3 * x ** 4 + 2 * x ** 3 - 3 * x ** 2 - 3
    if f < 0:
        neg += 1
    else:
        pos += 1
    print(f'f{x}=',f)
    x += hx
print('Положительных значений -', pos)
print('Отрицательных значений -', neg)
if pos > neg:
    print('Положительных больше')
elif pos == neg:
    print('Значений поровну')
else:
    print('Отрицательных больше')


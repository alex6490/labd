#Программа lab8
#Лабораторная работа по теме вложенные циклы
#Нахождение значений функции
#Программист: Фомин А.С.
#Проверил:
#Дата написания: 10.12.2025 г.
#Переменные:
x0 = float(input('enter x0: '))
hx = float(input('enter hx: '))
xn = float(input('enter xn: '))
#echo-print
print('x0=', x0)
print('hx=', hx)
print('xn=', xn)
x=x0
while x <= xn + hx/4:
    S = 0
    if x <= 2:
        for n in range(1, 11):
            p = 1
            for k in range(n):
                p = p * (x/n)
            S = S + p
    else:
        for n in range(0,9):
            p = 1
            for k in range(n):
                p = p * x
            S = S + p/(n+2)
    print(f'Z={S:.6f} x={x}')
    x += hx
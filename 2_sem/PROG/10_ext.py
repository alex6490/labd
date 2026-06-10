#Программа lab10_доп
#Дополнительноек задание по теме вложенные массивы (матрицы)
#Написать программу, сортирующую столбец матрицы по убыванию (вариант 24)
#Программист: Фомин А.С.
#Проверил:
            #Щенева Ю.Б.
            #Антонушкина С.Д.
#Дата написания: 25.02.2026 г.
#Переменные:
            #N - количество строк матрицы
            #M - количество столбцов матрицы
            #matrix - исходная матрица
            #row - строка матрицы
            #el - элемент матрицы
            #K - номер столбца для сортировки
from random import randint
N = int(input('Введите количество строк матрицы'))
M = int(input('Введите количество столбцов матрицы'))
matrix = []
for i in range(N):
    row = []
    for j in range(M):
        el = randint(-10, 10) 
        row.append(el)
    matrix.append(row)
for row in matrix:
    for el in row:
        print(f'{el:4}', end='')
    print()
K = int(input('Введите номер столбца для сортировки'))
if K > M-1:
    print('Номер столбца должен быть меньше количества столбцов в матрице')
else:
    for i in range(N-1):
            for j in range(N-1-i):
                if matrix[j][K] < matrix[j+1][K]:
                    matrix[j][K], matrix[j+1][K] = matrix[j+1][K], matrix[j][K]
    print('Отсортированная матрица:')
    for row in matrix:
        for el in row:
            print(f'{el:4}', end='')
        print()

        
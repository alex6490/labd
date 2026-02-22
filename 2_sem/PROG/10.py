#Программа lab10
#Лабораторная работа по теме вложенные массивы (матрицы)
#Найти элементы, которые снизу, сверху, справа и слева «окружены»  меньшими значениями. (вариант 24)
#Программист: Фомин А.С.
#Проверил:
            #Щенева Ю.Б.
            #Антонушкина С.Д.
#Дата написания: 14.02.2026 г.
#Переменные:
            #i - количество строк матрицы
            #j - количество столбцов матрицы
            #matrix - исходная матрица
            #row - строка матрицы
            #n, m - индексы элемента матрицы
            #smaller - элемент "окруженный" меньшими
from random import *
i = int(input('Введите количество строк матрицы '))
j = int(input('Введите количество столбцов матрицы '))
matrix = []
for a in range(i):
    row = []
    for b in range(j):
        row.append(randint(-10, 10))
    matrix.append(row)
for row in matrix:
    for el in row:
        print(f'{el:4}', end='')
    print()
smaller = []
for n in range(1, i-1):
    for m in range(1, j-1):
        if matrix[n][m] > matrix[n-1][m] and matrix[n][m] > matrix[n+1][m] and matrix[n][m] > matrix[n][m-1] and matrix[n][m] > matrix[n][m+1]:
            smaller.append(matrix[n][m])
print('Элементы, окружённые меньшими значениями:', smaller)
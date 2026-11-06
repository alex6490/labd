#Лабораторная работа lab_14
#Множества и подпрограммы
#Сумма элементов квадратной матрицы выше главной диагонали
#Программист: Фомин А.С.
#Проверили:
            #Антонушкина С.Д.
            #Щенева Ю.Б.
#Переменные:
            #n - размерность квадратной матрицы
            #a - полученная сгенерированная матрица
            #arr - одномерный массив, содержащий элементы выше главной диагонали
            #s - сумма элементов, содержащихся в arr
import random

# Генерация матрицы
def matrix_gen(n: int) -> list[list[int]]:
    a: list[list[int]] = []
    for i in range(n):
        row: list[int] = []
        for j in range(n):
            row.append(random.randint(-10, 10))
        a.append(row)
    return a


# Вывод матрицы
def matrix_pr(a: list[list[int]]) -> None:
    for row in a:
        for el in row:
            print(el, end='\t')
        print()


# Получение элементов выше диагонали (ОДНОМЕРНЫЙ массив)
def get_upper(a: list[list[int]], n: int) -> list[int]:
    arr: list[int] = []
    for i in range(n):
        for j in range(i + 1, n):
            arr.append(a[i][j])
    return arr


# Обработка одномерного массива (сумма)
def arr_sum(arr: list[int]) -> int:
    s: int = 0
    for el in arr:
        s += el
    return s


# Главная программа
def main() -> None:
    n: int = int(input("Введите размер матрицы: "))

    a: list[list[int]] = matrix_gen(n)

    print("\nМатрица:")
    matrix_pr(a)

    arr: list[int] = get_upper(a, n)
    print("\nЭлементы выше диагонали:", arr)

    s: int = arr_sum(arr)
    print("Сумма элементов:", s)


main()
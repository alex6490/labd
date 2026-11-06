#Лабораторная работа lab_16_2
#Бинарные файлы
#Сформировать текстовый файл Data.txt из заглавных букв A, B, C, D латинского алфавита. Найти номер строки, содержащей самую длинную цепочку вида ABDABDABD...
#Программист: Фомин А.С.
#Дата написания: 29.04.2026 г.
#Проверили:
            #Антонушкина С.Д.
            #Щенева Ю.Б.
#Переменные:
            #lines - список строк из файла
            #pattern - шаблон для поиска
            #best_line_index - индекс строки с самой длинной цепочкой
            #best_length - длина самой длинной цепочки
            #s - текущая строка
            #max_len - максимальная длина цепочки в текущей строке
            #start - начальная позиция для проверки цепочки
            #j - текущая позиция в строке
            #k - текущая позиция в шаблоне
            #result_line - строка с самой длинной цепочкой
            #freq - словарь для подсчёта частот букв
import random


# ---------- Подпрограмма создания файла ----------
def create_file():

    try:

        n = int(input("Количество строк: "))

        alphabet = "ABCD"

        f = open("Data.txt", "w")

        for i in range(n):

            length = random.randint(10, 100)

            s = ""

            for j in range(length):

                s += random.choice(alphabet)

            f.write(s + "\n")

        f.close()

        result = open("Result.txt", "w")

        result.write("Файл Data.txt успешно создан")

        result.close()

        print("Файл создан")

    except ValueError:

        print("Ошибка ввода данных")

    except Exception as e:

        print("Ошибка:", e)


# ---------- Подпрограмма обработки файла ----------
def process_file():

    try:

        f = open("Data.txt", "r")

        lines = []

        for line in f:

            lines.append(line.strip())

        f.close()

        pattern = "ABD"

        best_line_index = -1

        best_length = -1

        # Поиск максимальной цепочки
        for i in range(len(lines)):

            s = lines[i]

            max_len = 0

            for start in range(len(s)):

                j = start

                k = 0

                while j < len(s) and s[j] == pattern[k % 3]:

                    j += 1

                    k += 1

                if k > max_len:

                    max_len = k

            if max_len > best_length:

                best_length = max_len

                best_line_index = i

        result_line = lines[best_line_index]

        # Подсчёт частот
        freq = {}

        for ch in result_line:

            if ch in freq:

                freq[ch] += 1

            else:

                freq[ch] = 1

        # Запись результата
        result = open("Result.txt", "w")

        result.write("Номер строки: " +
                     str(best_line_index + 1) + "\n")

        result.write("Строка:\n")

        result.write(result_line + "\n\n")

        result.write("Частоты букв:\n")

        for ch in sorted(freq):

            result.write(ch + " : " +
                         str(freq[ch]) + "\n")

        result.close()

        print("Результат записан в Result.txt")

    except FileNotFoundError:

        print("Файл Data.txt не найден")

    except Exception as e:

        print("Ошибка:", e)


# ---------- Главное меню ----------
print("1 - Создать файл")
print("2 - Обработать файл")

mode = input("Выберите режим: ")

if mode == "1":

    create_file()

elif mode == "2":

    process_file()

else:

    print("Неверный режим")

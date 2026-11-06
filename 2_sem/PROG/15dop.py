#Лабораторная работа lab15_dop
#Строки + подпрограммы
#Язык племени Тумба-Юмба
#Программист:
            # Фомин А.С.
#Проверили:
            #Антонушкина С.Д.
            #Щенева Ю.Б.
#Дата написания: 26.04.2026 г.
#Переменные:
            #alphabet - алфавит
            #k - длина слов
            #current - текущее слово
            #total - общее количество слов с соседними одинаковыми буквами
def has_same_neighbors(word):
    for i in range(len(word) - 1):
        if word[i] == word[i + 1]:
            return True
    return False
def generate_words(alphabet, k, current):
    if len(current) == k:
        if has_same_neighbors(current):
            print(current)
            return 1
        return 0
    count = 0
    i = 0
    while i < len(alphabet):
        letter = alphabet[i]
        count += generate_words(alphabet, k, current + letter)
        i += 1
    return count
alphabet = input('Введите алфавит языка: ')
k = int(input('Введите длину: '))
total = generate_words(alphabet, k, "")
print(total)
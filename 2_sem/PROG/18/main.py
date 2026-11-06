import string_package as sp


DATA_FILE = "Data.txt"
RESULT_FILE = "Result.txt"


def menu():
    """
    Меню программы.
    """
    print("\n===== МЕНЮ =====")
    print("1 - Ввести строки в файл Data.txt")
    print("2 - Обработать файл Data.txt")
    print("0 - Выход")


def create_file():
    """
    Создание файла Data.txt.
    """
    try:
        n = int(input("Введите количество строк: "))

        with open(DATA_FILE, "w", encoding="utf-8") as file:

            for i in range(n):
                line = input(f"Введите строку {i + 1}: ")
                file.write(line + "\n")

        print("Файл Data.txt успешно создан.")

    except ValueError:
        print("Ошибка: количество строк должно быть числом.")

    except Exception as error:
        print(f"Ошибка при создании файла: {error}")


def read_data():
    """
    Чтение данных из файла.
    """
    try:
        with open(DATA_FILE, "r", encoding="utf-8") as file:
            lines = file.readlines()

        return [line.strip() for line in lines]

    except FileNotFoundError:
        print("Ошибка: файл Data.txt не найден.")
        return []

    except Exception as error:
        print(f"Ошибка чтения файла: {error}")
        return []


def write_result(text):
    """
    Запись результата в файл Result.txt.
    """
    try:
        with open(RESULT_FILE, "w", encoding="utf-8") as file:
            file.write(text)

        print("Результат записан в Result.txt")

    except Exception as error:
        print(f"Ошибка записи файла: {error}")


def process_file():
    """
    Обработка строк из файла.
    """
    lines = read_data()

    if len(lines) < 2:
        print("В файле должно быть минимум 2 строки.")
        return

    text1 = lines[0]
    text2 = lines[1]

    result = ""

    # 1. Количество слов
    word_count = sp.count_words(text1)

    result += "1. Количество слов в первой строке:\n"
    result += f"{word_count}\n\n"

    # 2. Статистика букв
    stats = sp.letter_statistics(text1)

    result += "2. Статистика встречаемости букв:\n"

    for letter, count in sorted(stats.items()):
        result += f"{letter} : {count}\n"

    result += "\n"

    # 3. Общие слова
    common_words = sp.find_common_words(text1, text2)

    result += "3. Общие слова двух строк:\n"

    if common_words:
        result += ", ".join(common_words)
    else:
        result += "Общих слов нет"

    result += "\n\n"

    # 4. Очистка строки
    cleaned_text = sp.remove_punctuation(text1)

    result += "4. Строка без знаков препинания:\n"
    result += cleaned_text

    write_result(result)


def main():
    """
    Главная функция программы.
    """
    while True:

        menu()

        choice = input("Выберите пункт меню: ")

        if choice == "1":
            create_file()

        elif choice == "2":
            process_file()

        elif choice == "0":
            print("Программа завершена.")
            break

        else:
            print("Неверный пункт меню.")


if __name__ == "__main__":
    main()
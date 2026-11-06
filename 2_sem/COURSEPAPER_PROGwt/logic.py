# =========================================
# Модуль logic.py
# Основная логика программы:
# добавление, удаление, поиск,
# редактирование и определение победителей.
# =========================================
# ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ

def to_float(value):
    #форматирование под вещественное для python
    try:
        value = float(value.replace(",", "."))
    except:
        value = None
    return value


def input_float(prompt):
    while True:
        value = input(prompt)
        num = to_float(value)

        if num is not None:
            return round(num, 2)

        print("Ошибка ввода. Попробуйте еще раз.")


def format_num(x):
    #форматирование до 2 знаков в дробной части
    return round(x, 2)

# CRUD ОПЕРАЦИИ

def add_record(data):
    #добавление данных о спортсмене
    fio = input("ФИО: ").strip()

    if fio == "":
        print("ФИО не может быть пустым.")
        return

    for x in data:
        if fio.lower() == x["fio"].lower():
            print("Такой спортсмен уже существует.")
            return

    record = {
        "fio": fio,
        "100m": input_float("100 м (сек): "),
        "1km": input_float("1 км (сек): "),
        "long_jump": input_float("Прыжок в длину (м): "),
        "high_jump": input_float("Прыжок в высоту (м): ")
    }

    data.append(record)
    print("Запись добавлена.")


def show_data(data):
    #показать БД
    if len(data) == 0:
        print("База данных пуста.")
        return

    number = 1

    for x in data:
        print(
            str(number) + ". " +
            x["fio"] + " | " +
            "100 м: " + str(format_num(x["100m"])) + " сек | " +
            "1 км: " + str(format_num(x["1km"])) + " сек | " +
            "Длина: " + str(format_num(x["long_jump"])) + " м | " +
            "Высота: " + str(format_num(x["high_jump"])) + " м"
        )

        number += 1


def delete_record(data):
    #удалить данные записи
    name = input("Введите ФИО для удаления: ").strip()

    if name == "":
        print("ФИО не введено. Возврат в главное меню.")
        return data

    new_data = []

    for x in data:
        if name.lower() != x["fio"].lower():
            new_data.append(x)

    if len(new_data) == len(data):
        print("Такое ФИО не найдено.")
        return data

    print("Запись удалена.")
    return new_data


def find_records(data):
    #найти запись
    name = input("Введите ФИО для поиска: ").strip().lower()

    if name == "":
        print("ФИО не введено.")
        return []

    results = []

    for x in data:
        if name in x["fio"].lower():
            results.append(x)

    if len(results) == 0:
        print("Ничего не найдено.")

    return results


def edit_record(data):
    #изменить запись
    while True:
        name = input("Введите ФИО для редактирования: ").strip()

        if name == "":
            print("ФИО не может быть пустым. Повторите ввод.")
            continue

        found = False

        for x in data:
            if name.lower() == x["fio"].lower():
                found = True

                print("Введите новые результаты (Enter = оставить без изменений)\n")

                value = input(
                    "100 м (сек) [" + str(format_num(x["100m"])) + "]: "
                )
                if value != "":
                    num = to_float(value)
                    if num is not None:
                        x["100m"] = round(num, 2)

                value = input(
                    "1 км (сек) [" + str(format_num(x["1km"])) + "]: "
                )
                if value != "":
                    num = to_float(value)
                    if num is not None:
                        x["1km"] = round(num, 2)

                value = input(
                    "Прыжок в длину (м) [" + str(format_num(x["long_jump"])) + "]: "
                )
                if value != "":
                    num = to_float(value)
                    if num is not None:
                        x["long_jump"] = round(num, 2)

                value = input(
                    "Прыжок в высоту (м) [" + str(format_num(x["high_jump"])) + "]: "
                )
                if value != "":
                    num = to_float(value)
                    if num is not None:
                        x["high_jump"] = round(num, 2)

                print("Запись обновлена.")
                return

        if not found:
            print("Такое ФИО не найдено. Повторите ввод.")

# ПОИСК ПОБЕДИТЕЛЕЙ

def print_winners(data):
    #вывод победителей
    if len(data) == 0:
        print("Нет данных.")
        return

    best_100 = data[0]
    best_1km = data[0]
    best_long = data[0]
    best_high = data[0]

    for x in data:
        if x["100m"] < best_100["100m"]:
            best_100 = x

        if x["1km"] < best_1km["1km"]:
            best_1km = x

        if x["long_jump"] > best_long["long_jump"]:
            best_long = x

        if x["high_jump"] > best_high["high_jump"]:
            best_high = x

    print("\nПобедители:\n")

    print(
        "100 м - " +
        best_100["fio"] + ", " +
        str(format_num(best_100["100m"])) + " сек"
    )

    print(
        "1 км - " +
        best_1km["fio"] + ", " +
        str(format_num(best_1km["1km"])) + " сек"
    )

    print(
        "Прыжок в длину - " +
        best_long["fio"] + ", " +
        str(format_num(best_long["long_jump"])) + " м"
    )

    print(
        "Прыжок в высоту - " +
        best_high["fio"] + ", " +
        str(format_num(best_high["high_jump"])) + " м"
    )
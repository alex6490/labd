# =========================================
# Модуль main.py
# Основной модуль программы.
# Выполняет запуск программы,
# вывод меню и вызов всех функций.
# =========================================
import db
import logic
import ui


def main():
    #главное меню (выбор действий)
    data = db.load_data()

    ui.print_header()
    ext = False
    while ext == False:
        choice = ui.menu()

        if choice == "1":
            ui.print_table(data)

        elif choice == "2":
            logic.add_record(data)

        elif choice == "3":
            ui.print_table(data)
            logic.edit_record(data)

        elif choice == "4":
            ui.print_table(data)
            data = logic.delete_record(data)

        elif choice == "5":
            result = logic.find_records(data)
            ui.print_table(result)

        elif choice == "6":
            logic.print_winners(data)

        elif choice == "7":
            db.save_data(data)
            print("Данные сохранены. Выход.")
            ext = True

        else:
            print("Ошибка ввода")


main()
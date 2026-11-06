from tkinter import *
from tkinter import ttk, messagebox, filedialog
import tempfile
import os

# ---------------- ОСНОВНОЕ ОКНО ----------------

root = Tk()
root.title("Расчет стоимости проезда")
root.geometry("750x500")

# ---------------- ВРЕМЕННЫЙ ФАЙЛ ----------------

temp_dir = tempfile.gettempdir()
history_file = os.path.join(temp_dir, "history.txt")

# ---------------- ФУНКЦИИ ----------------

def calculate():
    try:
        people = int(entry_people.get())
        distance = float(entry_distance.get())

        if people <= 0 or distance <= 0:
            raise ValueError

        transport = transport_var.get()

        # Ставки за 1 км
        if transport == "Автобус":
            rate = 5
        elif transport == "Поезд":
            rate = 8
        elif transport == "Самолет":
            rate = 15
        else:
            messagebox.showinfo("Ошибка", "Выберите транспорт")
            return

        comfort = comfort_var.get()

        # Коэффициенты комфорта
        if comfort == "Обычный":
            coef = 1
        elif comfort == "2 класс":
            coef = 1.1
        elif comfort == "1 класс":
            coef = 1.3
        else:
            coef = 1

        total = people * distance * rate * coef

        label_result.config(
            text="Стоимость: {:.2f} руб.".format(total)
        )

        # Запись в историю
        text = (
            "Людей: " + str(people) +
            ", Расстояние: " + str(distance) +
            ", Транспорт: " + transport +
            ", Комфорт: " + comfort +
            ", Стоимость: {:.2f}".format(total) + "\n"
        )

        file = open(history_file, "a", encoding="utf-8")
        file.write(text)
        file.close()

        

    except ValueError:
        messagebox.showerror(
            "Ошибка",
            "Некорректный ввод данных"
        )

    except Exception:
        messagebox.showerror(
            "Ошибка",
            "Ошибка при вычислении"
        )


def clear_fields():
    entry_people.delete(0, END)
    entry_distance.delete(0, END)
    label_result.config(text="Стоимость: ")
    transport_var.set("")
    comfort_var.set("Обычный")


def open_history():
    try:
        if not os.path.exists(history_file):
            messagebox.showinfo(
                "История",
                "Нет истории вычислений"
            )
            return

        file = open(history_file, "r", encoding="utf-8")
        data = file.read()
        file.close()

        text_history.delete(1.0, END)
        text_history.insert(END, data)

        # Переключение на вкладку истории
        notebook.select(frame2)

    except Exception:
        messagebox.showerror(
            "Ошибка",
            "Ошибка открытия файла истории"
        )


def exit_program():
    answer = messagebox.askyesno(
        "Подтверждение выхода",
        "Вы действительно хотите закрыть программу?"
    )

    if answer:
        root.destroy()


def about_program():
    messagebox.showinfo(
        "О программе",
        "Программа вычисляет стоимость проезда\n"
        "в зависимости от транспорта,\n"
        "комфортабельности и расстояния."
    )


def about_author():
    author = Toplevel(root)
    author.title("Об авторе")
    author.geometry("300x350")

    # Загрузка PNG изображения
    photo = PhotoImage(file="author.png")

    # Сохраняем ссылку
    author.photo = photo

    # Вывод картинки
    label_img = Label(author, image=photo)
    label_img.pack(pady=10)

    # Текст
    Label(
        author,
        text="Автор программы",
        font=("Arial", 12)
    ).pack(pady=10)


def clear_history_text():
    answer = messagebox.askyesno(
        "Очистка",
        "Очистить текст?"
    )

    if answer:
        text_history.delete(1.0, END)


def show_history():
    open_history()


# ---------------- МЕНЮ ----------------

main_menu = Menu(root)

file_menu = Menu(main_menu, tearoff=0)
file_menu.add_command(label="Открыть", command=open_history)
file_menu.add_separator()
file_menu.add_command(label="Выход", command=exit_program)

main_menu.add_cascade(label="Файл", menu=file_menu)

help_menu = Menu(main_menu, tearoff=0)
help_menu.add_command(label="О программе", command=about_program)
help_menu.add_command(label="Об авторе", command=about_author)

main_menu.add_cascade(label="Справка", menu=help_menu)

root.config(menu=main_menu)

# ---------------- ВКЛАДКИ ----------------

notebook = ttk.Notebook(root)

frame1 = Frame(notebook)
frame2 = Frame(notebook)

notebook.add(frame1, text="Расчет")
notebook.add(frame2, text="История")

notebook.pack(expand=1, fill="both")
def on_tab_changed(event):
    current_tab = notebook.index(notebook.select())

    # Если открыта вкладка "История"
    if current_tab == 1:
        open_history()

notebook.bind("<<NotebookTabChanged>>", on_tab_changed)

# ---------------- ВКЛАДКА 1 ----------------

Label(frame1, text="Количество человек").pack(pady=5)

entry_people = Entry(frame1)
entry_people.pack()

Label(frame1, text="Расстояние (км)").pack(pady=5)

entry_distance = Entry(frame1)
entry_distance.pack()

# ---------------- ТРАНСПОРТ ----------------

transport_var = StringVar()

Label(frame1, text="Выберите транспорт").pack(pady=10)

radio_bus = Radiobutton(
    frame1,
    text="Автобус",
    variable=transport_var,
    value="Автобус"
)

radio_train = Radiobutton(
    frame1,
    text="Поезд",
    variable=transport_var,
    value="Поезд"
)

radio_plane = Radiobutton(
    frame1,
    text="Самолет",
    variable=transport_var,
    value="Самолет"
)

radio_bus.pack()
radio_train.pack()
radio_plane.pack()

# ---------------- КОМФОРТ ----------------

comfort_var = StringVar()
comfort_var.set("Обычный")

Label(frame1, text="Комфортабельность").pack(pady=10)

combo = ttk.Combobox(
    frame1,
    textvariable=comfort_var,
    state="readonly"
)

combo["values"] = (
    "Обычный",
    "2 класс",
    "1 класс"
)

combo.pack()

# ---------------- КНОПКИ ----------------

button_frame = Frame(frame1)
button_frame.pack(pady=15)

btn_calc = Button(
    button_frame,
    text="Рассчитать",
    command=calculate
)

btn_clear = Button(
    button_frame,
    text="Очистить",
    command=clear_fields
)

btn_calc.grid(row=0, column=0, padx=10)
btn_clear.grid(row=0, column=1, padx=10)

# ---------------- РЕЗУЛЬТАТ ----------------

label_result = Label(
    frame1,
    text="Стоимость: ",
    font=("Arial", 12)
)

label_result.pack(pady=10)

# ---------------- ЛОГИКА АКТИВНОСТИ ----------------

def check_transport():
    if transport_var.get() == "Самолет":
        combo.config(state="disabled")
        comfort_var.set("Обычный")
    else:
        combo.config(state="readonly")

radio_bus.config(command=check_transport)
radio_train.config(command=check_transport)
radio_plane.config(command=check_transport)

# ---------------- ВКЛАДКА 2 ----------------

text_history = Text(frame2, wrap=WORD)
text_history.pack(expand=1, fill="both", padx=10, pady=10)

# ---------------- КОНТЕКСТНОЕ МЕНЮ ----------------

context_menu = Menu(root, tearoff=0)

context_menu.add_command(
    label="Очистить",
    command=clear_history_text
)

context_menu.add_command(
    label="Показать историю",
    command=show_history
)

def show_context_menu(event):
    context_menu.post(event.x_root, event.y_root)

text_history.bind("<Button-3>", show_context_menu)

# ---------------- ПОДТВЕРЖДЕНИЕ ЗАКРЫТИЯ ----------------

root.protocol("WM_DELETE_WINDOW", exit_program)

# ---------------- ЗАПУСК ----------------

root.mainloop()
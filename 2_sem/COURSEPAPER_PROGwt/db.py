# =========================================
# Модуль db.py
# Модуль для работы с CSV-файлом:
# загрузка и сохранение базы данных.
# =========================================
import csv
import os

FILE_NAME = "data.csv"


def load_data():
    #загрузка данных из БД
    data = []
    try:
        with open(FILE_NAME, encoding="utf-8", newline="") as file:
            reader = csv.reader(file)
            next(reader)
            for row in reader:
                record = {
                    "fio": row[0],
                    "100m": float(row[1]),
                    "1km": float(row[2]),
                    "long_jump": float(row[3]),
                    "high_jump": float(row[4])
                }

                data.append(record)
    except FileNotFoundError:
        print("Файл не найден. Будет создан новый.")


    return data


def save_data(data):
    #сохрание данных
    with open(FILE_NAME, "w", encoding="utf-8", newline="") as file:
        writer = csv.writer(file)

        writer.writerow([
            "fio",
            "100m",
            "1km",
            "long_jump",
            "high_jump"
        ])

        for row in data:
            writer.writerow([
                row["fio"],
                row["100m"],
                row["1km"],
                row["long_jump"],
                row["high_jump"]
            ])
def letter_statistics(text):
    """
    Статистика встречаемости букв.
    """
    statistics = {}

    for symbol in text.lower():

        if symbol.isalpha():

            if symbol in statistics:
                statistics[symbol] += 1

            else:
                statistics[symbol] = 1

    return statistics


def main():
    test = "Hello World"

    print(letter_statistics(test))


if __name__ == "__main__":
    main()
def count_words(text):
    """
    Подсчет количества слов.
    """
    words = text.split()

    return len(words)


def main():
    test = "Python is great"

    print(count_words(test))


if __name__ == "__main__":
    main()
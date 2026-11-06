def find_common_words(text1, text2):
    """
    Поиск общих слов двух строк.
    """
    words1 = set(text1.lower().split())
    words2 = set(text2.lower().split())

    common = words1.intersection(words2)

    return list(common)


def main():
    s1 = "Python is powerful"
    s2 = "Python is easy"

    print(find_common_words(s1, s2))


if __name__ == "__main__":
    main()
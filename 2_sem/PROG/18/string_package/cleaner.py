import string


def remove_punctuation(text):
    """
    Удаление знаков препинания.
    """
    result = ""

    for symbol in text:

        if symbol not in string.punctuation:
            result += symbol

    return result


def main():
    test = "Hello, world!"

    print(remove_punctuation(test))


if __name__ == "__main__":
    main()
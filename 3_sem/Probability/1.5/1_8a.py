from itertools import product
n = 10
k = 5
# Вычисление количества вариантов:
print(len(list(product(range(n), repeat=k))))
# Проверка результата
print(int(n**k))
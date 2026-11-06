from itertools import permutations
from scipy.special import factorial
n = 11
k = 5
# Все варианты расписания из 5 разных дисциплин
ways = list(permutations(range(n), k))
print("itertools:", len(ways))
# Проверка через scipy
result = factorial(n) / factorial(n - k)
print("scipy:", result)
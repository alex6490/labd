from itertools import permutations
from scipy.special import factorial
n = 7
# Все возможные порядки выступления
ways = list(permutations(range(n)))
print("itertools:", len(ways))
# Проверка через scipy
print("scipy:", factorial(n))
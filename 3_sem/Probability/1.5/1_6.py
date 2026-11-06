from itertools import combinations
from scipy.special import comb
n = 16
# Все пары участников
ways = list(combinations(range(n), 2))
print("itertools:", len(ways))
# Проверка через scipy
print("scipy:", comb(n, 2))
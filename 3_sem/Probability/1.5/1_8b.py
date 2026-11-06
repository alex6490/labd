from itertools import combinations_with_replacement
from scipy.special import comb
n = 10
k = 5
# 1 способ — itertools
ways_1 = list(combinations_with_replacement(range(n), k))
print("itertools:", len(ways_1))
# 2 способ — scipy
ways_2 = comb(n + k - 1, k)
print("scipy:", int(ways_2))
from itertools import permutations
from scipy.special import factorial
digits = [4, 4, 4, 5, 5, 6, 6]
ways = set(permutations(digits))
print("itertools:", len(ways))
n = 7
n4 = 3
n5 = 2
n6 = 2
ways = factorial(n) / (factorial(n4) * factorial(n5) * factorial(n6))
print("scipy:", int(ways))
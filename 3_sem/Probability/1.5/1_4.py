from itertools import permutations
from scipy.special import factorial
n = 30
#Выбираем 3 человек и назначаем им разные должности
ways = list(permutations(range(n), 3))
print("itertools:", len(ways))
#Проверка через scipy
print("scipy:", factorial(n) / factorial(n - 3))
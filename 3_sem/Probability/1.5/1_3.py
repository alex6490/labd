from itertools import combinations
from scipy.special import comb
#0 — детали 1-го сорта
#1 — детали 2-го сорта
#2 — детали 3-го сорта
details = [0] * 150 + [1] * 120 + [2] * 30
#Все способы выбрать 1 деталь
ways = list(combinations(details, 1))
#Оставляем только 1-й или 2-й сорт
good_ways = [x for x in ways if x[0] in (0, 1)]
print("itertools:", len(good_ways))
#Через scipy:
print("scipy:", comb(150 + 120, 1))
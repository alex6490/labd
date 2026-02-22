from math import *
x = float(input('enter x'))
  #print(exp(709)) - последнее целочисленное значение
  #print(exp(710)) - за областью значений float (max e^x=10^308)
  #exp(x) + sin(x) != 0 x == R
y = ((pow(x, 2) + (x/3)) / (exp(x<=709) + sin(x))) - (1/(2*pi))
print(y)


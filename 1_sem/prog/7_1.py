
x0 = float(input('Enter x0: '))
hx = float(input('Enter hx: '))
xn = float(input('Enter xn: '))
#echo-print
print('x0=', x0)
print('hx=', hx)
print('xn=', xn)
x = x0
S = 0
P = 1
while x <= xn + hx/4:
    if x <= -2:
        f = 8/x
    elif -2<x<=0:
        f = (x**3)+4
    else :
        f = 4/((x**2)+1)
    S += f
    P *= f
    print(f'f({x})=', f)
    x += hx
print(f'S = {S}')
print(f'P = {P}')


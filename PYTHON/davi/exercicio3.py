"""3. Sabe-se que o quilowatt de energia custa um quinto do salário mínimo.
Faça um programa que receba o valor do salário mínimo e a quantidade de
quilowatts gasta por uma residência. Calcule e exiba:
 O valor, em reais, de cada quilowatt
 O valor, em reais, a ser pago por essa residência
 O novo valor a ser pago por essa residência, a partir de um desconto de
15%"""

print("=" * 50)
print("Exercicio 3 - LP - 04/03/2026".center(50))
print("=" * 50)




sm = int(input("Digigte o salário mínimo:"))
qw = int(input("Digite a quantiodade de quilowatts:"))

vq=sm*0.2
vr=vq*qw
nv=vr-(vr*0.15)

print("Valor quilowatt:",vq)
print("Valor a pagar:",vr)
print("Valor a pagar com desconto:",nv)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

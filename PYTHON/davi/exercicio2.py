"""2. Faça um programa para efetuar a venda de um determinado produto. Este
programa deve receber o nome do produto, a quantidade vendida e o valor
unitário. Calcular e exibir:
 O valor total a pagar
 O valor total a pagar com desconto de 15%
 Comissão do vendedor – 5% do valor total a pagar"""

print("=" * 50)
print("Exercicio 2 - LP - 04/03/2026".center(50))
print("=" * 50)

nome = input("Digigte seu nome produto:")
qtv = int(input("Digite quantidade vendida do produto:"))
vu = int(input("Digite o valor unitário:"))

vt=vu*qtv
d=vt-(vt*0.15)
c=vt*0.05

print("Total a pagar:",vt)
print("Dpendentes:",d)
print("Comissão:",c)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

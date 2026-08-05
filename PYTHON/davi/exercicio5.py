"""5. Faça um programa que receba que receba o ano de nascimento de uma
pessoa. Calcule e exiba:
 A idade da pessoa
 A idade em dias
 A idade em meses
 A idade em horas
 A idade em minutos"""

print("=" * 50)
print("Exercicio 2 - LP - 04/03/2026".center(50))
print("=" * 50)

a = int(input("Digigte seu ano de nascimento:"))

i=2026-a
d=i*365
m=i*12
h=d*24
mi=h*60

print("Idade:",i)
print("Idade em dias:",d)
print("Idade em meses:",m)
print("Idade em horas:",h)
print("Idade em minutos:",mi)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

"""1. Faça um programa que receba o nome, valor da hora trabalhada,
quantidade de hora trabalhada, quantidade de dependentes e valor do
imposto a pagar de um funcionário. Calcular e exibir o salário bruto e o
salário líquido desse funcionário.
Para encontrar o salário bruto e o salário líquido:
 Calcular o salário base: valor da hora trabalhada * quantidade de hora
trabalhada
 Para cada dependente acrescentar 30 reais
 Calcular o salário bruto: salário base + dependentes
 Calcular o salário líquido: salário bruto – valor do imposto"""

print("=" * 50)
print("Exercicio 1 - LP - 04/03/2026".center(50))
print("=" * 50)




nome = input("Digigte seu nome:")
vht = int(input("Digite o valor da hora trabalhada:"))
qht = int(input("Digite a quantidade de hora trabalhada:"))
qd = int(input("Digite a quantidade de dependentes:"))
vi = int(input("Digite o valor do imposto a pagar:"))

sb=vht*qht
vl=qd*30
sbt=sb+vl
sl=sbt-vi

print("Salário Base:",sb)
print("Dpendentes:",vl)
print("Saláripo Bruto:",sbt)
print("Salário Líquido:",sl)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

"""4. Considere a seguinte situação: descontam-se inicialmente 10% do salário
bruto do trabalhador como contribuição à previdência social. Após esse
desconto, há um outro desconto de 5% sobre o valor restante do salário
bruto, a título de um determinado imposto. Faça um programa que leia o
salário bruto de um cidadão e imprima o seu salário líquido."""

print("=" * 50)
print("Exercicio 2 - LP - 04/03/2026".center(50))
print("=" * 50)

s = int(input("Digigte seu salário bruto:"))

sp=s*0.10
s=s-sp
sd=s*0.05
sl=s-sd

print("Valor previdencia social:",sp)
print("Imposto:",sd)
print("Salário Líquido:",sl)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

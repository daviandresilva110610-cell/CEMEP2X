"""1. Sistema Financiamento de Casa
Escreva um programa para aprovar o empréstimo bancário para compra de
uma casa. O programa deve perguntar o valor da casa a comprar, o salário
do interessado e a quantidade de anos a pagar. O valor da prestação
mensal não pode ser superior a 30% do salário. Calcule o valor da
prestação: valor da casa a comprar dividido pelo número de meses a
pagar.
Exiba no final:
 O valor da casa
 O salário do interessado
 O valor da prestação
 Mensagem informando se o empréstimo foi autorizado ou não"""
print("=" * 50)
print("Exercicio 1 - LP - 18/03/2026".center(50))
print("=" * 50)

v = float(input("Digite o valor da casa:"))

s = int(input("Digite o salário do interessado:"))

qa = int(input("Digite a quantidade de anos a pagar:"))

nm=qa*12

vp=v/nm

print("O valor da casa é:",v)
print("O salário do interessado:",s)
print("O valor da prestação:",vp)

if(vp<vp*1,3):
    print("Empréstimo autorizado")
else:
    print("Epréstimo não autorizado")

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

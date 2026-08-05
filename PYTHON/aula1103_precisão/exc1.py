"""Faça um programa que receba o salario de um funcionário.
Calcule e exiba o slario reajustado, de acordo com as seguintes regras:
- Salário até 900, reajuste de 50%
- Salário maiores que 900, reajuste de 30%"""

sl=int(input("Digite o salário o funcionário"))

if sl<=900:
    r=sl*1.50
    print("Salário reajustado é:",r)
else:
    r=sl*1.30
    print("Salário reajustado é:",r)
    
print("Fim do programa")

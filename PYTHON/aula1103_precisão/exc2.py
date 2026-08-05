"""Faça um programa que receba o código correspondente ao cargo de um
funcionário e seu salário atual. O programa deverá exibir no final
o cargo do funcionário, salário reajustado e o percentual de aumento
ao qual este funcionário tem direito, seguindo a tabela:

código             Cargo             Percentual
1                  Escriturário         50%
2                  Secretário           35%
3                  Caixa                20% 
4                  Gerente              5%"""

cd=int(input("Digite o código correspondente ao cargo:"))
if cd<=4:
    sl=int(input("Digite o salário do funcionário:"))

    if cd==1:
        r=sl*1.50
        print("Escrituário com salário reajustado de",r,"com aumento de 50%")
    elif cd==2:
        r=sl*1.35
        print("Secretário com salário reajustado de",r,"com aumento de 35%")
    elif cd==3:
        r=sl*1.20
        print("Caixa com salário reajustado de",r,"com aumento de 20%")
    elif cd==4:
        r=sl*1.05
        print("Gerente com salário reajustado de",r,"com aumento de 5%")
else:
    print("CÓDIGO INVÁLIDO")

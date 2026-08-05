"""4. Sistema cálculo salário
Faça um programa que receba o valor do salário mínimo, o número de
horas trabalhadas, o número de dependentes do funcionário e a quantidade
de horas extras trabalhadas. Calcule o salário a receber do funcionário
seguindo as regras abaixo:
 O valor da hora trabalhada é igual a 1/5 do salário mínimo
 O salário do mês é igual ao número de horas trabalhadas vezes o valor
da hora trabalhada
 Para cada dependente acrescimo de 32 reais
 Para cada hora extra trabalhada o cálculo do valor da hora trabalhada
acrescida de 50%
 O salário bruto é igual ao salário do mês mais os valores dos
dependentes mais os valores das horas extras
 O calculo do valor do imposto de renda retido na fonte segue a tabela
abaixo:
IRRF SALÁRIO BRUTO
ISENTO INFERIOR A 1000
10% DE 1000 ATÉ 1500
20% SUPERIOR A 1500
 O salário líquido é igual ao salário bruto menos IRRF
 A gratificação segue a próxima tabela:

SALÁRIO LIQUIDO GRATIFICAÇÃO
ATÉ 1700 100 REAIS
SUPERIOR A 1700 50 REAIS

Exibir todos os calculos:
 Valor da hora trabalhada
 Salário do mês
 Valor dos dependentes
 Valor da hora extra
 Valor a receber das horas extras
 Salário bruto
 Valor do imposto
 Salário liquido
 Valor da gratificação
 Salário a receber"""

print("=" * 50)
print("Exercicio 4 - LP - 18/03/2026".center(50))
print("=" * 50)

s = int(input("Digite o salário mínino:"))
ht = int(input("Digite a qantida de horas trabalhadas:"))
nd = int(input("Digite a quantidade de dependentes:"))
he = int(input("Digite a quantidade de horas extras trabalhadas:"))

vht=s*(1/5)

sm=ht*vht

vd=nd*32

vhe=he*(vht*1.5)

ve=(vht*1.5)

sb=sm+vd+vhe

if(sb<1000):
    sl=sb
    if(sl<=1700):
        sr=sl+100
        
        print("Valor hora trabalhada:",vht)
        print("Salário do mês:",sm)
        print("Valor dos dependentes:",vd)
        print("Valor hora extra:",ve)
        print("Valor a receber das horas extras:",vhe)
        print("Salário bruto:",sb)
        print("Valor do imposto: INSENTO")
        print("Salário líquido:",sl)
        print("Valor da gratificação é 100")
        print("Salário a receber",sr)
    
elif(sb>=1000 and sb<=1500):
    ip=sb*0.10
    sl=sb-ip
    if(sl<=1700):
        sr=sl+100
        
        print("Valor hora trabalhada:",vht)
        print("Salário do mês:",sm)
        print("Valor dos dependentes:",vd)
        print("Valor hora extra:",ve)
        print("Valor a receber das horas extras:",vhe)
        print("Salário bruto:",sb)
        print("Valor do imposto:",ip)
        print("Salário líquido:",sl)
        print("Valor da gratificação é 100")
        print("Salário a receber",sr)
    elif(sl>1700):
        sr=sl+50
        
        print("Valor hora trabalhada:",vht)
        print("Salário do mês:",sm)
        print("Valor dos dependentes:",vd)
        print("Valor hora extra:",ve)
        print("Valor a receber das horas extras:",vhe)
        print("Salário bruto:",sb)
        print("Valor do imposto:",ip)
        print("Salário líquido:",sl)
        print("Valor da gratificação é 50")
        print("Salário a receber",sr)
    
    
elif(sb>1500):
    ip=sb*0.20
    sl=sb-ip
    if(sl<=1700):
        sr=sl+100
        
        print("Valor hora trabalhada:",vht)
        print("Salário do mês:",sm)
        print("Valor dos dependentes:",vd)
        print("Valor hora extra:",ve)
        print("Valor a receber das horas extras:",vhe)
        print("Salário bruto:",sb)
        print("Valor do imposto:",ip)
        print("Salário líquido:",sl)
        print("Valor da gratificação é 100")
        print("Salário a receber",sr)
    elif(sl>1700):
        sr=sl+50
        
        print("Valor hora trabalhada:",vht)
        print("Salário do mês:",sm)
        print("Valor dos dependentes:",vd)
        print("Valor hora extra:",ve)
        print("Valor a receber das horas extras:",vhe)
        print("Salário bruto:",sb)
        print("Valor do imposto:",ip)
        print("Salário líquido:",sl)
        print("Valor da gratificação é 50")
        print("Salário a receber",sr)
    


    

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)
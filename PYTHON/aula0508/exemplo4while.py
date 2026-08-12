"""Faça um programa que receba a idade, o peso e o sexo (F/M)
de um grupo de pessoas. Calcule e exiba:
a)total de homens
b)total de mulheres
c)média das idades dos homens
d)média dos pesos das mulheres
Inserir no programa uma mensagem para o usuário perguntando
se deseja continuar"""

print("="*50)
print("Programa Idade, Peso e Sexo".center(50))
print("="*50)

cont = "S"

qhomens = 0
qmulheres = 0

idadeh = 0

pesom = 0

while cont != "N":
    idade = float(input("Digite sua idade:"))
    peso = float(input("Digite seu peso:"))
    sexo = input("Digite seu sexo [F/M]:").upper()

    if sexo == "F":
        qmulheres = qmulheres+1
        pesom = pesom+peso
    else:
        qhomens = qhomens+1
        idadeh = idadeh+idade
        
    cont = input("Deseja continuar?[S]SIM [N]NÃO:").upper()
    
if(qhomens >= 1):
    mediah = idadeh/qhomens
    print("Total de homens:", qhomens)
    print("Média idade homens:", mediah)
else:
    print("Homens não foram cadastrados!")

if(qmulheres >= 1):
    mediam = pesom/qmulheres
    print("Total mulheres:", qmulheres)
    print("Média peso mulheres:", mediam)
else:
    print("Mulheres não foram cadastradas!")

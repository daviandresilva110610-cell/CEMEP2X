"""3. Sistema de cobrança de estacionamento
Um estacionamento cobra valores diferentes de acordo com o tempo que o
veículo permaneceu no local.
Crie um programa que solicite ao usuário o tempo de permanência no
estacionamento em horas.

De acordo com o tempo informado, o programa deve calcular o valor a ser
pago seguindo a tabela:
Tempo estacionado Valor
Até 1 hora R$ 5,00
Mais de 1 até 3 horas R$ 8,00
Mais de 3 até 6 horas R$ 12,00
Mais de 6 horas R$ 15,00
O programa deve mostrar:
 o tempo informado
 o valor total a ser pago"""
print("=" * 50)
print("Exercicio 3 - LP - 18/03/2026".center(50))
print("=" * 50)

t = float(input("Digite o tempo de permanência no local em horas:"))

if(t<=1):
    print("Tempo informado:",t)
    print("Valor a ser pago é de R$ 5,00")
if(t>1 and t<=3):
    print("Tempo informado:",t)
    print("Valor a ser pago é de R$ 8,00")
if(t>3 and t<=6):
    print("Tempo informado:",t)
    print("Valor a ser pago é de R$ 12,00")
if(t>6):
    print("Tempo informado:",t)
    print("Valor a ser pago é de R$ 15,00")


print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)

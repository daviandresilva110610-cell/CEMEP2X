"""2. Sistema de Venda de Ingressos de Cinema
Desenvolva um programa para simular a venda de ingressos de um
cinema. O valor do ingresso pode variar de acordo com idade da pessoa,
se ela é estudante e o dia da semana.
O programa deve solicitar ao usuário as seguintes informações:
 Idade da pessoa
 Se a pessoa é estudante (responder com S para sim ou N para não)
 Dia da semana (Segunda, Terça, Quarta, Quinta, Sexta, Sábado e
Domingo)
O preço normal do ingresso (inteira) é:
 R$ 30,00
O programa deve verificar as seguintes condições:
 Estudantes pagam meia-entrada, ou seja, 50% de desconto.
 Pessoas com 60 anos ou mais também pagam meia-entrada.
 Às quartas-feiras todos os clientes pagam meia-entrada,
independentemente da idade ou de serem estudantes.
Ou seja:
 Inteira → R$ 30,00
 Meia → R$ 15,00
Se mais de uma condição de meia-entrada ocorrer, o desconto não se
acumula. O cliente pagará apenas uma meia-entrada.
O programa deve mostrar ao final:
 idade do cliente
 se é estudante ou não
 dia da semana informado
 tipo de ingresso (inteira ou meia)
 valor final a pagar"""

print("=" * 50)
print("Exercicio 2 - LP - 18/03/2026".center(50))
print("=" * 50)

i = int(input("Digite a idade:"))
e = (input("É estudante(digite em minúsculo)?[S]SIM || [N]NÃO:"))
print("Segunda[1]||Terça[2]||Quarta[3]")
print("Quinta[4]||Sexta[5]||Sábado[6]||Domingo[7]")
d = int(input("Digite o dia da semana:"))

ig=30

print("Idade do cliente",i)
if(e=='s'):
    print("É estudante")
else:
    print("Não é estudante")
    
if(d==1):
    print("O dia da semana é segunda")
elif(d==2):
    print("O dia da semana é terça")
elif(d==3):
    print("O dia da semana é quarta")
elif(d==4):
    print("O dia da semana é quinta")
elif(d==5):
    print("O dia da semana é sexta")
elif(d==6):
    print("O dia da semana é sábado")
elif(d==7):
    print("O dia da semana é domingo")
    
if(e=='s' or d==3 or i>=60):
    print("Meia entrada")
    print("Valor final",ig*0.5)
    
else:
    print("Inteira")
    print("Valor final",ig)

print("=" * 50)
print("Desenvolvido por Davi".center(50))
print("=" * 50)















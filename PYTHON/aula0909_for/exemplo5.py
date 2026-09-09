qtd_par = 0
for i in range(5):
    numero = int(input("Digite um número: "))
    if numero % 2 == 0:
        qtd_par = qtd_par + 1

print("A quantidade de números pares é:",qtd_par)

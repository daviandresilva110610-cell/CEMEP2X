print("="*50)
print("Cadastro de Números".center(50))
print("Para finalizar o programa digite zero".center(50))
print("="*50)

pares = 0

impares = 0

num = float(input("Digite um número qualquer:"))

while num != 0:
    if num % 2 == 0:
        pares = pares+1
    else:
        impares = impares+1
    num  = float(input("Digite um número qualquer"))


print("Quantidade de números pares:", pares)
print("Quantidade de números ímpares:", impares)

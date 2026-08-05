#Operador in
#True se existir
#False se não existir
texto = input("Digite um texto:")
texto = input("Digite uma letra:")

procuraletra = letra in texto
print(procuraletra)

if procuraletra == True:
    print("A letra foi encontrada")
else:
    print("A letra não foi encontrada")

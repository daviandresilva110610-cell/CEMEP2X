#TRANSFORMANDO STRINGS EM MAIÚSCULAS

#exemplo1
resp = input("Deseja continuar [S] Sim ou [N]Não:").upper()
print(resp)

#exemplo2
texto = "boa tarde"
x = texto.upper()
print(x)

#exemplo3
resp = input("Deseja continuar [S] Sim [N] Não:").lower()
print(resp)

#exemplo4
texto = "BOA TARDE"
x = texto0.lower()
print(x)

#exemplo5:
frase = input("Digite a primeira frase:").title()
print(frase)

#exemplo6:
texto = "BOA TARDE"
x = texto.title()
print(x)

#exemplo7:
frase = input("Digite a primeira frase:").capitalize()
print(frase)

#exemplo8:
texto = "BOA TARDE"
x = texto.capitalize()
print(x)

#Exemplo9:
#podemos armazenar o resultado (tamanho da string) em uma variável
frase = "Linguagem de Programação Python"
tamanho = len(frase)
print(f"O tamanho da string é de {tamanho} caracteres")

#Exemplo10:
#podemos exibir o tamanho da string direto no print
frase1 = "Linguagem de Programação Python"
print(f"O tamanho da string é de {len(frase1)} caracteres")


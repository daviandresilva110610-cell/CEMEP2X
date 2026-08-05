"""4. Crie um programa que receba um texto digitado pelo usuário e gere um relatório
contendo:
 Texto original.
 Texto sem espaços extras
 Quantidade de palavras

 Texto em maiúsculas
 Texto em minúsculas
 Texto em formato de título
 Texto com a primeira letra maiúscula
 Texto substituindo espaços por _
 Os 10 primeiros caracteres
 Os 10 últimos caracteres

 O texto centralizado em uma largura de 80 caracteres """

print("="*60)
print("EXERCÍCIO 4".center(60))
print("="*60)

texto = input("Digite um texto: ")

print("\nTexto original:", texto)
print("Texto sem espaços extras:", texto.strip())
print("Quantidade de palavras:", len(texto.split()))

print("Maiúsculas:", texto.upper())
print("Minúsculas:", texto.lower())

print("Com formato de título:", texto.title())
print("Primeira letra maiúscula:", texto.capitalize())
print("Com _ :", texto.replace(" ", "_"))

print("10 primeiros caracteres:", texto[:10])
print("10 últimos caracteres:", texto[-10:])
print("Centralizado:")

print(texto.center(80))

print("="*60)
print("DESENVOLIDO POR DAVI 2°X".center(60))
print("="*60)

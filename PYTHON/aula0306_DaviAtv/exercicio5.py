"""5. Faça um programa que receba uma frase e exiba:
(A) Contar quantas vezes apareceu a letra ‘o’ na frase.
(B) Em que posição ela apareceu a primeira vez.
(C) Em que posição ela apareceu a última vez.
(D) Exibir a quantidade de letras da string.
(E) Verificar se existe a palavras Python na frase (usar decisão decisão).
(F) Verificar se a frase começa com a palavra Python.
(G) Verificar se a frase termina com a palavra Python.
(H) Quantas letras tem a primeira palavra.
(I) Quantas letras tem a última palavra.
(J) Quantidade de letras ao todo sem considerar espaços.
(K) Exibir a primeira palavra.
(L) Exibir a última palavra. """

print("="*60)
print("EXERCÍCIO 5".center(60))
print("="*60)

frase = input("Digite uma frase: ")

palavras = frase.split()

print("Quantidade de letras 'o':", frase.lower().count("o"))
print("Primeira posição da letra 'o':", frase.lower().find("o"))
print("Última posição da letra 'o':", frase.lower().rfind("o"))
print("Quantidade de caracteres:", len(frase))

if "python" in frase.lower():
    print("Existe a palavra Python na frase.")
else:
    print("Não existe a palavra Python na frase.")

if frase.lower()[:6] == "python":
    print("Começa com Python")
else:
    print("Não começa com Python")

if frase.lower()[-6:] == "python":
    print("Termina com Python")
else:
    print("Não termina com Python")
    
print("Quantidade de letras da primeira palavra:", len(palavras[0]))
print("Quantidade de letras da última palavra:", len(palavras[-1]))
print("Quantidade de letras sem espaços:", len(frase.replace(" ", "")))
print("Primeira palavra:", palavras[0])
print("Última palavra:", palavras[-1])

print("="*60)
print("DESENVOLVIDO POR DAVI 2°X".center(60))
print("="*60)

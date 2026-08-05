"""3. Peça ao usuário uma frase e informe:
 Quantas palavras ela possui.
 A primeira palavra.
 A última palavra.
 A frase em maiúsculas.
 A frase em minúsculas.
 A frase com a primeira letra maiúscula"""

print("="*60)
print("EXERCÍCIO 3".center(60))
print("="*60)

frase = input("Digite uma frase: ")

plvrs = frase.split()

print("Quantidade de palavras:", len(plvrs))
print("Primeira palavra:", plvrs[0])
print("Última palavra:", plvrs[-1])
print("Maiúsculas:", frase.upper())
print("Minúsculas:", frase.lower())
print("Primeira letra maiúscula:", frase.capitalize())

print("="*60)
print("DESENVLOVIDO POR DAVI 2°X".center(60))
print("="*60)

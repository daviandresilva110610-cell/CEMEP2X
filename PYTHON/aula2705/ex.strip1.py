"""O método strip() é usado para remover espaços em branco de ambos os lados de
uma string. Este método não aceita nenhum argumento."""
#Exemplo:
texto = "    Texto com espaço em branco no início e no fim.   "
print(texto)
print(texto.strip())

# "Texto com espaço em branco no início e no fim."

texto2 = input("Digite um texto:").strip()
print(texto2).strip()



"""O método rstrip() remove o espaço em branco do lado direito da string.
"""

texto3 = "Texto com espaço em branco no início e no fim.  "

print(texto3.rstrip())
# "Texto com espaço em branco no fim."


"""O método lstrip() remove o espaço em branco do lado esquerdo da string.
"""

texto4 = "  Texto com espaço em branco no início e no fim."

print(texto4.lstrip())
# "Texto com espaço em branco no início."


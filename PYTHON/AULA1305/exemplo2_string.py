
#Exemplo1:

#Vamos contar quantas vezes aparece a letra “o” no texto
texto = "Linguagem de Programação Python"
qtd_o = texto.count("o")
print(f"A quantidade de letras o no texto é {qtd_o}")

#Exemplo2:

#podemos exibir a quantidade direto no print
texto1 = "Linguagem de Programação Python"
print(f"A quantidade de letras o no texto é {texto1.count('o')}")

#Exemplo3:

#contando espaços
texto2 = "Linguagem de Programação Python "
print(f"A quantidade de espaços em branco no texto é {texto2.count(' ')}")

#Exemplo4:

#contando palavras
texto3 = "Eu amo morango, morango é a minha fruta preferida"
print(f"A palavra morango aparece na frase {texto3.count('morango')} vezes")

#Exemplo5:

#Se você quiser contar as ocorrências de um caracter ignorando maiusculas e minusculas, pode converter o texto para minusculas ou maiusculas antes de contar.
#contando um caracter independente de estar em maiusculo ou minisculo
texto = "Ola, mundo"
cont_o = texto.lower().count("o")
print(f"A letra o apareceu no texto {cont_o} vezes")
#nesse exemplo, texto.lower() converte todo o texto para minusculas
#antes de contar as ocorrências de 'o'


#CENTER


Exemplo1:

#centralizando texto em 50 espaços
texto = "Linguagem de Programação"
x = texto.center(50)
print(x)

Exemplo2:

texto = "Linguagem de Programação"
#preenchendo os espaços em branco com o caracter "="
x = texto.center(50,"=")
print(x)

Exemplo3:

#centralizando texto em 50 espaços, direto no print
print("Linguagem de Programação".center(50))



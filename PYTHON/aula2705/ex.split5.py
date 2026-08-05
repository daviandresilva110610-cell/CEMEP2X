"""O método split() em Python é usado para dividir uma string em uma lista de substrings, com base em um caractere ou string especificada como separador.

Sintaxe:

String.split(separador, maxsplit)

Parâmetros
separador: o caractere ou string que será usado como separador. Se não for especificado, o padrão é qualquer espaço em branco (espaço, tabulação, etc.).
maxsplit: o número máximo de divisões que serão feitas. Se não for especificado, todas as ocorrências do separador serão consideradas."""

#Split por espaços em branco

	Frase = “Ola mundo Python”
	Palavras = frase.split()
print(palavras) 
#[‘Ola’, ‘mundo’, ‘Python’]

#Split por vírgula

	Frase = “maça, banana, laranja”
      frutas = frase.split(‘,’)
print(frutas) 
#[‘maça’, ‘banana’, ‘laranja’]


#Split com maxsplit

	Frase = “Ola mundo Python é divertido”
	Palavras = frase.split(‘ ‘, 2)
print(palavras) 
#[‘Ola’, ‘mundo’, ‘Python é divertido’]

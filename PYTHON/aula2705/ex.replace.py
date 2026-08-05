"""O método replace() é usado para substituir uma parte específica de uma cadeia de caracteres por outra cadeia, se a correspondência for encontrada. Ele pode receber três argumentos, sendo dois obrigatórios e um opcional.
"""

texto = "Eu gosto de PHP, mas eu gosto mais de Python, PHP é legal"


substituicao = texto.replace("PHP", "Java")


print("String original:", texto)
# String original: Eu gosto de PHP, mas eu gosto mais de Python


print("String substituída:", substituicao)
# String substituída: Eu gosto de Java, mas eu gosto mais de Python


substituicao_2 = texto.replace("gosto", "não gosto", 1)


print("\nString original:", texto)
# String original: Eu gosto de PHP, mas eu gosto mais de Python


print("String substituída:", substituicao_2)
# String substituída: Eu não gosto de PHP, mas eu gosto mais de Python

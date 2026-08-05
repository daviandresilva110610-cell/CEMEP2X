<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <table border="1" width="60%" align="center">

        <!--Linha 1 Tabela-->
        <tr>
            <th><h1>Exemplo 1</h1></th>
        </tr>
        <!--Linha 2 Tabela-->
        <tr>
            <td align="center"><h2>Aula 10/03/2026</h2></td>
        </tr>
        <!--Linha Formulário Tabela-->
        <tr>
            <td>
                <form action="receber_dado.php" method="post">

                    <br>
                    Nome Funcionário:<input type="text" size="60" name="nomef">
                    <br>
                    <br>
                    Cargo:<input type="text" size="60" name="cargo">
                    <br>
                    <br>
                    Salário:<input type="number" size="60" name="sal">
                    <br>
                    <br>
                    <input type="submit" name="enviar" value="Enviar Dados">
                    <br>
                    <br>
                    <input type="reset" name="limpar" value="Limpar Dados">
                    <br>
                    <br>

                </form>
            </td>
        </tr>

        <tr>
            <td align="center"><h3>Desenvolvido por Davi</h3></td>
        </tr>


    </table>
</body>
</html>
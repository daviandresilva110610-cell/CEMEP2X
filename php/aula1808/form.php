<?php
require_once 'funcoes.php';
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Aluno</title>
</head>
<body>

<table border="1" align="center" width="50%">
    <tr class="header">
        <th>
            CADASTRO DE ALUNO<br>
            <?php data(); ?>
        </th>
    </tr>
    <tr>
        <td>
        <br><br>
            <form action="receber.php" method="post">

                Nome do Aluno:
                <input type="text" name="nome" >
                <br><br>

                Nota 1:
                <input type="number" name="n1">
                <br><br>

                Nota 2:
                <input type="number" name="n2">
                <br><br>

                <button type="submit">Enviar</button>

                <br><br><input  type="reset" name="limpar" value="Limpar">
            </form>
        </td>
    </tr>
    <tr class="footer">
        <td>Desenvolvido por: Davi Andre &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp &nbsp
        <?php
        exibirHoraSistema(); ?>
        </td>
    </tr>
</table>

</body>
</html>
<?php
include 'func.php';
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Aluno</title>
</head>
<body>

<table border="1" align="center" width="49%">
    <tr class="header">
        <th>
            Calculo Desconto da Compra<br>
            <?php data(); ?>
        </th>
    </tr>
    <tr>
        <td>
        <br><br>
            <form action="recebe.php" method="post">

                Nome do Produto:
                <input type="text" name="nome" >
                <br><br>

                Preço Unitário:
                <input type="number" name="preco">
                <br><br>

                Quantidade:
                <input type="number" name="quantidade">
                <br><br>

                <button type="submit">Calcular</button>

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
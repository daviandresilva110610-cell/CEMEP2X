<?php
require_once 'funcoes.php';
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Calcular Prestação</title>
</head>
<body>

<table border="1" align="center" width="30%">
    <tr class="header">
        <th>
            <h2>Calcular Prestação</h2>
            <?php data(); ?>
        </th>
    </tr>
    <tr>
        <td>
        <br><br>
            <form action="receber1.php" method="post">

                Valor da Prestação:
                <input type="text" name="prestacao" >
                <br><br>

                Dias de Atraso:
                <input type="number" name="diasAtraso">
                <br><br>

                <button type="submit">Calcular</button>

                <br><br><input  type="reset" name="limpar" value="Limpar">
            </form>
        </td>
    </tr>
    <tr class="footer">
        <td>Desenvolvido por: Davi Andre &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
        <?php
        exibirHoraSistema(); ?></td>
    </tr>
</table>

</body>
</html>

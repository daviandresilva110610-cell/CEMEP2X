<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Aluno</title>
</head>
<body>

<table border="1" align="center" width="30%">
    <tr class="header">
        <th>
            <h2>Calcular Prestação</h2>
            <?php
                require_once 'funcoes.php';
                data(); ?>
        </th>
    </tr>
    <tr>
        <td>
            <br>
        <?php
            require_once 'funcoes.php';

            $prestacao = $_POST["prestacao"];
            $diasAtraso = $_POST["diasAtraso"];

            calcularPrestacao($prestacao, $diasAtraso);
        ?>
          <br>  
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
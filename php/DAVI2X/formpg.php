<?php
include 'data.php';
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Funcionário</title>
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
                <td colspan="2">
                <form action="inserirpg.php" method="post">
                        <p>
                            Funcionário:
                            <input type="text"  name="func">
                        </p>

                        <p>
                            Valor salário mínimo:
                            <input type="text"  name="vsm">
                        </p>

                        <p>
                            Número de horas trabalhadas:
                            <input type="text"  name="nt">
                        </p>

                        <p>
                            Número de dependentes:
                            <input type="text"  name="nd">
                        </p>

                        <p>
                            Número de horas extras trabalhadas:
                            <input type="text"  name="net">  
                        </p>

                        <p>
                            <input type="submit" value="cadastrar">
                        </p>
                    </form>
                </td>
            </tr>
        </tbody>

        <tfoot>
            <tr>
                <td>Desenvolvido por: Davi Andre &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp &nbsp
        <?php
        exibirHoraSistema(); ?></td>
            </tr>
        </tfoot>
    </table>

</body>
</html>
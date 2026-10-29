<?php 

    include 'conexao.php';

    $func = $_POST['func'];
    $vsmin = $_POST['vsm'];
    $nt = $_POST['nt'];
    $nd = $_POST['nd'];
    $net = $_POST['net'];
    $vht = ($vsmin*(1/5));
    $vhet = ($vht*0.5);
    $vrhe = $vhet*$ne;
    $sm = ($nt*$vht);
    $vd = 32*$nd;
    $slb = $sm + $vd + $vrhe;

    if($slb <= 800){

        $sl = $slb;

    }
    elseif($slb > 800 || $slb <=1500){
        
        $sl = $slb*0.90;

    }
    elseif($slb > 1500){

        $sl = $slb * 0.80;

    }

    if($sl <= 700){

        $grt = 100;

    }
    else{

        $grt = 50;

    }

    $slr = $sl + $grt;

    
    include 'data.php';
    ?>
    <!DOCTYPE html>
    <html lang="pt-BR">
    <head>
        <meta charset="UTF-8">
        <title>Exibição</title>
    </head>
    <body>

        <table border="1" align="center" width="49%">
                <tr class="header">
                    <th>
                        Exibição<br>
                        <?php data(); ?>
                    </th>
                </tr>
                <tr>
                    <td colspan="2">
                    <?php 
                        print "VSM (Valor Salário Mínimo): R$ " . number_format($VSM, 2, ',', '.') . "<br>";
                        print "NHT (Número de Horas Trabalhadas): " . $NHT . " h<br>";
                        print "ND (Número de Dependentes): " . $ND . "<br>";
                        print "NHE (Número de Horas Extras Trabalhadas): " . $NHE . " h<br>";
                        print "VHT (Valor da Hora Trabalhada): R$ " . number_format($VHT, 2, ',', '.') . "<br>";
                        print "VD (Valor Dependentes): R$ " . number_format($VD, 2, ',', '.') . "<br>";
                        print "VHET (Valor da Hora Extra Trabalhada): R$ " . number_format($VHET, 2, ',', '.') . "<br>";
                        print "VRHE (Valor a Receber Hora Extra): R$ " . number_format($VRHE, 2, ',', '.') . "<br>";
                        print "<strong>SB (Salário Bruto): R$ " . number_format($SB, 2, ',', '.') . "</strong><br>";
                    ?>

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
<?php


    $cadastro = "INSERT INTO
    pagamento
    Values('','$func','$vsmin','$nt','$nd', '$net', '$telefone', '$email', '$cargo', '$dataAdmissao')";

    $querry = mysqli_query($conexao, $cadastro);
    header('location:formfun.php');


?>
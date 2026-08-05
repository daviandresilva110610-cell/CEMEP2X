<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<body>
    <table border="1" width="80%" align="center">


        <tr>
            <td align="center"><h1>RESULTADO</h1></td>
        </tr>       
        <tr>
            <td align="center"><h2></h2></td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="nome" value="<?php print $nome = $_POST["nome"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="idd" value="<?php print $idd = $_POST["idd"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="email" value="<?php print $email = $_POST["email"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="pdi" value="<?php print $pdi = $_POST["pdi"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="tdp" value="<?php print $tdp = $_POST["tdp"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="hosp" value="<?php print $hosp = $_POST["hosp"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="alimen" value="<?php print $alimen = $_POST["alimen"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    Seguro Viagem:
                    <input type="text" name="sv" value="<?php print $sv = $_POST["sv"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    Curso de inglês istensivo:
                    <input type="text" name="ci" value="<?php print $ci = $_POST["ci"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    Passeio turístico:
                    <input type="text" name="pat" value="<?php print $pat = $_POST["pat"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    Transporte aeroporto/hotel:
                    <input type="text" name="tah" value="<?php print $tah = $_POST["tah"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    Chip internacional:
                    <input type="text" name="chip" value="<?php print $chip = $_POST["chip"]; ?>">
            </td>
        </tr> 

        <?php
        
//Calculo Intercâmbio
        if($pdi == "Canadá"){

            $vi = 4500*$tdp;
        }
        elseif($pdi == "Estados Unidos"){

            $vi = 5200*$tdp;
        }
        elseif($pdi == "Inglaterra"){

            $vi = 5800*$tdp;
        }
        elseif($pdi == "Austrália"){

            $vi =6000*$tdp;
        }
//Calculo Hospedagem
        if($hosp == "Casa da Família"){
            $vh = 1200*$tdp;
        }
        elseif($hosp == "Dormitório estudantil"){
            $vh = 900*$tdp;
        }
        elseif($hosp == "Apartamento compartilhado"){
            $vh = 1600*$tdp;
        }
//Calculo Alimentação
        if($alimen == "Sem alimentação"){
            $va = 0*$tdp;
        }
        elseif($alimen == "Café da manhã"){
            $va = 300*$tdp;
        }
        elseif($alimen == "Meia pensão"){
            $va = 700*$tdp;
        }
        elseif($alimen == "Pensão completa"){
            $va = 1200*$tdp;
        }
//Calculo Serviços
        $tsv = 0;
        if($sv == "Sim"){
            $tsv = $tsv+800;
        }
        else{}

        if($ci == "Sim"){
            $tsv = $tsv+1500;
        }
        else{}

        if($pat == "Sim"){
            $tsv = $tsv+600;
        }
        else{}

        if($tah == "Sim"){
            $tsv = $tsv+250;
        }
        else{}
        if($chip == "Sim"){
            $tsv = $tsv+120;
        }
        else{}
//Calculo Valor Final
        $vf = $vi+$vh+$va+$tsv;

        if($tdp > 6){
            $vfd = $vf*0.95;
        }
        elseif($tdp >12){
            $vfd = $vf*0.90;
        }     
        ?>

        <tr>
            <td>
             Valor do Intercâmbio:<br>       
            <?php print $vi; ?>
            </td>
        </tr>
        <tr>
            <td>
             Valor da Hospedagem:<br>       
            <?php print $vh; ?>
            </td>
        </tr>
        <tr>
            <td>
             Valor da Alimentação:<br>       
            <?php print $va; ?>
            </td>
        </tr>
        <tr>
            <td>
             Valor de Serviços:<br>       
            <?php print $tsv; ?>
            </td>
        </tr>
        <tr>
            <td>
             Valor Final Viagem:<br>       
            <?php print $vf; ?>
            </td>
        </tr>
        <tr>
            <td>
             Valor do Intercâmbio com Desconto:<br>       
            <?php print $vfd; ?>
            </td>
        </tr>








        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lanchonete Divina Refeição</title>
</head>
<body>
    <table border="1" width="60%" align="center">

        <tr>
            <td align="center"><h1>EXERCÍCIO 3</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>DS-19/03/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2></h2></td>
        </tr>

        <tr>
            <td>
                <?php

                $t = $_POST["t"];
                $vm = $_POST["vm"];

                $d = $t*$vm;
                $l = $d/12;




                print("Tempo de viagem: $t h <br>");
                print("Velocidade média: $vm Km/h <br>");
                print("Distância percorrida: $d Km <br>");
                print("Litros utilizados: $l L<br>");

                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>
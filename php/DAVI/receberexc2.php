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
            <td align="center"><h1>EXERCÍCIO 2</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>DS-17/03/2026</h2></td>
        </tr>

        <tr>
            <td align="center"><h2></h2></td>
        </tr>

        <tr>
            <td>
                <?php

                $vb = $_POST["vb"];
                $vn = $_POST["vn"];
                $v = $_POST["v"];
                $vt = $_POST["vt"];

                $pb = ($vb/$vt)*100;
                $pn = ($vn/$vt)*100;
                $pv = ($v/$vt)*100;



                print("Números de eleitores: $vt <br>");
                print("Número de votos brancos: $vb <br>");
                print("Número de votos nulos: $vn <br>");
                print("Número de votos válidos: $v <br>");
                print("Percentual de votos brancos: $pb <br>");
                print("Percentual de votos nulos: $pn <br>");
                print("Percentual de votos válidos: $pv <br>");
                ?>
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>
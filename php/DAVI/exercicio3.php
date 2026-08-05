<!--3. Faça um programa que receba o peso de uma pessoa, calcule e exiba: o
peso dessa pessoa em gramas; se essa pessoa engordar 5% qual será seu
novo peso em gramas. Colocar tudo dentro de uma tabela conforme
exemplo acima.--> 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
     <table border="1" align="center" width="50%">
        <tr><!--PRIMEIRA LINHA-->
            <td align="center"> <h1>EXERCÍCIO 3</h1> </td>
        </tr>
        <tr><!--SEGUNDA LINHA-->
            <td align="center"> <h2> AULA DS - 03/03/2026 </h2> </td>
        </tr>
        <tr><
            <td> <h2>
                <?php

                    $p=50;
                    $pg=$p*1000;
                    $npg=$pg*1.05;
                    print("Peso:$p kg<br>");
                    print("Peso em gramas:$pg g<br>");
                    print("Novo Peso em Gramas com 5%:$npg g<br>");
                ?>

                </h2> 
            </td>
        </tr>
        <tr>
            <td align="center"> <h2> Desenvolvido por DAVI</h2>
        </tr>
    


</body>
</html>
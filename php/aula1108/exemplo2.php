<?php 
function somar($n1, $n2)
{
    $soma = $n1 + $n2;
    print("O resultado da soma de $n1 + $n2 é $soma <br>");
}

function subtrair($n1, $n2)
{
    $subtra = $n1 + $n2;
    print("O resultado da subtração de $n1 - $n2 é $subtra<br>");
}

somar(10,5);
somar(20,10);
somar(30,50);
print("<br>");
subtrair(30,10);
subtrair(50,25);

?>
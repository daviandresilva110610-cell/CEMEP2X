<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

<table border="1" width="50%" align="center">
    
    <tr> 
    <td align="center"> <h1> EXERCÍCIO 1 FIXAÇÃO </h1>
    </tr>
    
    <tr> 
    <td align="center"> <h2> DS-24/03/2026 </h2></td>
    </tr>
   
    <tr>
        <td>

        <?php
    $n = $_POST["n"];
    $v = $_POST["v"];
    $dt = $_POST["dt"];
    $p = $_POST["p"];

    print("Nome: $n <br><br>");
    print("Valor do Plano:R$ $v <br><br>");
    if($p=='Plano A')
    {
        print("Plano Anti-stress<br><br>");
        $vp=$v*1.06;
        print("Valor do Plano:R$ $vp <br><br>");
    }
    elseif($p=='Plano B')
    {
        print("Plano Reeducação<br><br>");
        $vp=$v*1.08;
        print("Valor do Plano:R$ $vp <br><br>");
    }
    elseif($p=='Plano C')
    {
        print("Plano Plano Completo<br><br>");
        $vp=$v*1.12;
        print("Valor do Plano:R$ $vp <br><br>");
    }

  



?>

            <br><br>
    <tr> 
    <td align="center"> <h2> DESENVOLVIDO POR DAVI </h2></td>
    </tr>
        </form>
        </td>
    </tr>

    </table>
    
</body>
</html>
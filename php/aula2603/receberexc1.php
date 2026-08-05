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
    <td align="center"> <h1> EXERCÍCIO 1</h1>
    </tr>
    
    <tr> 
    <td align="center"> <h2> DS-26/03/2026 </h2></td>
    </tr>
   
    <tr>
        <td>

        <?php
    $n = $_POST["n"];
    $s = $_POST["s"];


    if($s>=0 and $s<=1000)
    {
        $sr=$s*1.5;
        print("Salário atual:R$ $s<br><br>");
        print("Salário reajustado:R$ $sr <br><br>");
        print("A porcentagem de  reajuste foi de 50%.");
    }
    elseif($s>100)
    {
        $sr=$s*1.3;
        print("Salário atual:R$ $s<br><br>");
        print("Salário reajustado:R$ $sr <br><br>");
        print("A porcentagem de  reajuste foi de 30%.");
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
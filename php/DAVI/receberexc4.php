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
    <td align="center"> <h1> EXERCÍCIO 4 </h1>
    </tr>
    
    <tr> 
    <td align="center"> <h2> DS-19/03/2026 </h2></td>
    </tr>
   
    <tr>
        <td>

        <?php
    $litros = $_POST["litros"];
    $preco = $_POST["preco"];
    $litrosM =  $litros * 30;
    $precoM = $preco * $litrosM;

    print("Litros consumidos por dia: $litros L <br><br>");
   
    print("Preço por litro de água:R$ $preco <br><br>");
    
    print("Consumo mensal de água: $litrosM L <br><br>");

    print("Valor mensal da conta:R$ $precoM <br><br>");

  



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
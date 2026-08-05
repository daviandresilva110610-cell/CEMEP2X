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
    <td align="center"> <h1> EXERCÍCIO 2</h1>
    </tr>
    
    <tr> 
    <td align="center"> <h2> DS-26/03/2026 </h2></td>
    </tr>
   
    <tr>
        <td>

        <?php
    $n = $_POST["n"];
    $i = $_POST["i"];


    if($i>=5 and $i<=7)
    {
        print("Categoria: INFANTIL A<br>");
        print("Idade: $i anos");
    }
    elseif($i>=8 and $i<=10)
    {
        print("Categoria: INFANTIL B<br>");
        print("Idade: $i anos");
    }
    elseif($i>=11 and $i<=13)
    {
        print("Categoria: JUVENIL A<br>");
        print("Idade: $i anos");
    }
    elseif($i>=14 and $i<=18)
    {
        print("JUVENIL B<br>");
        print("Idade: $i anos");
    }
    elseif($i>=14 and $i<=18)
    {
        print("SENIOR<br>");
        print("Idade: $i anos");
    }
    else
    {
        print("NÃO PODE COMPETIR");
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
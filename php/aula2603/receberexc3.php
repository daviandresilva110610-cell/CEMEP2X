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
    <td align="center"> <h1> EXERCÍCIO 3  </h1>
    </tr>
    
    <tr> 
    <td align="center"> <h2> DS-26/03/2026 </h2></td>
    </tr>
   
    <tr>
        <td>

        <?php
        $n = $_POST["n"];
    $n1 = $_POST["n1"];
    $n2 = $_POST["n2"];
    $n3 = $_POST["n3"];

    $nt = ($n1*0.2)+($n2*0.3)+($n3*0.5);


    if($nt>=8 and $nt<=10)
    {
        print("Média Final: $nt<br>");
        print("Conceito A<br>");
    }
    elseif($nt>=7 and $nt<8)
    {
        print("Média Final: $nt<br>");
        print("Conceito B<br>");
    }
    elseif($nt>=6 and $nt<7)
    {
        print("Média Final: $nt<br>");
        print("Conceito C<br>");
    }
    elseif($nt>=5 and $nt<6)
    {
        print("Média Final: $nt<br>");
        print("Conceito D<br>");
    }
    elseif($nt>=0 and $nt<5)
    {
        print("Média Final: $nt<br>");
        print("Conceito E<br>");
    }
    else
    {
        print("MÉDIA INVÁLIDA");
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
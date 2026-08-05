<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<body>
    <table border="1" width="60%" align="center">

        <tr>
            <td align="center"><h1>EXERCÍCIO 2</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>Paulínia, DS-28/04/2026</h2></td>

        </tr>
        <tr>
            <td>
                <table border="1" align="center" width="60%">

                    <tr>
                        <td align="center"><h4>IMC</h4></td>
                        <td align="center"><h4 >Faixa de risco</h4></td>
                    </tr>

                    <tr>
                        <td align="center">Abaixo de 20</td>
                        <td align="center">Abaixo do peso</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 20 até 25</td>
                        <td align="center">Normal</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 25 até 30</td>
                        <td align="center">Excesso de peso</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 30 até 35</td>
                        <td align="center">Obesidade</td>
                    </tr>

                    <tr>
                        <td align="center">Acima de 35</td>
                        <td align="center">Obesidade MÓRBIDA</td>
                    </tr>

                </table>
            </td>
        </tr>   
        <tr>
            <td>
                
             <form action="receberexc2.php" method="post">
                <br>

                Digite seu nome: <input type="text" size="14" name="n">
                <br><br>

                Digite a sua altura em metros: <input type="text" size="16" name="a">
                <br><br>

                Digite seu peso em Kg: <input type="number" size="16" name="p">
                <br><br>

                <input  type="submit" name="enviar" value="Enviar" >
                <br><br>

                <input  type="reset" name="limpar" value="Limpar">
                <br><br>
             </form>   
            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html> 
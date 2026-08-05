<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<body>
    <table border="1" width="80%" align="center">

        <tr>
            <td align="center"><h1>EXERCÍCIO 5</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>Paulínia, DS-28/04/2026</h2></td>

        </tr>
        <tr>
            <td>
                <table border="1" align="center" width="80%">
                        <tr>
                            <td align="center"><h3>Idade</h3></td>
                            <td align="center" width="71%"><h3>Grupo de Risco</h3></td>
                        </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table border="1" align="center" width="80%">
                    <tr>
                        <td></td>
                        <td align="center"><h4>Baixo</h4></td>
                        <td align="center"><h4>Médio</h4></td>
                        <td align="center"><h4 >Alto</h4></td>
                    </tr>

                    <tr>
                        <td align="center">18 a 24</td>
                        <td align="center">7</td>
                        <td align="center">8</td>
                        <td align="center">9</td>
                    </tr>

                    <tr>
                    <td align="center">25 a 40</td>
                        <td align="center">4</td>
                        <td align="center">5</td>
                        <td align="center">6</td>
                    </tr>

                    <tr>
                    <td align="center">41 a 70</td>
                        <td align="center">1</td>
                        <td align="center">2</td>
                        <td align="center">3</td>
                    </tr>

                </table>
            </td>
        </tr>   
        <tr>
            <td>
                
             <form action="receberexc5.php" method="post">
                <br>

                Cliente: <input type="text" size="14" name="n">
                <br><br>

                Idade: <input type="text" size="16" name="i">
                <br><br>

                Grupo de risco(B/M/A): <input type="text" size="16" name="g">
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
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
            <td align="center"><h1>EXERCÍCIO 3</h1></td>
        </tr>

        <tr>
            <td align="center"><h2>Paulínia, DS-28/04/2026</h2></td>

        </tr>
        <tr>
            <td>
                <table border="1" align="center" width="100%">

                    <tr>
                        <td align="center"><h4>Prato</h4></td>
                        <td align="center"><h4 >Sobremesa</h4></td>
                        <td align="center"><h4 >Bebida</h4></td>
                    </tr>

                    <tr>
                        <td align="center">1-Vegetariano - 180 cal</td>
                        <td align="center">1-Abacaxi - 75 cal</td>
                        <td align="center">1-Chá - 20 cal</td>
                    </tr>

                    <tr>
                    <td align="center">2-Peixe - 230 cal</td>
                        <td align="center">2-Sorvete diet - 110 cal</td>
                        <td align="center">2-Suco de Laranja - 70 cal</td>
                    </tr>

                    <tr>
                    <td align="center">3-Frango - 250 cal</td>
                        <td align="center">3-Mousse diet - 170 cal</td>
                        <td align="center">3-Suco de Melão - 100 cal</td>
                    </tr>

                    <tr>
                    <td align="center">4-Carne - 350 cal</td>
                        <td align="center">4-Mousse de chocolate - 200 cal</td>
                        <td align="center">4-Refrigerante - 65 cal</td>
                    </tr>

                </table>
            </td>
        </tr>   
        <tr>
            <td>
                
             <form action="receberexc3.php" method="post">
                <br>

                Cliente: <input type="text" size="14" name="n">
                <br><br>

                Prato: <input type="text" size="16" name="p">
                <br><br>

                Sobremesa: <input type="text" size="16" name="s">
                <br><br>

                Bebida: <input type="text" size="16" name="b">
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
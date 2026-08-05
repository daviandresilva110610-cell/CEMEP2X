<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lanchonete Divina Refeição</title>
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
            <td align="center"><h2></h2></td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="c" value="<?php print $_POST["c"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="cpf" value="<?php print $_POST["cpf"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="rg" value="<?php print $_POST["rg"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="sexo" value="<?php print $_POST["sexo"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="dtnasc" value="<?php print $_POST["dtnasc"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="ender" value="<?php print $_POST["ender"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="cdd" value="<?php print $_POST["cdd"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="estd" value="<?php print $_POST["estd"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="cep" value="<?php print $_POST["cep"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="fone" value="<?php print $_POST["fone"]; ?>">
            </td>
        </tr>
        <tr>  
            <td>      
                    <input type="text" name="email" value="<?php print $_POST["email"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="pl_adt" value="<?php print $_POST["pl_adt"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="vpd" value="<?php print $vpd = $_POST["vpd"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="qtddias" value="<?php print $qtddias = $_POST["qtddias"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="obs" value="<?php print $_POST["obs"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="fp" value="<?php print $fp = $_POST["fp"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                    <input type="text" name="dtp" value="<?php print $_POST["dtp"]; ?>">
            </td>
        </tr>
        <tr>
            <td>
                <?php 
                
                if($fp == "A Vista")
                {
                    print ($tp = ($vpd * $qtddias)*0.90);
                }
                else
                    print ($tp = ($vpd * $qtddias)*1.05);
                
                ?>
            </td>
        </tr>


            </td>   
        </tr>
        <tr>
             <td align="center"><h2>DESENVOLVIDO POR DAVI</h2></td>
        </tr>

    </table>
</body>
</html>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
<meta charset="utf-8">
<title></title>
</head>
<body>
<table border="1" align="center" width="50%">
    <tr>
        <td align="center" ><h1>Cadastro - Etapa 1 de 3</h1></td>
    </tr>
    <tr>
        <td align="center" ><h2>SPA - BEM ESTAR</h2></td>
    </tr>
    <tr>
        <td align="center" ><h1>DADOS DO CLIENTE</h1></td>
    </tr>
    <tr>
        <td>
            <form action="etapa2.php" method="post">
                <br><br>

                Cliente: <input type="text" name="c" size="50">
                <br><br>

                CPF: <input type="text" name="cpf" size="15">
                <br><br>

                RG: <input type="text" name="rg" size="15">
                <br><br>

                Sexo: <br><br>

                <input type="radio" name="sexo" value="feminino" > Feminino
                <input type="radio" name="sexo" value="masculino" > Masculino
                <br><br>

                Data Nascimento: <input type="text" name="dtnasc" size="10">
                <br><br>

                Endereço: <input type="text" name="ender" size="50">
                <br><br>

                Cidade: <input type="text" name="cdd" size="25">
                <br><br>

                Estado:
                <select name="estd">
                    <option value="AC">AC</option>
                    <option value="AL">AL</option>
                    <option value="AP">AP</option>
                    <option value="AM">AM</option>
                    <option value="BA">BA</option>
                    <option value="CE">CE</option>
                    <option value="DF">DF</option>
                    <option value="ES">ES</option>
                    <option value="GO">GO</option>
                    <option value="MA">MA</option>
                    <option value="MT">MT</option>
                    <option value="MS">MS</option>
                    <option value="MG">MG</option>
                    <option value="PA">PA</option>
                    <option value="PB">PB</option>
                    <option value="PR">PR</option>
                    <option value="PE">PE</option>
                    <option value="PI">PI</option>
                    <option value="RJ">RJ</option>
                    <option value="RN">RN</option>
                    <option value="RS">RS</option>
                    <option value="RO">RO</option>
                    <option value="RR">RR</option>
                    <option value="SC">SC</option>
                    <option value="SP">SP</option>
                    <option value="SE">SE</option>
                    <option value="TO">TO</option>
                </select>
                
                CEP: <input type="text" name="cep" size="10">
                <br><br>

                Telefone: <input type="text" name="fone" size="15">
                <br><br>

                Email: <input type="text" name="email" size="50">
                <br><br>
                <br>

                <center><input type="submit" value="Prosseguir >>">
                
                <br><br><input  type="reset" name="limpar" value="Limpar"> </center>

                <br>

            </form>
        </td>
    </tr>
    <tr>
        <td align="center" ><h3>DESENVOLVIDO POR DAVI 2ºX</h3></td>
    </tr>
</table>
</body>
</html>
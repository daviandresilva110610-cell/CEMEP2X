<?php
include 'data.php';
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro de Funcionário</title>
</head>
<body>

    <table border="1" align="center" width="49%">
            <tr class="header">
                <th>
                    Calculo Desconto da Compra<br>
                    <?php data(); ?>
                </th>
            </tr>
            <tr>
                <td colspan="2">
                <form action="inserirfun.php" method="post">
                        <p>
                            Nome:
                            <input type="text"  name="nome">
                        </p>

                        <p>
                            CPF:
                            <input type="text"  name="cpf">
                        </p>

                        <p>
                            Endereço:
                            <input type="text"  name="endereco">
                        </p>

                        <p>
                            Cidade:
                            <input type="text"  name="cidade">
                        </p>

                        <p>
                            Estado:
                            <select id="estado" name="estado">
                                <option value="">Selecione...</option>
                                <option value="AC">Acre</option>
                                <option value="AL">Alagoas</option>
                                <option value="AP">Amapá</option>
                                <option value="AM">Amazonas</option>
                                <option value="BA">Bahia</option>
                                <option value="CE">Ceará</option>
                                <option value="DF">Distrito Federal</option>
                                <option value="ES">Espírito Santo</option>
                                <option value="GO">Goiás</option>
                                <option value="MA">Maranhão</option>
                                <option value="MT">Mato Grosso</option>
                                <option value="MS">Mato Grosso do Sul</option>
                                <option value="MG">Minas Gerais</option>
                                <option value="PA">Pará</option>
                                <option value="PB">Paraíba</option>
                                <option value="PR">Paraná</option>
                                <option value="PE">Pernambuco</option>
                                <option value="PI">Piauí</option>
                                <option value="RJ">Rio de Janeiro</option>
                                <option value="RN">Rio Grande do Norte</option>
                                <option value="RS">Rio Grande do Sul</option>
                                <option value="RO">Rondônia</option>
                                <option value="RR">Roraima</option>
                                <option value="SC">Santa Catarina</option>
                                <option value="SP">São Paulo</option>
                                <option value="SE">Sergipe</option>
                                <option value="TO">Tocantins</option>
                            </select>
                        </p>

                        <p>
                            Telefone:
                            <input type="tel" id="telefone" name="telefone">
                        </p>

                        <p>
                            E-mail:
                            <input type="email" id="email" name="email">
                        </p>

                        <p>
                            Cargo:
                            <input type="text" id="cargo" name="cargo">
                        </p>

                        <p>
                            Data de Admissão:
                            <input type="date" id="dataAdmissao" name="dataAdmissao">
                        </p>

                        <p>
                            <input type="submit" value="cadastrar">
                        </p>
                    </form>
                </td>
            </tr>
        </tbody>

        <tfoot>
            <tr>
                <td>Desenvolvido por: Davi Andre &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp &nbsp
        <?php
        exibirHoraSistema(); ?></td>
            </tr>
        </tfoot>
    </table>

</body>
</html>
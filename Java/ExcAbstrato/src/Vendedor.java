import Exemplo.IntAutenticavel;
import Exemplo.PessoaLoja;

public class Vendedor  extends PessoaLoja implements IntAutenticavel {

    private double comissao;

    public Vendedor(String nome, String cpf, double comissao) {
        super(nome, cpf);
        this.comissao = comissao;
    }

    public double getComissao() {
        return comissao;
    }

    @Override
    public void realizarLogin() {
        System.out.println("\n[LOGIN] Vendedor " + getNome() + " logado com sucesso para bater ponto.");
    }

    @Override
    public void exibirCadastro() {
        System.out.println("\n--- CADASTRO DE VENDEDOR ---");
        System.out.println("Nome: " + getNome());
        System.out.println("Comissão: " + comissao + "%");
    }

}

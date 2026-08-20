import Exemplo.IntAutenticavel;
import Exemplo.PessoaLoja;

public class Cliente extends PessoaLoja implements IntAutenticavel {
    private String email;

    public Cliente(String nome, String cpf, String email) {
        super(nome, cpf);
        this.email = email;
    }

    public String getEmail() {
        return email;
    }

    @Override
    public void realizarLogin() {
        System.out.println("\n[LOGIN] Cliente " + getNome() + " logado com sucesso para visualizar seus pedidos.");
    }

    @Override
    public void exibirCadastro() {
        System.out.println("\n--- CADASTRO DE CLIENTE ---");
        System.out.println("Nome: " + getNome());
        System.out.println("E-mail para contato: " + email);
    }

}






package Exemplo;

public abstract class PessoaLoja {

    private String nome, cpf;

    public PessoaLoja(String nome, String cpf) {
        this.nome = nome;
        this.cpf = cpf;
    }

    public String getNome() {
        return nome;
    }

    public String getCpf() {
        return cpf;
    }

    public abstract void exibirCadastro();

}

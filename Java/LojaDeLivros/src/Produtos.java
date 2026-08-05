public class Produtos {

    String nome;
    Double preco;
    String descricao;

    public Produtos(String nome, Double preco, String descricao) {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Double getPreco() {
        return preco;
    }

    public void setPreco(Double preco) {
        this.preco = preco;
    }
    public void setPreco(Double perc, boolean aumento){
        if (aumento == true) {
            this.preco = preco+(preco * (perc/100));
        }
        else
            this.preco = preco-(preco * (perc/100));

    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

}

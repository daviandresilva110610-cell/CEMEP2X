public class Imovel {

    String tipo;
    String endereco;
    Double preco;

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public Double getPreco() {
        return preco;
    }

    public void setPreco(Double preco) {
        this.preco = preco;
    }

    public Imovel(String tipo, String endereco, Double preco){
        this.tipo = tipo;
        this. endereco = endereco;
        this.preco = preco;


    }

    @Override
    public String toString() {
        return "Tipo:"+tipo+
                "Endereço:"+endereco+
                "Preço:"+preco;


    }
}

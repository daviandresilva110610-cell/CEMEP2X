public class Eletronico extends Produtos {

    int garantia;

    public Eletronico(String nome, Double preco, String descricao, int garantia) {
        super(nome, preco, descricao);
        this.garantia = garantia;
    }

    public int getGarantaia() {
        return garantia;
    }

    public void setGarantaia(int garantaia) {
        this.garantia = garantaia;
    }

    @Override
    public String toString() {
        return "\nNome: "+nome+
                "\nPreço: "+preco+
                "\nDescrição: "+descricao+
                "\nGarantia:"+garantia+" meses";
    }
}


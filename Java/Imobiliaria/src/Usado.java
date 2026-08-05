public class Usado extends Imovel {

    int anoDeConstrucao;

    public Usado(int anoDeConstrucao, String tipo, String endereco, Double preco) {
        super(tipo, endereco, preco * 1.20);
        this.anoDeConstrucao = anoDeConstrucao;
    }

    public int getAnoDeConstrucao() {
        return anoDeConstrucao;
    }

    public void setAnoDeConstrucao(int anoDeConstrucao) {
        this.anoDeConstrucao = anoDeConstrucao;
    }

    @Override
    public String toString() {
        return "Usado{" +
                "anoDeConstrucao=" + anoDeConstrucao +
                ", tipo='" + tipo + '\'' +
                ", endereco='" + endereco + '\'' +
                ", preco=" + preco +
                '}';
    }
}

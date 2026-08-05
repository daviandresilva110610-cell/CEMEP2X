public class Novo extends Imovel {

    String nomeContrutora;

    public Novo(String nomeContrutora, String tipo, String endereco, Double preco){
        super(tipo, endereco, preco*1.40);
        this.nomeContrutora = nomeContrutora;
    }

    public String getNomeContrutora() {
        return nomeContrutora;
    }

    public void setNomeContrutora(String nomeContrutora) {
        this.nomeContrutora = nomeContrutora;
    }

    @Override
    public String toString() {
        return "Novo{" +
                "nomeContrutora='" + nomeContrutora + '\'' +
                ", tipo='" + tipo + '\'' +
                ", endereco='" + endereco + '\'' +
                ", preco=" + preco +
                '}';
    }
}

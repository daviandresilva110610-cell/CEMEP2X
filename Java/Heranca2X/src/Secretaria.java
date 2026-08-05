public class Secretaria extends Pessoa{

    private int nivelacesso;

    public secretaria(String nome, String cidade, int nivelacesso) {
        super(nome, cidade);
        this.nivelacesso = nivelacesso;
    }

    public int getNivelacesso() {
        return nivelacesso;
    }

    public void setNivelacesso(int nivelacesso) {
        this.nivelacesso = nivelacesso;
    }
}

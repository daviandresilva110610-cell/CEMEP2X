public class Livro extends Produtos {
    String privadoAutor;

    public Livro(String privadoAutor, String nome, Double preco, String descricao) {
        super(nome, preco, descricao);
        this.privadoAutor = privadoAutor;
    }

    public String getPrivadoAutor() {
        return privadoAutor;
    }

    public void setPrivadoAutor(String privadoAutor) {
        this.privadoAutor = privadoAutor;
    }

    @Override
    public String toString() {
        return "Nome: "+nome+
                "\nPreço: "+preco+
                "\nDescrição: "+descricao+
                "\nAutor:"+privadoAutor;
    }
}

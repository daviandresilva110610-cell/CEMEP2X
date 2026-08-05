public class Livros {
    //public, private, protected
    private String nome;
    private String autor;
    private int numeroDePaginas;


    public Livros(String nome, String autor, int numeroDePaginas)
    {
        this.nome = nome;
        this.autor = autor;
        this.numeroDePaginas = numeroDePaginas;
    }

    public String getNome(){
        return this.nome;
    }
    public String getAutor(){
        return this.autor;
    }
    public int getNumeroDePaginas(){
        return this.numeroDePaginas;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    public void setAutor(String autor){
        this.autor = autor;
    }
    public void setNumeroDePaginas(int numeroDePaginas){
        this.numeroDePaginas = numeroDePaginas;
    }


    @Override
    public String toString(){
        return "Nome: "+this.nome+
                "\nAutor: "+this.autor+
                "\nNúmero de Páginas: "+this.numeroDePaginas+
                "\n--------------------------------";
    }
}

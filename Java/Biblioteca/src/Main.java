public class Main {

    public static void main(String[] args) {

        Livros objLivro1 = new Livros("Java é para os fortes", "Deitel",700);
        Livros objLivro2 = new Livros("O py tá on - Python","Strawbernard", 400);
        objLivro1.setNumeroDePaginas(600);

        System.out.println("*Livro1*\n"+objLivro1.toString());
        System.out.println("\n*Livro2*\n"+objLivro2.toString());
    }

}

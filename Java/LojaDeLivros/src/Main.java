public class Main {

    public static void main(String[] args) {

        Livro livro = new Livro(
                "Erich maria remarque",
                "Nada de novo no Fronte",
                50.0,
                "Acho que tem algo sim..."
                );

        livro.setPreco(20.00,false);
        System.out.println(livro.toString());

        Eletronico eletronico = new Eletronico(
                "Cerular",
                2000.00,
                "MUITO GOOD",
                6
        );

        eletronico.setPreco(10.00, true);
        System.out.println(eletronico.toString());
    }
}

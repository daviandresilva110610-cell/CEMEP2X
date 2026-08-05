public class Main {

    public static void main(String[] args){

        Midia midia1 = new Midia("Inception", "Ficção científica/Ação", "Leonardo DiCaprio", "14 Anos", "Flime");
        Midia midia2 = new Midia("Titanic", "Romance / Drama", "Kate Winslet", "12 anos", "Filme");
        Midia midia3 = new Midia("The Dark Knight" ,"Ação / Super-herói" ,"Christian Bale" ,"12 anos" ,"Filme");
        Midia midia4 = new Midia("Frozen" ,"Animação / Musical" , "Idina Menzel" , "Livre" , "Animação / Filme");
        Midia midia5 = new Midia("Avengers: Endgame" ,"Ação / Ficção científica" ,"Robert Downey Jr." ,"12 anos" ,"Filme");

        midia1.setGenero("Ficção");
        midia2.setClassificacao("14 anos");
        midia3.setTipo("Obra de Arte");
        midia4.setTipo("Animação");
        midia5.setTipo("Obra de Arte");

        System.out.println("*Obra1*"+midia1.toString());
        System.out.println("*Obra2*"+midia2.toString());
        System.out.println("*Obra3*"+midia3.toString());
        System.out.println("*Obra4*"+midia4.toString());
        System.out.println("*Obra5*"+midia5.toString());


    }

}

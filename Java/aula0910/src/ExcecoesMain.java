public class ExcecoesMain {
    public static void main(String[] args) {
        String frase = null;
        String novaFrase = null;

        try {
            novaFrase = frase.toUpperCase();
        }
        catch(NullPointerExeption e){
            System.out.println("A frase inicial está nula");
            System.out.println("Será atribuido um valor padrão");
            frase="Frase vazia";
        }
        finally{
            novaFrase=frase.toUpperCase();
        }

        System.out.println("Frase antiga: "+ frase);
        System.out.println("Nova frase:"+ novaFrase);
    }
}

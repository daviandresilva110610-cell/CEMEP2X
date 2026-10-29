import java.util.ArrayList;
import java.util.Arrays;

public class ExercicioArrayList {

    public static void main(String[] args) {

        ArrayList<String> nomes = new ArrayList<>();

        nomes.add ("Anastácia");
        nomes.add ("Benefício");
        nomes.add("Clodoaldo");
        nomes.add("Diógenes");

        System.out.println("O tamanho da lista é:"+ nomes.size());

        System.out.println("O primeiro elemento é:"+ nomes.get(0));

        System.out.println("O nome Carlos está na lista?"+nomes.contains("Carlos"));

        nomes.remove(1);

        System.out.println("Os nomes restantes são:");
        for (String nome : nomes){
            System.out.println(nome);
        }

    }

}

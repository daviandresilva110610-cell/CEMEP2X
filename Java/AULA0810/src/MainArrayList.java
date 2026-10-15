import java.util.ArrayList;

public class MainArrayList {

    public static void main(String[] args) {

        ArrayList<Integer> list = new ArrayList<>(4);
        list.add("Uva");
        list.add("Banana");
        list.add("Morango");
        list.add("Manga");
        list.add("Kiwi");

        //exibindo o arraylist com um for
        for(int i=0; i< list.size(); i++) {
            System.out.println("Fruta:" + list.get(i));
        }
        //ass adiciona no fim da fila ou pode escolher uma posição
        list.add(1, "Melancia");
        //set substitui uma posição
        list.set(2, "Abacaxi");
        //remove um valor dado um indice ou o objeto (texto)
        list.remove( "Uva");
        //verifica se esta vazia
        System.out.println("Vazia?" + list.isEmpty());


            System.out.println("Usando FOREACH");
            for (String fruta: list){
                System.out.println(fruta);



            }
        }
    }
}

import java.util.Arrays;
public class MainArrays {
    public static void main(String[] args) {
        //declarando um array com 10 elementos
        int[] arr= {4,8,15,16,23,22,6,7,44,19};

        //tostring mostra os valores do array
        System.out.println("Valores:" + Arrays.toString(arr));
        //sort ordena os arrays
        Arrays.sort(arr);
        //valores ordenados
        System.out.println("Valores ordenados: "+ Arrays.toString(arr));
        //busca binaria: busca um valor em um array ordenado
        int indice = Arrays.binarySearch (arr, 8 );
        System.out.println("Posição do valor 8:" + indice);

        //copia arrays
        int[] copia=Arrays.copyOf(arr, 10);
        System.out.println("Antigo: " + Arrays.toString(arr));
        System.out.println("Novo: "+ Arrays.toString(copia));

        //verifica se sao iguais
        boolean iguais = Arrays.equals(arr, copia);
        System.out.println("São iguais? " + iguais);

        //copia uma parte específica do array
        int[] novaCopia=Arrays.copyOfRange(arr, 2, 8);
        System.out.println("Antigo: "+ Arrays.toString(arr));
        System.out.println("Novo: "+ Arrays.toString(novaCopia));



    }
}

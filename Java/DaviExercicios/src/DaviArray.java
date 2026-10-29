import java.lang.reflect.Array;
import java.util.Scanner;
import java.util.Arrays;

import static java.util.Arrays.sort;

public class DaviArray {

    public static void main(String[] args) {

        int[] v = {45, 12, 89, 3, 27};

        System.out.println("Valor dos vetores:"+ Arrays.toString(v));

        Arrays.sort(v);
        System.out.println("Valores ordenados "+ Arrays.toString(v));

        int indice = Arrays.binarySearch(v, 27);

        System.out.println("Valor está na posição:"+ indice);






    }

}

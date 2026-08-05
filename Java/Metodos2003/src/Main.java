import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        //começo

        Scanner in = new Scanner(System.in);
        System.out.println("Digite o nome:");
        String n = in.nextLine();
        exibirMensagem();
        mostrarnome(n);

    }//fim

    public static void exibirMensagem(){
        System.out.println("Helloooooo World!");
    }

    public static void mostrarnome(String nome){

        System.out.println("Nome:"+nome);

    }

}

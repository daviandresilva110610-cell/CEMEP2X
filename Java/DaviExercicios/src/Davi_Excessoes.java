public class Davi_Excessoes {

    public static void main(String[] args) {

        int a = 10, b = 0;

        try{
            int r = a/b;

            System.out.println("O resultado é:"+ r);
        }
        catch (ArithmeticException e){
            System.out.println("Erro: Não é possível dividir por zero!");
        }

        int[] numeros = {10, 20, 30};

        try{
            System.out.println(numeros[5]);
        }
        catch (ArrayIndexOutOfBoundsException e){
            System.out.println("Erro: Índice fora dos limites do vetor!");
        }
    }

}

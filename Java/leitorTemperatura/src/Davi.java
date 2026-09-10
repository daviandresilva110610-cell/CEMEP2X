import java.util.Scanner;

public class Davi {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int[] temp = new int[7];
        int i, cont, maior=0, menor=1000000, media, soma=0, contdias=0,diamaior=0, diamenor=0;

        System.out.println("\n--------------------------------------");
        for (i = 0; i < temp.length; i++){
            System.out.println("\nDigite a temperatura da dia "+(i+1)+" da semana");
            temp[i]=sc.nextInt();


            //MAIOR E MENOR
            if (temp[i]>maior){
                maior = temp[i];
                diamaior = (i+1);
            }
            if (temp[i]<menor){
                menor = temp[i];
                diamenor = (i+1);
            }
        }
        System.out.println("\n--------------------------------------");


        //EXIBIÇÃO TEMPERATURAS
        for (i = 0; i < temp.length; i++) {
            System.out.println("\nA temperatura do dia "+(i+1)+" da semana é: "+temp[i]+"C°");
        }
        System.out.println("\n--------------------------------------");
        for (i = 0; i < temp.length; i++){
            soma = soma+temp[i];
        }
        media = soma/7;


            //TEMPERATURAS ACIMA DA MÉDIA
        for (i = 0; i < temp.length; i++){

            if(temp[i]>media){
                contdias = contdias+1;
            }
        }

        //EXIBINDO RESULTADOS

        System.out.println("\n------------------RESULTADOS--------------------");
        System.out.println("\nMédia das temperaturas é: "+media+"C°");
        System.out.println("\nMaior temperatura da semana é: "+maior+"C°");
        System.out.println("\nMenoR temperatura da semana é: "+menor+"C°");
        System.out.println("\nDia com a maior temperatura foi o dia: "+diamaior);
        System.out.println("\nDia com a menor temperatura: "+diamenor);
        System.out.println("\nQuantos dias tiveram temperatura acima da média calculada: "+contdias);;
    }

}

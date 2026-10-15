import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class LerArquivos2 {


        public static void main(String[] args) {

            try {

                FileReader fileReader = new FileReader("src/Texto");


                BufferedReader buffer = new BufferedReader((fileReader));


                for (int i = 0; i < 10; i++) {

                    System.out.println(buffer.readLine());

                }

                buffer.close();
                fileReader.close();
            }
            catch (IOException e){
                System.out.println("Erro ao abrir o arquivo");
            }
        }

    }

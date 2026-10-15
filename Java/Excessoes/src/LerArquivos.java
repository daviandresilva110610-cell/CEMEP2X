import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;

public class LerArquivos {

        public static void main(String[] args) throws IOException{

            int a, b;

            Scanner sc = new Scanner(System.in);


            FileReader fileReader = new FileReader("src/Texto");
            BufferedReader buffer = new BufferedReader((fileReader));


            for (int i = 0; i < 10; i++) {

                System.out.println(buffer.readLine());

            }

            buffer.close();
            fileReader.close();
        }
}


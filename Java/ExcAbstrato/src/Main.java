import java.sql.SQLOutput;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("=== SISTEMA LOJA DE SAPATOS ===");



            System.out.println("\n--- CADASTRO INICIAL DO CLIENTE ---");
            System.out.print("Nome do Cliente: ");
            String nomeCliente = scanner.nextLine();
            System.out.print("CPF do Cliente: ");
            String cpfCliente = scanner.nextLine();
            System.out.print("E-mail do Cliente: ");
            String emailCliente = scanner.nextLine();

            Cliente cliente = new Cliente(nomeCliente, cpfCliente, emailCliente);


            System.out.println("\n--- CADASTRO INICIAL DO VENDEDOR ---");
            System.out.print("Nome do Vendedor: ");
            String nomeVendedor = scanner.nextLine();
            System.out.print("CPF do Vendedor: ");
            String cpfVendedor = scanner.nextLine();
            System.out.print("Percentual de Comissão (%): ");
            double comissaoVendedor = scanner.nextDouble();
            scanner.nextLine(); // Limpa o buffer do scanner


            Vendedor vendedor = new Vendedor(nomeVendedor, cpfVendedor, comissaoVendedor);


        int opcao = 0;
        while (opcao != 5) {
            System.out.println("\n==============================");
            System.out.println("      MENU DE OPÇÕES");
            System.out.println("==============================");
            System.out.println("1. Realizar login (Cliente)");
            System.out.println("2. Realizar login (Vendedor)");
            System.out.println("3. Exibir cadastro (Cliente)");
            System.out.println("4. Exibir cadastro (Vendedor)");
            System.out.println("5. Sair do Sistema");
            System.out.print("Escolha uma opção: ");

            opcao = scanner.nextInt();
            scanner.nextLine(); // Limpa o buffer

            switch (opcao) {
                case 1:
                    cliente.realizarLogin();
                    break;
                case 2:
                    vendedor.realizarLogin();
                    break;
                case 3:
                    cliente.exibirCadastro();
                    break;
                case 4:
                    vendedor.exibirCadastro();
                    break;
                case 5:
                    System.out.println("\nSaindo do sistema... Até logo!");
                    break;
                default:
                    System.out.println("\nOpção inválida! Tente novamente.");
            }
        }

        scanner.close();
    }
}
public class Main {

    public static void main(String[] args) {

        Pedido pedido1 = new Pedido("João","Playstation 5", 12345);
        Pedido pedido2 = new Pedido("Luigi","Figurinha", 64324);

        pedido2.setCliente("Emerson");
        pedido2.setDesc("Luigi");

        pedido1.setCliente("Davi");
        pedido1.setDesc("Fone de Retorno");

        System.out.println("*Pedido1*"+pedido1.toString());
        System.out.println("*Pedido2*"+pedido2.toString());



    }
}

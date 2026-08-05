public class Main {

    public static void main(String[] args) {

        Carro carro1 = new Carro("Fuscão", "Azul Bebê", 120.0);
        carro1.cor = "Azul Bebê";
        //carro1.modelo = "Fuscão";
        //carro1.velocidade = 100.0;

        carro1.acelerar();
        System.out.println(carro1.toString());
        //System.out.println("Carro: "+carro1.modelo);
        //System.out.println("Velocidade: "+carro1.velocidade);
        //System.out.println("Cor: "+carro1.cor);

        Carro carro2 = new Carro("Uno Firma", "Branco", 1000.0);
        //carro2.modelo = "Uno da Firma";
        //carro2.cor = "Branco";
        //carro2.velocidade = 1000.0;

        carro2.acelerar();
        //System.out.println("Carro: "+ carro2.modelo);
        //System.out.println("Velocidade: "+ carro2.velocidade);
        //System.out.println("Cor: "+ carro2.cor);

        Onibus obinus = new Onibus("Caio", 42);
        obinus.exibir();


    }
}

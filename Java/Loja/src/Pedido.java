public class Pedido {


    private int codigo;
    private String cliente;
    private String  desc;

    public Pedido(String cliente, String desc, int codigo){

        this.codigo = codigo;
        this.cliente = cliente;
        this.desc = desc;

    }

    public String getCliente(){return this.cliente;}
    public  String getDesc(){return this.desc;}

    public void setCliente(String cliente){this.cliente = cliente;}
    public void setDesc(String desc){this.desc = desc;}

    @Override
    public String toString() {
        return "\nCódigo do Pedido: "+codigo+
                "\nDescrição do Pedido: "+desc+
                "\nNome do Cliente: "+cliente+
                "\n-------------------------------";

    }
}

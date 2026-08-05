public class Professor extends Pessoa{

    private int carteiradetrabalho;

    public Professor(String nome, String cidade, int carteiradetrabalho){
        super(nome, cidade);
        this.carteiradetrabalho = carteiradetrabalho;
    }

    public int getCarteiradetrabalho() {
        return carteiradetrabalho;
    }

    public void setCarteiradetrabalho(int carteiradetrabalho) {
        this.carteiradetrabalho = carteiradetrabalho;
    }
}

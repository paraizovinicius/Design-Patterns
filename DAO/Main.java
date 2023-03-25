package DAO;

public class Main {
    public static void main(String[] args) {
    	
        ProdutoDAO dao = new ProdutoDAO();

        // inserindo um novo produto
        Produto produto1 = new Produto();
        produto1.setNome("Arroz");
        produto1.setPreco(10);
        dao.adicionar(produto1);
        System.out.println("Produto " + produto1.getNome() + " adicionado!");
        

        // atualizando um produto existente
        Produto produto2 = new Produto();
        produto2.setId(1);
        produto2.setNome("Feijao");
        produto2.setPreco(20);
        dao.atualizar(produto2);
        System.out.println("Produto " + produto2.getNome() + " atualizado!");
        
    }
}

       

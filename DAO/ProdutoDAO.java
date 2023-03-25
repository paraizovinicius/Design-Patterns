package DAO;

import java.util.ArrayList;
import java.util.List;

public class ProdutoDAO {
    // lista de produtos em memoria
    private List<Produto> produtos;

    // construtor que inicializa a lista de produtos
    public ProdutoDAO() {
        this.produtos = new ArrayList<>();
    }

    // metodo para adicionar um produto a lista
    public void adicionar(Produto produto) {
        this.produtos.add(produto);
    }

    // metodo para atualizar um produto existente na lista
    public void atualizar(Produto produto) {
        int index = this.produtos.indexOf(produto);
        if (index != -1) {
            this.produtos.set(index, produto);
        }
    }

    // metodo para remover um produto da lista
    public void remover(Produto produto) {
        this.produtos.remove(produto);
    }

    // metodo para buscar todos os produtos na lista
    public List<Produto> buscarTodos() {
        return new ArrayList<>(this.produtos);
    }

    // metodo para buscar um produto pelo seu ID
    public Produto buscarPorId(int id) {
        for (Produto produto : this.produtos) {
            if (produto.getId() == id) {
                return produto;
            }
        }
        return null;
    }
}
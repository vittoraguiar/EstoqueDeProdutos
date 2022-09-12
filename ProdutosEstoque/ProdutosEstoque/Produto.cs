namespace ProdutosEstoque;

public class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    private double ValorTotalEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        _quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        _quantidade -= quantidade;
    }

    public override string ToString()
    {
        return _nome + ", " + _preco.ToString("C") + ", " + _quantidade
               + " unidades. Total: " + ValorTotalEstoque().ToString("C");
    }
    
    
}

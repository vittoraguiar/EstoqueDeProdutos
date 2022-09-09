namespace ProdutosEstoque;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    private double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return Nome + ", " + Preco.ToString("C") + ", " + Quantidade
               + " unidades. Total: " + ValorTotalEstoque().ToString("C");
    }
    
    
}
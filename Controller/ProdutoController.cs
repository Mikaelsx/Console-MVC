using ConsoleMVC.Model;
using ConsoleMVC.View;

namespace ConsoleMVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.listar(produtos);
        }

        public void CadastrarProdutos()
        {
            produto.Inserir(produtoView.Cadastrar());

            // Produto novoProduto = produtoView.Cadastrar();

            
        }
    }
}
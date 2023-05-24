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
    }
}
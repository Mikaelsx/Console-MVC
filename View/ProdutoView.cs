using ConsoleMVC.Model;

namespace ConsoleMVC.View
{
    public class ProdutoView
    {
        public void listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                Console.WriteLine($"");
            }
        }
    }
}
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

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }
    }
}
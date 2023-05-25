namespace ConsoleMVC.Model
{
    public class Produto
    {
        //propriedades

        public int Codigo { get; set; }

        public string? Nome { get; set; }

        public float Preco { get; set; }

        
        //caminho da apasta e do arquivo csv

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //criar a logica para gerar a pasta e o arquivo

            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho ja existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho ja existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
        public List<Produto> Ler()
        {
            //lista de produtos
            List<Produto> produtos = new List<Produto>();

            //armazenamento das listas
            string[] linhas = File.ReadAllLines(PATH);

            //armazenamento das linhas
            foreach (var item in linhas)
            {
            string[] atributos = item.Split(";");

            Produto p = new Produto();

            p.Codigo = int.Parse(atributos[0]);
            p.Nome = atributos[1];
            p.Preco = float.Parse(atributos[2]);

            produtos.Add(p);

            }

            return produtos;
        }

        //métdo para declarar as linhas para serem inseridas no csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}
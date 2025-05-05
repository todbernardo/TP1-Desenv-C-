namespace ex1
{
    internal class Program
    {
        public delegate decimal CalculateDiscount(decimal precoOriginal);

        public static decimal BotarDesconto(decimal preco)
        {
            return preco * 0.9m;
        }
       static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço original do produto:");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            CalculateDiscount desconto = BotarDesconto;

            Console.WriteLine($"Preço com desconto: R${desconto(preco)}");
        }
    }
}

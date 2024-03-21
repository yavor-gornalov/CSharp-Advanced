using System.Text;

namespace P04_Product_Shop
{
    internal class Program
    {
        static void Main()
        {
            var shopProducts = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Revision")
                {
                    foreach (var (shopName, products) in shopProducts.OrderBy(x => x.Key))
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine(shopName + "->");
                        foreach (var (productName, productPrice) in products)
                            sb.AppendLine($"Product: {productName}, Price: {productPrice}");
                        Console.Write(sb.ToString());
                    }
                    break;
                }

                var tokens = line.Split(", ").ToArray();
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shopProducts.ContainsKey(shop))
                    shopProducts[shop] = new Dictionary<string, double>();

                if (!shopProducts[shop].ContainsKey(product))
                    shopProducts[shop][product] = price;

            }
        }
    }
}

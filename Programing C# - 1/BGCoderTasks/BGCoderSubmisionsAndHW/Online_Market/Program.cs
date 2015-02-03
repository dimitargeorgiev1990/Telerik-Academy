using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Online_Market
{
    class Program
    {
       static OrderedMultiDictionary<float, Product> ProductsByPrice =
            new OrderedMultiDictionary<float, Product>(true, new FloatComparer(), new ProductComparer());

       static Dictionary<string, Product> ProductsByName =
          new Dictionary<string, Product>();

       static OrderedMultiDictionary<string, Product> ProductsByType =
          new OrderedMultiDictionary<string, Product>(true, new StringComparer(), new ProductComparer());

       static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "end")
            {
                ParseCommand(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                line = Console.ReadLine();
            }
            Console.Write(sb);
        }

        private static void ParseCommand(string[] commandParams)
        {
            switch (commandParams[0])
            {
                case "add": AddProduct(commandParams[1], float.Parse(commandParams[2]), commandParams[3]);
                    break;
                case "filter":
                    if (commandParams[2] == "type")
                    {
                        FilterByType(commandParams[3]);
                    }
                    else if (commandParams[2] == "price")
                    {
                        if (commandParams[3] == "from")
                        {
                            if ( commandParams.Length == 7)
                            {
                                FilterFromTo(float.Parse(commandParams[4]), float.Parse(commandParams[6]));
                            }
                            else
                            {
                                FilterFrom(float.Parse(commandParams[4]));
                            }
                        }
                        else
                        {
                            FilterTo(float.Parse(commandParams[4]));
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private static void FilterTo(float to)
        {
            var arr = ProductsByPrice.RangeTo(to, true).Values.ToArray();
            PrintProds(arr);
        }

        private static void FilterFrom(float from)
        {
            var arr = ProductsByPrice.RangeFrom(from, true).Values.ToArray();
            PrintProds(arr);
        }

        private static void FilterFromTo(float from, float to)
        {
            var arr = ProductsByPrice.Range(from, true, to, true).Values.ToArray();
            PrintProds(arr);
        }
      
        private static void FilterByType(string type)
        {
            if (ProductsByType.ContainsKey(type))
            {
                var arr = ProductsByType[type].ToArray();
                PrintProds(arr);
            }
            else
            {
                sb.AppendLine("Error: Type "+type+" does not exists");
            }
        }

        private static void AddProduct(string name, float price, string type)
        {
            var product = new Product(name, price, type);
            if (ProductsByName.ContainsKey(name))
            {
                sb.AppendLine("Error: Product "+name+" already exists");
            }
            else
            {
                ProductsByName.Add(name, product);
                ProductsByType.Add(type, product);
                ProductsByPrice.Add(price, product);
                sb.AppendLine("Ok: Product "+name+" added successfully");
            }
        }

        private static void PrintProds(Product[] prods)
        {
            if (prods != null && prods.Length > 0)
            {
                sb.Append("Ok: ");
                int length = prods.Length > 10 ? 10 : prods.Length;
                for (int i = 0; i < length; i++)
                {
                    if (i >= prods.Length - 1)
                    {
                        sb.AppendLine(prods[i].Name + "(" + prods[i].Price + ")");
                    }
                    else
                    {
                        sb.Append(prods[i].Name + "(" + prods[i].Price + "), ");
                    }
                }
            }
            else
            {
                sb.AppendLine("Ok: ");
            }
        }
    }

    public class StringComparer : Comparer<string> 
    {
        public override int Compare(string x, string y)
        {
            return String.Compare(x, y, StringComparison.CurrentCulture);
        }
    }

    public class FloatComparer : Comparer<float> 
    {
        public override int Compare(float x, float y) 
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class ProductComparer : Comparer<Product>
    {
        public override int Compare(Product x, Product y)
    {
        if (x.Price > y.Price)
        {
            return 1;
        }
        else if (x.Price < y.Price)
        {
            return -1;
        }
        else
        {
            int i = String.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            if (i == 0)
            {
                i = String.Compare(x.Type, y.Type, StringComparison.CurrentCulture);
            }
            return i;
        }
    }
    }

    public class Product 
    {
        public Product(string name, float price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }
    }
}

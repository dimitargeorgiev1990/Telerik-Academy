using System;

public class Garden
{
    public static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InstalledUICulture;

        double tomatoSeeds = double.Parse(Console.ReadLine());
        double tomatoArea = double.Parse(Console.ReadLine());
        double cucumberSeeds = double.Parse(Console.ReadLine());
        double cucumberArea = double.Parse(Console.ReadLine());
        double potatoSeeds = double.Parse(Console.ReadLine());
        double potatoArea = double.Parse(Console.ReadLine());
        double carrotSeeds = double.Parse(Console.ReadLine());
        double carrotArea = double.Parse(Console.ReadLine());
        double cabbageSeeds = double.Parse(Console.ReadLine());
        double cabbageArea = double.Parse(Console.ReadLine());
        double beansSeeds = double.Parse(Console.ReadLine());

        double tomatoCost = 0.5;
        double cucumberCost = 0.4;
        double potatoCost = 0.25;
        double carrotCost = 0.6;
        double cabbageCost = 0.3;
        double beansCost = 0.4;

        double totalCosts = tomatoSeeds * tomatoCost + cucumberSeeds * cucumberCost + potatoSeeds * potatoCost
            + carrotSeeds * carrotCost + cabbageSeeds * cabbageCost + beansSeeds * beansCost;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        double beansArea = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collectables = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool quantityObtained = false;
            string obtainedItem = "";

            collectables.Add("shards", 0);
            collectables.Add("fragments", 0);
            collectables.Add("motes", 0);

            while (!quantityObtained)
            {
                string[] currentRow = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < currentRow.Length - 1; i += 2)
                {
                    int quantity = int.Parse(currentRow[i]);
                    string material = currentRow[i + 1];

                    if (collectables.ContainsKey(material))
                    {
                        collectables[material] += quantity;
                    }
                    else
                    {
                        junk.Add(material, quantity);
                    }
                    obtainedItem = CheckQuantity(collectables);
                    if (obtainedItem != "")
                    {
                        quantityObtained = true;
                        break;
                    }
                }
            }
            Console.WriteLine($"{obtainedItem} obtained!");
            
            foreach (var item in collectables.OrderByDescending(q => q.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(j => j.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        private static string CheckQuantity(Dictionary<string, int> collection)
        {
            string obtainedItem = "";
            bool quantityObtained = false;

            foreach (var item in collection)
            {
                if (item.Value >= 250)
                {
                    quantityObtained = true;
                    switch (item.Key)
                    {
                        case "shards":
                            obtainedItem = "Shadowmourne";
                            collection[item.Key] = item.Value - 250;
                            break;
                        case "fragments":
                            obtainedItem = "Valanyr";
                            collection[item.Key] = item.Value - 250;
                            break;
                        case "motes":
                            obtainedItem = "Dragonwrath";
                            collection[item.Key] = item.Value - 250;
                            break;
                        default:
                            break;
                    }
                }
                if (quantityObtained)
                {
                    break;
                }
            }

            return obtainedItem;
        }
    }
}

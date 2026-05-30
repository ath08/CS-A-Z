using System;
using System.Text;


namespace ReceiptBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] enteredItems = new string[5];
            Console.WriteLine("Enter 5 items in this format: 'Apple,150,3'");

            for (int i = 0; i < enteredItems.Length; i++)
            {
                Console.Write($"Enter {i + 1} item: ");
                enteredItems[i] = Console.ReadLine();
            }

            string seperator = new string('=', 35);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(seperator);
            sb.AppendLine("RECEIPT");
            sb.AppendLine(seperator);

            int total = 0;

            foreach (string enterdItem in enteredItems)
            {
                string[] item = enterdItem.Split(',');
                string itemName = item[0].Trim();
                int itemPrice = int.Parse(item[1].Trim());
                int itemQuantity = int.Parse(item[2].Trim());

                int itemTotal = itemPrice * itemQuantity;
                total += itemTotal;

                string paddedName = itemName.PadRight(18);
                string paddedQuantityy = $"x{itemQuantity}".PadLeft(4);
                string paddedTotal = $"{itemTotal} AMD".PadLeft(9);

                sb.AppendLine($"{paddedName} {paddedQuantityy}  {paddedTotal}");

            }

            sb.AppendLine(seperator);
            sb.AppendLine($"{"TOTAL:".PadRight(22)}{$"{total} AMD".PadLeft(13)}");
            sb.AppendLine(seperator);

            string receipt = sb.ToString();
            Console.WriteLine();
            Console.WriteLine(receipt);
        }
    }
}

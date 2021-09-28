using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\..\InventoryItems.txt";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the text file into the List<InvItem> object.
            StreamReader readText =
                new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            while (readText.Peek() != -1)
            {
                string item = readText.ReadLine();
                string[] attributes = item.Split('|');
                InvItem invItem = new InvItem();

                invItem.ItemNo = Convert.ToInt32(attributes[0]);
                invItem.Description = attributes[1];
                invItem.Price = Convert.ToDecimal(attributes[2]);

                items.Add(invItem);

            }

            readText.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            StreamWriter writeText =
                new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (InvItem item in items)
            {
                writeText.Write(item.ItemNo + "|");
                writeText.Write(item.Description + "|");
                writeText.WriteLine(item.Price);
            }

            writeText.Close();
        }
    }
}


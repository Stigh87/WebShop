using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal interface GameItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public bool InStore { get; set; }
        public bool InDownload { get; set; }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}

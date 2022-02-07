using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal class PUBG : GameItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public bool InStore { get; set; }
        public bool InDownload { get; set; }

        public PUBG()
        {
            Id = 4;
            GameName = "PUBG";
            Price = 100;
            InStore = true;
            InDownload = true;
        }

        
    }
}

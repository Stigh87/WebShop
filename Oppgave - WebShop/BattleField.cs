using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal class BattleField : GameItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public bool InStore { get; set; }
        public bool InDownload { get; set; }

        public BattleField()
        {
            Id = 1;
            GameName = "BattleField";
            Price = 150;
            InStore = false;
            InDownload = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal class PokemonLetsGoEvee : GameItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public bool InStore { get; set; }
        public bool InDownload { get; set; }

        public PokemonLetsGoEvee()
        {
            Id = 3;
            GameName = "Pokemon Let`s GO Evee";
            Price = 400;
            InStore = true;
            InDownload = false;
        }
    }
}

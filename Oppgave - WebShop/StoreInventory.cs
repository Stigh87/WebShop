using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal class StoreInventory
    {
        public List<GameItem> InventoryList;

        public StoreInventory()
        {
            InventoryList = new List<GameItem>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }


        public List<GameItem> ListPhysicalItems()
        {
            var PhysicalItemsList = new List<GameItem>();
            foreach (var game in InventoryList)
            {
                if (game.InStore) PhysicalItemsList.Add(game);
            }
            return PhysicalItemsList;
            // for å finne alle elementene i InventoryList som selges i fysisk format
        }

        public List<GameItem> ListDownLoadable()
        {
            var DownloadItemsList = new List<GameItem>();
            foreach (var game in InventoryList)
            {
                if (game.InDownload) DownloadItemsList.Add(game);
            }
            return DownloadItemsList;
            // for å finne alle elementene som selges som downloadable content. 
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                foreach (var game in InventoryList)
                {
                    Console.WriteLine($@"ID: {game.Id} - {game.GameName} - {game.Price}");
                }
                //Print(InventoryList);
            }
            else if (command == "2")
            {
                foreach (var game in ListPhysicalItems())
                {
                    Console.WriteLine($@"ID: {game.Id} - {game.GameName} - {game.Price}");
                }
                //Print(ListPhysicalItems());
            }
            else
            {
                foreach (var game in ListDownLoadable())
                {
                    Console.WriteLine($@"ID: {game.Id} - {game.GameName} - {game.Price}");
                }
                //Print(ListDownLoadable());
            }
        }
    }
}

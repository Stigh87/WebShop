using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave___WebShop
{
    internal class WebShop
    {
        public StoreInventory Inventory { get; set; }
        public List<GameItem> ShoppingCart { get; set; }

        public WebShop()
        {
            Inventory = new StoreInventory();
            ShoppingCart = new List<GameItem>();

            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

                HandleCommand();
            }
        }

        

        private void HandleCommand()
        {
            var command = Console.ReadLine();
            Inventory.PrintInventory(command);
            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == Convert.ToInt32(gameID));
            ShoppingCart.Add(gameToBuy);
            Console.WriteLine("1 For Download");
            Console.WriteLine("2 For Shipping");
            var get = Convert.ToInt32(Console.ReadLine());
            
            if (get == 1 && gameToBuy.InDownload) PrintDownloadMessage(gameToBuy.GameName);
                else if (!gameToBuy.InDownload) printError(gameToBuy);
            if (get == 2 && gameToBuy.InStore) PrintShippingMessage(gameToBuy.GameName);
                else if (!gameToBuy.InStore) printError(gameToBuy);


            //Sjekk på om spillet skal shippes eller lastes ned
            //Print ut med Download eller shipping metoden under
        }

        private void printError(GameItem gameToBuy)
        {
            Console.WriteLine("Valgt fraktmetode er feil");
        }

        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }

    }
}

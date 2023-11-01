using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPaceCricketAcademyData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1: To Add Player");
                Console.WriteLine("2: To Remove Player by Id");
                Console.WriteLine("3: Get Player By Id");
                Console.WriteLine("4: Get Player by Name");
                Console.WriteLine("5: Get All Players");
                Console.WriteLine("6: Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerIdProperty = playerId,
                            PlayerNameProperty = playerName,
                            PlayerAgeProperty = playerAge
                        };

                        oneDayTeam.Add(newPlayer);
                        Console.WriteLine("Player added successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Player Id to remove: ");
                        int playerIdToRemove = Convert.ToInt32(Console.ReadLine());
                        oneDayTeam.Remove(playerIdToRemove);
                        Console.WriteLine("Player removed successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Player Id to retrieve: ");
                        int playerIdToRetrieve = Convert.ToInt32(Console.ReadLine());
                        Player playerById = oneDayTeam.GetPlayerById(playerIdToRetrieve);
                        Console.WriteLine(playerById != null ? playerById.PlayerNameProperty : "Player not found.");
                        break;

                    case 4:
                        Console.Write("Enter Player Name to retrieve: ");
                        string playerNameToRetrieve = Console.ReadLine();
                        Player playerByName = oneDayTeam.GetPlayerByName(playerNameToRetrieve);
                        Console.WriteLine(playerByName != null ? playerByName.PlayerIdProperty.ToString() : "Player not found.");
                        break;

                    case 5:
                        List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                        Console.WriteLine("All Players:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"ID: {player.PlayerIdProperty}, Name: {player.PlayerNameProperty}, Age: {player.PlayerAgeProperty}");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

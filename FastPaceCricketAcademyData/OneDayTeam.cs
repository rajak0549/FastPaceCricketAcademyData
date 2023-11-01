using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPaceCricketAcademyData
{
    internal class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {

        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(player => player.PlayerIdProperty == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(player => player.PlayerNameProperty == playerName);
        }

        public void Remove(int playerId)
        {

            Player playerToRemove = GetPlayerById(playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"It is removed {playerId}  id number Player ");
            }
        }
    }
}

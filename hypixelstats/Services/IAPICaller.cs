using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using hypixelstats.Model;
namespace hypixelstats.Services
{
    public interface IAPICaller
    {
        Task<Player> GetPlayer(string playerName);
    }
}

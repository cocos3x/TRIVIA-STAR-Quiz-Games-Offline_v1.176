using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesChatController : LeaguesServerController
    {
        // Fields
        private const string chat_index = "/chat/";
        private const string log_index = "/log/";
        
        // Methods
        public void GetGuildLog(SLC.Social.Profile myself, SLC.Social.Leagues.Guild guild, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            string val_2 = 804185568 + 13152256 + 804185680;
        }
        public void GetGuildChat(SLC.Social.Profile myself, int guildServerId, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  804185472, value:  13152256);
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_3 = 0.MyGuild;
            Add(key:  1348647040, value:  13152256);
            string val_4 = 804185568 + 13152256 + 804318240;
        }
        public void SendChat(SLC.Social.Profile myself, SLC.Social.Leagues.Guild guild, string messageToPost, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback, System.Action<string> onRequestFails)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(null != 0)
            {
                    Add(key:  804185472, value:  13152256);
            }
            else
            {
                    Add(key:  804185472, value:  13152256);
            }
            
            Add(key:  1495692992, value:  messageToPost);
            string val_2 = 804185568 + 13152256 + 804318240;
        }
        public LeaguesChatController()
        {
        
        }
    
    }

}

using UnityEngine;

namespace SLC.Social.Leagues
{
    public class GuildMessage
    {
        // Fields
        public string message;
        public System.DateTime sentAt;
        public SLC.Social.Profile sender;
        
        // Methods
        public GuildMessage(string message, System.DateTime sentAt)
        {
            var val_2;
            string val_1 = message;
            val_2 = null;
            val_2 = null;
            this.sentAt = System.DateTime.MinValue;
            val_1 = new System.Object();
            this.sentAt = sentAt;
            mem[1152921514030213364] = R3;
            this.message = val_1;
        }
        public GuildMessage(string message, System.DateTime sentAt, SLC.Social.Profile sender)
        {
            var val_2;
            SLC.Social.Profile val_1 = sender;
            val_2 = null;
            val_2 = null;
            this.sentAt = System.DateTime.MinValue;
            val_1 = new System.Object();
            this.message = message;
            this.sentAt = sentAt;
            mem[1152921514030337652] = R3;
            this.sender = val_1;
        }
    
    }

}

using UnityEngine;
public class ChallengeFriendController.ChallengeFriendPacket
{
    // Fields
    public string category;
    public string subcategory;
    public System.TimeSpan timespan;
    public int difficultyLevel;
    public System.Collections.Generic.List<string> questionIDs;
    public string challengerSupportId;
    
    // Methods
    public string Serialize()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1481867152);
    }
    public ChallengeFriendController.ChallengeFriendPacket()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.questionIDs = null;
    }
    public ChallengeFriendController.ChallengeFriendPacket(string serialized)
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.questionIDs = null;
        object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  serialized);
        if(serialized != null)
        {
                this.category = serialized.m_stringLength;
            this.subcategory = serialized.m_firstChar;
            mem[1152921511715143556] = public static ChallengeFriendPacket Newtonsoft.Json.JsonConvert::DeserializeObject<ChallengeFriendPacket>(string value);
            this.timespan = serialized.m_firstChar;
            this.difficultyLevel = serialized.m_firstChar;
        }
        else
        {
                this.category = 0;
            this.subcategory = 0;
            this.timespan = 4297588739;
            this.difficultyLevel = 0;
        }
        
        this.questionIDs = null;
        this.challengerSupportId = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
    }

}

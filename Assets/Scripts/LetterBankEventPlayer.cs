using UnityEngine;
public class LetterBankEventPlayer
{
    // Fields
    public int guildMemberId;
    public string name;
    public int score;
    public int avatarId;
    public string facebookId;
    public bool useFacebook;
    public bool isMe;
    
    // Methods
    public SLC.Social.Profile ToProfile()
    {
        string val_3;
        if(new SLC.Social.Profile() != 0)
        {
                typeof(SLC.Social.Profile).__il2cppRuntimeField_8 = this.guildMemberId;
            val_3 = this.name;
        }
        else
        {
                mem[8] = this.guildMemberId;
            val_3 = this.name;
        }
        
        typeof(SLC.Social.Profile).__il2cppRuntimeField_C = val_3;
        if(this.isMe != false)
        {
                SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
        {
                return 0.MyProfile;
        }
        
            return 0.MyProfile;
        }
        
        typeof(SLC.Social.Profile).__il2cppRuntimeField_24 = this.avatarId;
        typeof(SLC.Social.Profile).__il2cppRuntimeField_28 = this.facebookId;
        typeof(SLC.Social.Profile).__il2cppRuntimeField_2C = this.useFacebook;
    }
    public LetterBankEventPlayer()
    {
        this.avatarId = 0;
        this.guildMemberId = 0;
        this.name = "Default Dodo";
    }

}

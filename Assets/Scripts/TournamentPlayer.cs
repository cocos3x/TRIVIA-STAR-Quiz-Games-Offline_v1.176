using UnityEngine;
public class TournamentPlayer
{
    // Fields
    public string name;
    public int score;
    public int avatarId;
    public string facebookId;
    public bool useFacebook;
    public bool isMe;
    
    // Methods
    public SLC.Social.Profile ToProfile()
    {
        SLC.Social.Profile val_1 = new SLC.Social.Profile();
        typeof(SLC.Social.Profile).__il2cppRuntimeField_C = this.name;
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
    public TournamentPlayer()
    {
        this.avatarId = 0;
        this.name = "Default Dodo";
    }

}

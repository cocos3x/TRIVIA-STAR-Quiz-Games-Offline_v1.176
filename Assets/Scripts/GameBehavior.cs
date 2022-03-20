using UnityEngine;
public class GameBehavior
{
    // Fields
    private GameplayBehavior <gameplayBehavior>k__BackingField;
    private MetaGameBehavior <metaGameBehavior>k__BackingField;
    private HackBehavior <hackBehavior>k__BackingField;
    
    // Properties
    public GameplayBehavior gameplayBehavior { get; set; }
    public MetaGameBehavior metaGameBehavior { get; set; }
    public HackBehavior hackBehavior { get; set; }
    
    // Methods
    public GameplayBehavior get_gameplayBehavior()
    {
    
    }
    private void set_gameplayBehavior(GameplayBehavior value)
    {
        this.<gameplayBehavior>k__BackingField = value;
    }
    public MetaGameBehavior get_metaGameBehavior()
    {
    
    }
    private void set_metaGameBehavior(MetaGameBehavior value)
    {
        this.<metaGameBehavior>k__BackingField = value;
    }
    public HackBehavior get_hackBehavior()
    {
    
    }
    private void set_hackBehavior(HackBehavior value)
    {
        this.<hackBehavior>k__BackingField = value;
    }
    public GameBehavior(WordGames.GameNames name)
    {
        HackBehavior val_15;
        if(name > 4)
        {
            goto label_1;
        }
        
        if((name == 1) || (name != 4))
        {
            goto label_7;
        }
        
        this.<gameplayBehavior>k__BackingField = new WUTGameplayBehavior();
        this.<metaGameBehavior>k__BackingField = new WUTMetaGameBehavior();
        WUTHackBehavior val_3 = null;
        val_15 = val_3;
        val_3 = new WUTHackBehavior();
        goto label_8;
        label_1:
        GameNames val_4 = name - 9;
        if(val_4 > 12)
        {
            goto label_5;
        }
        
        var val_5 = 13055788 + (13055788 + ((name - 9)) << 2);
        if(val_4 == 12)
        {
                mem2[0] = 13055788 + ((name - 9)) << 2 + IP;
            mem2[0] = 13055788 + ((name - 9)) << 2 + IP + IP;
            mem2[0] = 13055788 + ((name - 9)) << 2 + IP + IP + IP;
            mem2[0] = (13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP;
            mem2[0] = (13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP;
            mem2[0] = (13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP;
            ((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2)) = (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) >> 3);
            ((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2)) = (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) >> 4);
            ((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2)) = (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) << 5);
            ((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2)) = (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) & ((((((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP & (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name ) << (32-5)) | (((((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP & (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name ) << 5));
            ((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2)) = (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) & ((((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << (32-2)) | (((13055788 + ((name - 9)) << 2 + IP + IP + IP & (this) >> 13055788 + ((name - 9)) << 2 + IP + IP + IP) + IP + IP + IP) << 2))) >> 6);
        }
        
        this.<gameplayBehavior>k__BackingField = new WPTGameplayBehavior();
        this.<metaGameBehavior>k__BackingField = new WPTMetaGameBehavior();
        WPTHackBehavior val_8 = null;
        val_15 = val_8;
        val_8 = new WPTHackBehavior();
        goto label_8;
        label_5:
        if(name != 99)
        {
            goto label_7;
        }
        
        this.<gameplayBehavior>k__BackingField = new WOLGameplayBehavior();
        this.<metaGameBehavior>k__BackingField = new WOLMetaGameBehavior();
        WOLHackBehavior val_11 = null;
        val_15 = val_11;
        val_11 = new WOLHackBehavior();
        goto label_8;
        label_7:
        this.<gameplayBehavior>k__BackingField = new WADGameplayBehavior();
        this.<metaGameBehavior>k__BackingField = new WADMetaGameBehavior();
        WADHackBehavior val_14 = null;
        val_15 = val_14;
        val_14 = new WADHackBehavior();
        label_8:
        this.<hackBehavior>k__BackingField = val_15;
    }
    public virtual bool RandomizedChallengeParsing()
    {
        return true;
    }

}

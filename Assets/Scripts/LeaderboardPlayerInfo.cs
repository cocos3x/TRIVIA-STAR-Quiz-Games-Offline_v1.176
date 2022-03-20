using UnityEngine;
public class LeaderboardPlayerInfo
{
    // Fields
    private int <rank>k__BackingField;
    private string <name>k__BackingField;
    private int <apples>k__BackingField;
    private int <avatar>k__BackingField;
    private string <fbid>k__BackingField;
    
    // Properties
    public virtual int rank { get; set; }
    public virtual string name { get; set; }
    public virtual int apples { get; set; }
    public virtual int avatar { get; set; }
    public virtual string fbid { get; set; }
    
    // Methods
    public virtual int get_rank()
    {
        return (int)this.<rank>k__BackingField;
    }
    public virtual void set_rank(int value)
    {
        this.<rank>k__BackingField = value;
    }
    public virtual string get_name()
    {
    
    }
    public virtual void set_name(string value)
    {
        this.<name>k__BackingField = value;
    }
    public virtual int get_apples()
    {
        return (int)this.<apples>k__BackingField;
    }
    public virtual void set_apples(int value)
    {
        this.<apples>k__BackingField = value;
    }
    public virtual int get_avatar()
    {
        return (int)this.<avatar>k__BackingField;
    }
    public virtual void set_avatar(int value)
    {
        this.<avatar>k__BackingField = value;
    }
    public virtual string get_fbid()
    {
    
    }
    public virtual void set_fbid(string value)
    {
        this.<fbid>k__BackingField = value;
    }
    public LeaderboardPlayerInfo()
    {
    
    }

}

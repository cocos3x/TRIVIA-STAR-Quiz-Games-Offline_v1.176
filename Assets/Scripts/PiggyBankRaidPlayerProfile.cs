using UnityEngine;
public class PiggyBankRaidPlayerProfile : EncodableModel
{
    // Fields
    public string userId;
    public int avatarId;
    public string name;
    public int bankLevel;
    public decimal coins;
    private bool isDummyAccount;
    private bool <autoCreated>k__BackingField;
    
    // Properties
    public bool IsDummyAccount { get; set; }
    protected bool autoCreated { get; set; }
    
    // Methods
    public bool get_IsDummyAccount()
    {
        if(this.isDummyAccount == false)
        {
                this.isDummyAccount = this.<autoCreated>k__BackingField;
            return System.String.IsNullOrEmpty(value:  this.userId);
        }
        
        return true;
    }
    public void set_IsDummyAccount(bool value)
    {
        this.isDummyAccount = value;
    }
    protected void set_autoCreated(bool value)
    {
        this.<autoCreated>k__BackingField = value;
    }
    protected bool get_autoCreated()
    {
        return (bool)this.<autoCreated>k__BackingField;
    }
    public override void Decode(System.Collections.Generic.Dictionary<string, object> dict, EncodableModel.TemplateModel sourceModel = 0)
    {
        this.Decode(jasonObject:  dict, sourceModel:  0);
        if((dict.ContainsKey(key:  -1116517696)) == false)
        {
                return;
        }
        
        object val_2 = dict.Item[-1116517696];
        string val_3 = dict.ToString();
        bool val_5 = System.Boolean.TryParse(value:  dict, result: out  bool val_4 = true);
        if(val_5 == true)
        {
                val_5 = 0;
            this.<autoCreated>k__BackingField = false;
        }
    
    }
    public PiggyBankRaidPlayerProfile()
    {
        this.name = "Player";
        this.bankLevel = 1;
    }

}

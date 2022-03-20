using UnityEngine;
public class WGProgressiveIAPHandler : TRVProgressiveIAPHandler
{
    // Fields
    private const string pref_highest_purchse = "php";
    private float playerHighestPurchase;
    
    // Methods
    protected override void GenerateExtraNewData(ref System.Collections.Generic.Dictionary<string, object> eventDataToSave)
    {
        this.GenerateExtraNewData(eventDataToSave: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = -583515664);
        Player val_2 = App.Player;
        this.playerHighestPurchase = 8.407791E-45f;
        Player val_3 = App.Player;
        eventDataToSave.Add(key:  -583571744, value:  15282176);
    }
    protected override void LoadExtraPersistentData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        this.LoadExtraPersistentData(eventData:  eventData);
        if((eventData.ContainsKey(key:  -583571744)) == false)
        {
                return;
        }
        
        object val_2 = eventData.Item[-583571744];
        string val_3 = eventData.ToString();
        bool val_5 = System.Single.TryParse(s:  eventData, result: out  this.playerHighestPurchase);
    }
    protected override void SaveExtraData(ref System.Collections.Generic.Dictionary<string, object> myEventData)
    {
        this.SaveExtraData(myEventData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = -583275440);
        if((this.GetCurrentTier(calculatedProgress:  -583275440)) > 0)
        {
                return;
        }
        
        Player val_3 = App.Player;
        35630686 = 0;
        this.playerHighestPurchase = 8.407791E-45f;
        Player val_4 = App.Player;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  myEventData, key:  -583571744, newValue:  15282176);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_6;
        DG.Tweening.TweenCallback val_8;
        bool val_6 = true;
        val_6 = val_6 + levelsProgressed;
        mem[1152921512613591196] = val_6;
        this.SaveData();
        PurchaseModel val_1 = this.GetCurrentPurchaseModel(tierOverride:  0);
        bool val_2 = this.EventCompleted();
        if(val_2 == true)
        {
                return;
        }
        
        int val_3 = System.Linq.Enumerable.Sum(source:  val_2);
        if(levelsProgressed > val_3)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = WGProgressiveIAPHandler.<>c.<>9__5_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new DG.Tweening.TweenCallback(object:  WGProgressiveIAPHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3711751872));
            WGProgressiveIAPHandler.<>c.<>9__5_0 = val_8;
        }
        
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1070386381, ignoreTimeScale:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -583102288, defaultValue:  -583102400, useSingularKey:  false);
    }
    public override string EventContentItemButtonText()
    {
        return Localization.Localize(key:  -583102288, defaultValue:  -583102400, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -583102288, defaultValue:  -583102400, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -582766080, defaultValue:  -582766160, useSingularKey:  false);
    }
    public override void ShowSalePopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void HackAddLevels(int levelsHacked)
    {
        levelsHacked = R2 + levelsHacked;
        mem[1152921512614264636] = levelsHacked;
    }
    protected override int GetCurrentTierIAPIndex(int tier)
    {
        if(<0)
        {
                9 = 6;
        }
        
        val_1 = tier + val_1;
        val_1 = val_1 - 3;
        return (int)val_1;
    }
    private int GetOfferGroupIndex(float highestPurchasePrice)
    {
        if()
        {
                this = 1;
            return (int)this;
        }
        
        if(<0)
        {
                3 = 2;
        }
        
        return 2;
    }
    public WGProgressiveIAPHandler()
    {
    
    }

}

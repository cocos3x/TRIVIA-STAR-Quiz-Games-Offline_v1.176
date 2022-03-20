using UnityEngine;
public abstract class FPHPowerupButton : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Text labelCost;
    protected FPHEcon econ;
    protected UnityEngine.UI.Button button;
    
    // Properties
    protected abstract int Cost { get; }
    protected abstract string TrackingSource { get; }
    
    // Methods
    protected abstract int get_Cost(); // 0
    protected abstract string get_TrackingSource(); // 0
    protected virtual void Awake()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        this.econ = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        object val_2 = this.GetComponent<System.Object>();
        this.button = this;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1619014912, method:  typeof(FPHPowerupButton).__il2cppRuntimeField_100);
        this.AddListener(call:  162246656);
        string val_4 = this.ToString();
        if(this.labelCost != 0)
        {
                return;
        }
    
    }
    public virtual void Initialize()
    {
    
    }
    protected virtual void OnButtonClick()
    {
        var val_13;
        var val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2114052032) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
        }
        
        Player val_4 = App.Player;
        if(0 < this)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 126;
            if((-1618810816) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static FPHPhraseOfTheDayController MonoSingleton<FPHPhraseOfTheDayController>::get_Instance().__il2cppRuntimeField_C + 8) == 0)
        {
                val_13 = 126;
        }
        
        }
        
            var val_13 = 28489505;
            val_13 = 7136556 + val_13;
            if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
            val_14 = null;
            val_14 = null;
            PurchaseProxy.currentPurchasePoint = 126;
            string val_8 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
            GameStoreManager.StoreCategoryFocus = "gems_upper";
            GameBehavior val_9 = App.getBehavior;
            0.Init(outOfCredits:  true, onCloseAction:  0);
            return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        FPHGameplayController val_11 = FPHGameplayController.Instance;
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1618785680, aName:  -1618809792);
    }
    protected abstract bool ExecutePowerup(); // 0
    protected FPHPowerupButton()
    {
    
    }

}

using UnityEngine;
public class UnlockableUILeagues : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.GameObject exclamationPoint;
    
    // Properties
    protected override bool FeatureHidden { get; }
    protected override int UnlockLevel { get; }
    
    // Methods
    private void Awake()
    {
        null = null;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -158421312, method:  new IntPtr(4136520960));
        WordApp.DeferredGameUIReadyEvent.AddListener(call:  162246656);
    }
    protected override bool get_FeatureHidden()
    {
        var val_7;
        var val_8;
        GameEcon val_1 = App.getGameEcon;
        if(1113 >= 0)
        {
                Player val_2 = App.Player;
            GameEcon val_3 = App.getGameEcon;
            val_7 = 5614709;
            val_8 = 0;
            if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  5614709)) == true)
        {
                return (bool)val_8;
        }
        
            Player val_5 = App.Player;
            GameEcon val_6 = App.getGameEcon;
            val_7 = 0;
            if(0 < 1113)
        {
                val_8 = 1;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    protected override int get_UnlockLevel()
    {
        if(this.exclamationPoint != 0)
        {
                Player val_2 = App.Player;
            GameEcon val_3 = App.getGameEcon;
            if(0 >= 5614709)
        {
                0 = 1;
        }
        
            this.exclamationPoint.SetActive(value:  true);
        }
        
        GameEcon val_4 = App.getGameEcon;
        if(0 != 0)
        {
                return 5614709;
        }
        
        return 5614709;
    }
    private void WordAppStartedEvent()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        Player val_3 = App.Player;
        GameEcon val_4 = App.getGameEcon;
        1152921504892043264 = 0;
        if(0 < 5614709)
        {
                return;
        }
        
        if((CPlayerPrefs.GetBool(key:  -158092928, defaultValue:  false)) != false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_6 = this.playUnlockAnimation();
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -158068816);
    }
    private System.Collections.IEnumerator playUnlockAnimation()
    {
        object val_1 = new System.Object();
        typeof(UnlockableUILeagues.<playUnlockAnimation>d__7).__il2cppRuntimeField_8 = 0;
        typeof(UnlockableUILeagues.<playUnlockAnimation>d__7).__il2cppRuntimeField_10 = this;
    }
    public UnlockableUILeagues()
    {
    
    }

}

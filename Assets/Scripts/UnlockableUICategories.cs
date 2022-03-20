using UnityEngine;
public class UnlockableUICategories : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.GameObject badgeNew;
    
    // Properties
    private bool CanShowUnlockedTooltip { get; set; }
    protected override bool FeatureHidden { get; }
    protected override int UnlockLevel { get; }
    
    // Methods
    private bool get_CanShowUnlockedTooltip()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -162007408, defaultValue:  0);
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_CanShowUnlockedTooltip(bool value)
    {
        value = value ^ 1;
        UnityEngine.PlayerPrefs.SetInt(key:  -162007408, value:  value);
    }
    protected override bool get_FeatureHidden()
    {
        var val_9;
        var val_10;
        var val_11;
        GameEcon val_1 = App.getGameEcon;
        if(0 >= 0)
        {
                GameBehavior val_2 = App.getBehavior;
            val_9 = 1;
            if(0 != 0)
        {
                val_9 = CategoryPacksManager.FeatureAvailable ^ 1;
        }
        
            Player val_4 = App.Player;
            Player val_5 = App.Player;
            GameEcon val_6 = App.getGameEcon;
            if(0 < 0)
        {
                val_10 = 1;
        }
        
            if((0 < this) && (0 >= 0))
        {
                GameEcon val_7 = App.getGameEcon;
            val_10 = 249 ^ 1;
        }
        
            if(0 != 0)
        {
                val_11 = 1;
        }
        
            return (bool)val_11;
        }
        
        val_11 = 1;
        return (bool)val_11;
    }
    protected override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 1179681;
        }
        
        return 1179681;
    }
    protected override void UpdateButton()
    {
        if(true != 3)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = this.badgeNew.activeSelf;
        val_2 = 1 ^ val_2;
        if(val_2 != true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.badgeNew.SetActive(value:  true);
    }
    protected override void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
        if(newState != 3)
        {
                return;
        }
        
        if(this.CanShowUnlockedTooltip == false)
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  -161401776, method:  new IntPtr(4133540496));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -161401776, callback:  7454720);
    }
    protected override void OnClickUnlocked()
    {
        var val_1;
        var val_1 = 28016839;
        val_1 = 7608952 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 61;
        CategoryPacksMenuUI.ShowMainScreen();
    }
    public UnlockableUICategories()
    {
    
    }
    private void <SetNewState>b__9_0()
    {
        string val_1 = Localization.Localize(key:  -161085568, defaultValue:  -161085680, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.GameObject val_4 = R7.gameObject;
        if(this != 0)
        {
                this = 1;
        }
        
        ShowToolTip(objToToolTip:  R7, text:  -161085568, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
        CanShowUnlockedTooltip = false;
    }

}

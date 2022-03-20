using UnityEngine;
private sealed class DailyChallengeTutorialLobbyHelper.<WaitAndShowOverlay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DailyChallengeTutorialLobbyHelper <>4__this;
    public System.Collections.Generic.List<UnityEngine.Transform> overlayContents;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DailyChallengeTutorialLobbyHelper.<WaitAndShowOverlay>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        object val_16;
        DynamicToolTip val_17;
        var val_18;
        float val_19;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_15 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_16 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_15 = 1;
        this.<>1__state = val_15;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        GameBehavior val_2 = App.getBehavior;
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            goto label_11;
        }
        
        val_15 = 0;
        UnityEngine.GameObject val_4 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_15;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_5 = null;
        val_16 = val_5;
        val_5 = new UnityEngine.WaitForEndOfFrame();
        val_15 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_16;
        return (bool)val_15;
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = PlaceGameObject<System.Object>(loc:  0);
        val_17 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        if((this.<>4__this) != 0)
        {
                val_18 = this.<>4__this;
            this.<>4__this.TT = val_17;
        }
        else
        {
                val_18 = 20;
            mem[20] = val_17;
            val_17 = mem[20];
        }
        
        UnityEngine.GameObject val_8 = gameObject;
        if((this.<>4__this) != 0)
        {
            
        }
        else
        {
                val_19 = mem[20];
        }
        
        UnityEngine.GameObject val_9 = this.<>4__this.dailyChallengeButton.gameObject;
        string val_10 = Localization.Localize(key:  -1442298224, defaultValue:  -1442298128, useSingularKey:  false);
        ShowToolTip(objToToolTip:  this.<>4__this.dailyChallengeButton, text:  -1442298224, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1132068864, showPick:  false, maxFontSize:  1092616192);
        UnityEngine.GameObject val_11 = gameObject;
        UnityEngine.Transform val_12 = transform;
        this.overlayContents.Add(item:  -2009104640);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_14 = this.overlayContents.ToArray();
        ShowOverlay(contentToOverlay:  this.overlayContents);
        return (bool)val_15;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}

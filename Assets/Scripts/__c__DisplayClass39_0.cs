using UnityEngine;
private sealed class IslandParadiseProgressPopup.<>c__DisplayClass39_0
{
    // Fields
    public System.Action onComplete;
    public UnityEngine.GameObject newRewardGroup;
    public IslandParadiseProgressPopup <>4__this;
    
    // Methods
    public IslandParadiseProgressPopup.<>c__DisplayClass39_0()
    {
    
    }
    internal void <PlayRewardSequence>b__0()
    {
        this.onComplete.Invoke();
        UnityEngine.GameObject val_1 = this.newRewardGroup.gameObject;
        UnityEngine.Object.Destroy(obj:  this.newRewardGroup);
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}

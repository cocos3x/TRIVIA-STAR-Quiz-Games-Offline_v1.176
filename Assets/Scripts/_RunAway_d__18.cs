using UnityEngine;
private sealed class WPTPetTile.<RunAway>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTPetTile <>4__this;
    private UnityEngine.Vector3 <targetPos>5__2;
    private float <runDuration>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTPetTile.<RunAway>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        var val_19;
        int val_24;
        object val_25;
        val_24 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_24;
        }
        
        var val_1 = 13001752 + (13001752 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                13001752 + (this.<>1__state) << 2 = (13001752 + (this.<>1__state) << 2) & (this << (13001752 + (this.<>1__state) << 2));
            13001752 + (this.<>1__state) << 2 = (13001752 + (this.<>1__state) << 2) & ((13001752 + (this.<>1__state) << 2) >> (13001752 + (this.<>1__state) << 2));
            mem2[0] = ((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2) & ((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2)) >> (13001752 + (this.<>1__state + this;
            (((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2) & ((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2)) >> (13001752 + (this.<>1__state + this) & ((IP) << 3) = ((((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2) & ((13001752 + (this.<>1__state) << 2 & (this) << 13001752 + (this.<>1__state) << 2)) >> (13001752 + (this.<>1__state + this) & ((IP) << 3)) & 24821710;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.Reset();
        }
        else
        {
                0.Reset();
        }
        
        UnityEngine.Transform val_8 = this.<>4__this.myText.transform;
        UnityEngine.Transform val_9 = this.<>4__this.myText.parent;
        UnityEngine.GameObject val_10 = this.<>4__this.myText.gameObject;
        this.<>4__this.myText.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_12 = localPosition;
        UnityEngine.Transform val_13 = this.<>4__this.transform;
        UnityEngine.Vector3 val_14 = localPosition;
        float val_24 = System.Math.Abs(val_15 - S16);
        UnityEngine.Transform val_17 = this.<>4__this.transform;
        val_24 = val_24 / (this.<>4__this.fallingSpeed);
        UnityEngine.Vector3 val_18 = localPosition;
        var val_25 = val_19;
        val_25 = (this.<targetPos>5__2) - val_25;
        float val_26 = System.Math.Abs(val_25);
        val_26 = val_26 / (this.<>4__this.runningSpeed);
        this.<runDuration>5__3 = val_26;
        this.<>4__this.<myPet>k__BackingField.AnimateFall();
        UnityEngine.Transform val_20 = this.<>4__this.transform;
        DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.<>4__this, endValue:  val_26, duration:  val_18.y, snapping:  false);
        object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this, ease:  2);
        UnityEngine.WaitForSeconds val_23 = null;
        val_25 = val_23;
        val_23 = new UnityEngine.WaitForSeconds(seconds:  val_26);
        val_24 = 1;
        this.<>1__state = val_24;
        this.<>2__current = val_25;
        return (bool)val_24;
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

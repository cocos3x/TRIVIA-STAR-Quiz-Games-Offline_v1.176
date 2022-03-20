using UnityEngine;
private sealed class WPTPetTile.<AnimateCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTPetTile <>4__this;
    public UnityEngine.Vector3 targetFlyToPos;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTPetTile.<AnimateCapture>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_16;
        var val_21;
        int val_29;
        object val_30;
        var val_32;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 12999336 + (12999336 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                12999336 + (this.<>1__state) << 2 = (12999336 + (this.<>1__state) << 2) & ((12999336 + (this.<>1__state) << 2) << (12999336 + (this.<>1__state) << 2));
            12999336 + (this.<>1__state) << 2 = (12999336 + (this.<>1__state) << 2) & (this >> (12999336 + (this.<>1__state) << 2));
            12999336 + (this.<>1__state) << 2 = (12999336 + (this.<>1__state) << 2) & ((IP) >> 1);
            12999336 + (this.<>1__state) << 2 = (12999336 + (this.<>1__state) << 2) & (((int)IP) >> 3);
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        this.<>4__this.Reset();
        goto label_3;
        label_1:
        val_29 = 0;
        return (bool)val_29;
        label_2:
        0.Reset();
        label_3:
        UnityEngine.Transform val_11 = this.<>4__this.myText.transform;
        UnityEngine.Transform val_12 = this.<>4__this.myText.parent;
        UnityEngine.GameObject val_13 = this.<>4__this.myText.gameObject;
        this.<>4__this.myText.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_15 = localPosition;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_18 = localPosition;
        UnityEngine.Transform val_19 = this.<>4__this.transform;
        UnityEngine.Vector3 val_20 = localPosition;
        float val_29 = System.Math.Abs(val_21 - val_16);
        UnityEngine.Transform val_23 = this.<>4__this.transform;
        val_29 = val_29 / (this.<>4__this.fallingSpeed);
        val_32 = 0;
        UnityEngine.Vector3 val_24 = localPosition;
        this.<>4__this.<myPet>k__BackingField.AnimateFall();
        UnityEngine.Transform val_25 = this.<>4__this.transform;
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.<>4__this, endValue:  val_24.x, duration:  val_24.y, snapping:  val_16);
        object val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this, ease:  2);
        UnityEngine.WaitForSeconds val_28 = null;
        val_30 = val_28;
        val_28 = new UnityEngine.WaitForSeconds(seconds:  val_24.x);
        val_29 = 1;
        this.<>1__state = val_29;
        this.<>2__current = val_30;
        return (bool)val_29;
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

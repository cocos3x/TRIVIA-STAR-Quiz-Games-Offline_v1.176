using UnityEngine;
private sealed class WPTPetTile.<FlyAway>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTPetTile <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTPetTile.<FlyAway>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_8;
        var val_11;
        int val_17 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.Reset();
        goto label_5;
        label_1:
        this.<>1__state = 0;
        return (bool)val_17;
        label_2:
        this.<>1__state = 2;
        val_17 = 1;
        this.<>2__current = 0;
        return (bool)val_17;
        label_4:
        0.Reset();
        label_5:
        UnityEngine.Transform val_1 = this.<>4__this.myText.transform;
        UnityEngine.Transform val_2 = this.<>4__this.myText.parent;
        UnityEngine.GameObject val_3 = this.<>4__this.myText.gameObject;
        this.<>4__this.myText.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_5 = localPosition;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.688998E-32f}, b:  new UnityEngine.Vector3() {y = val_6.x, z = val_6.y});
        UnityEngine.Transform val_9 = this.<>4__this.transform;
        UnityEngine.Vector3 val_10 = localPosition;
        var val_19 = val_11;
        float val_18 = 0.5f;
        val_18 = (this.<>4__this.fallingSpeed) * val_18;
        val_19 = (System.Math.Abs(val_19 - val_8)) / val_18;
        this.<>4__this.<myPet>k__BackingField.AnimateFall();
        UnityEngine.Transform val_13 = this.<>4__this.transform;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.<>4__this, endValue:  val_18, duration:  val_10.y, snapping:  val_8);
        object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this, ease:  5);
        val_17 = 1;
        this.<>1__state = val_17;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_18);
        return (bool)val_17;
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

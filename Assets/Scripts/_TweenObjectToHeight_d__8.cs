using UnityEngine;
private sealed class SlotMachineReel.<TweenObjectToHeight>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject reelObject;
    public float targetHeight;
    public int extraRounds;
    public SlotMachineReel <>4__this;
    public System.Action callBack;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SlotMachineReel.<TweenObjectToHeight>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_4;
        int val_37;
        float val_38;
        UnityEngine.GameObject val_39;
        val_37 = 0;
        if((this.<>1__state) > 5)
        {
                return (bool);
        }
        
        var val_1 = 15863192 + (15863192 + (this.<>1__state) << 2);
        if((this.<>1__state) == 5)
        {
                15863192 + (this.<>1__state) << 2 = (15863192 + (this.<>1__state) << 2) & ((R8) << 15863192 + (this.<>1__state) << 2);
            15863192 + (this.<>1__state) << 2 = (15863192 + (this.<>1__state) << 2) & (-1519712656);
            15863192 + (this.<>1__state) << 2 = R8 * 15863192;
            15863192 + (this.<>1__state) << 2 = (15863192 + (this.<>1__state) << 2) & ((IP) << R2);
            15863192 + (this.<>1__state) << 2 = (15863192 + (this.<>1__state) << 2) & (this >> R3);
            15863192 + (this.<>1__state) << 2 = (15863192 + (this.<>1__state) << 2) & ((R8) << this);
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.reelObject.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Transform val_5 = this.reelObject.transform;
        UnityEngine.Transform val_6 = this.reelObject.transform;
        val_38 = 0;
        UnityEngine.Vector3 val_7 = localPosition;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.reelObject, endValue:  0.5f, duration:  val_7.y, snapping:  val_4);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.reelObject, ease:  14);
        UnityEngine.WaitForSeconds val_10 = null;
        val_39 = val_10;
        val_10 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        val_37 = 1;
        this.<>1__state = val_37;
        this.<>2__current = val_39;
        return (bool);
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

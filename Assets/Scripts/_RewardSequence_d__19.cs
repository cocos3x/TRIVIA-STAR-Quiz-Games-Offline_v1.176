using UnityEngine;
private sealed class KeyToRichesChest.<RewardSequence>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public KeyToRichesChest <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KeyToRichesChest.<RewardSequence>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_25;
        var val_26;
        object val_27;
        val_25 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool);
        }
        
        var val_1 = 11512524 + (11512524 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                11512524 + (this.<>1__state) << 2 = (11512524 + (this.<>1__state) << 2) & (this << (11512524 + (this.<>1__state) << 2));
            11512524 + (this.<>1__state) << 2 = (11512524 + (this.<>1__state) << 2) & 733469964;
            11512524 + (this.<>1__state) << 2 = (11512524 + (this.<>1__state) << 2) & (((int)R8) >> R2);
            11512524 + (this.<>1__state) << 2 = (11512524 + (this.<>1__state) << 2) & ((11512524 + (this.<>1__state) << 2) << 5);
            mem2[0] = ((((11512524 + (this.<>1__state) << 2 & (this) << 11512524 + (this.<>1__state) << 2) & 733469964) & ((int)R8) >> R2) & ((((11512524 + (this.<>1__state) << 2 & (this) << 11512524 + (this.<>1__state) << + ((((11512524 + (this.<>1__state) << 2 & (this) << 11512524 + (this.<>1__state) << 2) & 733469964) & ((int)R8) >> R2) & ((((11512524 + (this.<>1__state) << 2 & (this) << 11512524 + (this.<>1__state) <<;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.<>4__this.glowingKeyGO.transform;
        UnityEngine.Transform val_3 = this.<>4__this.keyPosOrigin.transform;
        val_26 = 0;
        UnityEngine.Vector3 val_4 = position;
        this.<>4__this.glowingKeyGO.position = new UnityEngine.Vector3();
        PluginExtension.SetColorAlpha(graphic:  this.<>4__this.glowingKey, a:  val_4.x);
        val_25 = 1;
        this.<>4__this.glowingKeyGO.SetActive(value:  true);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.glowingKey, endValue:  val_4.x, duration:  val_4.y);
        UnityEngine.WaitForSeconds val_6 = null;
        val_27 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_4.x);
        this.<>1__state = val_25;
        this.<>2__current = val_27;
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

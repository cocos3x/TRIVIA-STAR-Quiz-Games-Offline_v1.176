using UnityEngine;
private sealed class WADMysteryGiftPopup.<CoinStageAnim>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WADMysteryGiftPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WADMysteryGiftPopup.<CoinStageAnim>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        object val_19;
        val_18 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool);
        }
        
        var val_1 = 7696852 + (7696852 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                7696852 + (this.<>1__state) << 2 = (7696852 + (this.<>1__state) << 2) & (this << (7696852 + (this.<>1__state) << 2));
            7696852 + (this.<>1__state) << 2 = (7696852 + (this.<>1__state) << 2) & ((IP) >> 7696852);
            7696852 + (this.<>1__state) << 2 = 4668962535802162880;
            7696852 + (this.<>1__state) << 2 = R8 * R2;
            7696852 + (this.<>1__state) << 2 = (7696852 + (this.<>1__state) << 2) & ((IP) << 7);
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_2 = val_18.gameObject;
        val_18.SetActive(value:  false);
        this.<>4__this.starParticle.Stop();
        this.<>4__this.glowParticle.Stop();
        UnityEngine.Transform val_3 = this.<>4__this.giftGroup.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.giftGroup, endValue:  new UnityEngine.Vector3(), duration:  val_4.x);
        UnityEngine.WaitForSeconds val_6 = null;
        val_19 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_4.x);
        val_18 = 1;
        this.<>1__state = val_18;
        this.<>2__current = ;
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

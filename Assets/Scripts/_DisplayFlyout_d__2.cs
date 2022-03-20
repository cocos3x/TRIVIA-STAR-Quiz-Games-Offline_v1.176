using UnityEngine;
private sealed class TRVFlyout.<DisplayFlyout>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVFlyout <>4__this;
    public string text;
    public float seconds;
    private UnityEngine.CanvasGroup <cg>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVFlyout.<DisplayFlyout>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        object val_11;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 8044288 + (8044288 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                8044288 + (this.<>1__state) << 2 = (8044288 + (this.<>1__state) << 2) & ((8044288 + (this.<>1__state) << 2) << (8044288 + (this.<>1__state) << 2));
            8044288 + (this.<>1__state) << 2 = (8044288 + (this.<>1__state) << 2) & ((R8) << 8044288);
            8044288 + (this.<>1__state) << 2 = (8044288 + (this.<>1__state) << 2) & (((int)IP) >> 2);
            8044288 + (this.<>1__state) << 2 = (8044288 + (this.<>1__state) << 2) & 471474756;
        }
        
            this.<>1__state = 0;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.flyoutObject);
            this.<cg>5__2 = this.<>4__this.flyoutObject;
            this.<>4__this.flyoutObject.alpha = null;
            UnityEngine.GameObject val_3 = this.<>4__this.flyoutObject.gameObject;
            val_10 = 1;
            this.<>4__this.flyoutObject.SetActive(value:  true);
            val_11 = 15948;
            val_11 = 1045220557;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<cg>5__2, endValue:  null, duration:  null);
            this.<>1__state = val_10;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool);
        }
        
        val_10 = 0;
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
